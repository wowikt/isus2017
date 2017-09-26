using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using IsusCoreFullNet2017Spa.Authorization;
using IsusCoreFullNet2017Spa.Authorization.Users;
using IsusCoreFullNet2017Spa.Users.Dto;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using Abp.Authorization;
using Abp.Authorization.Users;
using Abp.Extensions;
using Microsoft.EntityFrameworkCore;
using Abp.IdentityFramework;
using Abp.UI;
using Castle.Core.Logging;
using IsusCoreFullNet2017Spa.Authorization.IsusUsers;
using IsusCoreFullNet2017Spa.Authorization.Roles;
using IsusCoreFullNet2017Spa.IsusModels;
using IsusCoreFullNet2017Spa.MultiTenancy;
using IsusCoreFullNet2017Spa.Roles.Dto;
using Microsoft.AspNetCore.Http.Authentication;
using IsusCoreFullNet2017Spa.IsusModels.XmlSubModels.IsusUser;

namespace IsusCoreFullNet2017Spa.Users
{
    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class UserAppService : AsyncCrudAppService<User, UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>, IUserAppService
    {
        private readonly UserManager _userManager;
        private readonly RoleManager _roleManager;
        private readonly IPasswordHasher<User> _passwordHasher;
        private readonly IRepository<Role> _roleRepository;
        private readonly IsusUserManager _isusUserManager;
        private readonly AbpSignInManager<Tenant, Role, User> _signInManager;

        public UserAppService(IRepository<User, long> repository, UserManager userManager,
            IPasswordHasher<User> passwordHasher, IRepository<Role> roleRepository, RoleManager roleManager,
            IsusUserManager isusUserManager, AbpSignInManager<Tenant, Role, User> signInManager)
            : base(repository)
        {
            _userManager = userManager;
            _passwordHasher = passwordHasher;
            _roleRepository = roleRepository;
            _roleManager = roleManager;
            _isusUserManager = isusUserManager;
            _signInManager = signInManager;
        }

        public override async Task<UserDto> Create(CreateUserDto input)
        {
            CheckCreatePermission();

            var isusUser = ObjectMapper.Map<IsusUser>(input);
            isusUser.AccountPwd = input.Password;

            var userDetail = isusUser.UserCard.Body[0];
            isusUser.CurrentName = $"{userDetail.LastName.ToPascalCase()} {userDetail.FirstName.ToPascalCase()} {userDetail.MiddleName.ToPascalCase()}";
            isusUser.CurrentShortName =
                $"{userDetail.LastName.ToPascalCase()} {char.ToUpper(userDetail.FirstName[0])}. {char.ToUpper(userDetail.MiddleName[0])}.";

            long? isusUserId = await _isusUserManager.CreateUser(isusUser);
            if (isusUserId != null)
            {
                User user = new User
                {
                    Name = userDetail.FirstName,
                    Surname = userDetail.LastName,
                    UserName = isusUser.AccountName,
                };
                user.TenantId = AbpSession.TenantId;
                user.Password = _passwordHasher.HashPassword(user, input.Password);
                user.IsEmailConfirmed = true;
                user.IsusUserId = isusUserId;

                CheckErrors(await _userManager.CreateAsync(user));

                if (input.RoleNames != null)
                {
                    CheckErrors(await _userManager.SetRoles(user, input.RoleNames));
                }

                CurrentUnitOfWork.SaveChanges();
            }

            return MapToEntityDto(isusUser);
        }

        public override async Task<UserDto> Update(UserDto input)
        {
            CheckUpdatePermission();

            var user = await _userManager.GetUserByIdAsync(input.Id);

            MapToEntity(input, user);

            CheckErrors(await _userManager.UpdateAsync(user));

            if (input.RoleNames != null)
            {
                CheckErrors(await _userManager.SetRoles(user, input.RoleNames));
            }

            return await Get(input);
        }

        public override async Task Delete(EntityDto<long> input)
        {
            var user = await _userManager.GetUserByIdAsync(input.Id);
            await _userManager.DeleteAsync(user);
        }

        public async Task<ListResultDto<RoleDto>> GetRoles()
        {
            var roles = await _roleRepository.GetAllListAsync();
            return new ListResultDto<RoleDto>(ObjectMapper.Map<List<RoleDto>>(roles));
        }

        [AbpAuthorize]
        public async Task ChangePassword(ChangePasswordDto changePasswordDto)
        {
            long userId = AbpSession.UserId ?? 0;
            if (userId == 0)
            {
                Logger.Error("UserAppService.ChangePassword: no user logged in");
                return;
            }

            var user = await _userManager.GetUserByIdAsync(userId);
            if (user == null)
            {
                Logger.Error("UserAppService.ChangePassword: user does not exist");
                return;
            }

            CheckErrors(await _userManager.ChangePasswordAsync(user, changePasswordDto.CurrentPassword,
                changePasswordDto.NewPassword));
            Logger.Info("AccountController.Password: password successfully updated, logging out...");

            await _signInManager.SignOutAsync();
        }

        protected override User MapToEntity(CreateUserDto createInput)
        {
            var user = ObjectMapper.Map<User>(createInput);
            user.SetNormalizedNames();
            return user;
        }

        protected override void MapToEntity(UserDto input, User user)
        {
            ObjectMapper.Map(input, user);
            user.SetNormalizedNames();
        }

        protected override UserDto MapToEntityDto(User user)
        {
            var roles = _roleManager.Roles.Where(r => user.Roles.Any(ur => ur.RoleId == r.Id)).Select(r => r.NormalizedName);
            var userDto = new UserDto
            {
                AccountName = user.UserName,
                Name = user.Name,
                Surname = user.Surname,
                Email = user.EmailAddress,
                FullName = $"{user.Surname} {user.Name}",
                IsActive = user.IsActive,
            };

            userDto.RoleNames = roles.ToArray();
            return userDto;
        }

        protected UserDto MapToEntityDto(IsusUser user)
        {
            return ObjectMapper.Map<UserDto>(user);
        }

        protected override IQueryable<User> CreateFilteredQuery(PagedResultRequestDto input)
        {
            return Repository.GetAllIncluding(x => x.Roles);
        }

        protected override async Task<User> GetEntityByIdAsync(long id)
        {
            return await Repository.GetAllIncluding(x => x.Roles).FirstOrDefaultAsync(x => x.Id == id);
        }

        protected override IQueryable<User> ApplySorting(IQueryable<User> query, PagedResultRequestDto input)
        {
            return query.OrderBy(r => r.IsusUserId == null ? r.UserName : r.IsusUser.CurrentName);
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}