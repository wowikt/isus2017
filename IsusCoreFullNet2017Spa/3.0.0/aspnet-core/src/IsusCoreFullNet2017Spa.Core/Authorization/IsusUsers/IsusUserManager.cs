using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Authorization.Users;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using Abp.UI;
using Castle.Core.Logging;
using IsusCoreFullNet2017Spa.Authorization.Roles;
using IsusCoreFullNet2017Spa.Authorization.Users;
using IsusCoreFullNet2017Spa.IsusModels;
using IsusCoreFullNet2017Spa.MultiTenancy;
using Microsoft.AspNetCore.Identity;

namespace IsusCoreFullNet2017Spa.Authorization.IsusUsers
{
    public class IsusUserManager : DomainService
    {
        public IAbpSession AbpSession { get; set; }

        private readonly IRepository<IsusUser, long> _isusUserRepository;
        private readonly IRepository<UserParentship> _userParentshipRepository;
        private readonly IRepository<FGroupBasicSostav, long> _groupBasicMembersRepository;
        private readonly ILogger _logger;
        private readonly UserManager _userManager;
        private readonly IPasswordHasher<User> _passwordHasher;
        private readonly TenantManager _tenantManager;

        public IsusUserManager(IRepository<IsusUser, long> isusUserRepository, ILogger logger,
            UserManager userManager, TenantManager tenantManager, IPasswordHasher<User> passwordHasher,
            IRepository<UserParentship> userParentshipRepository, IRepository<FGroupBasicSostav, long> groupBasicMembersRepository)
        {
            _isusUserRepository = isusUserRepository;
            _logger = logger;
            _userManager = userManager;
            _passwordHasher = passwordHasher;
            _tenantManager = tenantManager;
            _userParentshipRepository = userParentshipRepository;
            _groupBasicMembersRepository = groupBasicMembersRepository;

            AbpSession = NullAbpSession.Instance;
        }

        public async Task<IsusUser> FindUser(string userName)
        {
            var tenant = await GetActiveTenantAsync();

            if (tenant == null || tenant.TenancyName.ToLower() != Tenant.NShkolaTenancyName.ToLower())
            {
                throw new UserFriendlyException(L("IsusUser.OnlyForNShkola"));
            }

            IsusUser user =
                await _isusUserRepository.FirstOrDefaultAsync(u => u.AccountName == userName && (u.AccountValid ?? false));
            return user;
        }

        public bool TryUserLogin(IsusUser user, string password)
        {
#if DEBUG
            if (user.AccountPwd == null)
            {
                throw new UserFriendlyException(L("IsusUser.HasNoPassword"));
            }

            // В отладочном режиме - проверяем просто по паролю
            if (user.AccountPwd != password)
            {
                _logger.Debug($"UserDataProvider.Login: user {user.AccountName} password does not match");
                return false;
            }

            return true;
#else 
            if (user.AccountPwdMd5 == null)
            {
                throw new UserFriendlyException(L("IsusUser.HasNoPassword"));
            }

            // В рабочем режиме по MD5
            System.Security.Cryptography.MD5CryptoServiceProvider md5Obj =
                new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] pwdMd5 = Encoding.UTF8.GetBytes(password);
            pwdMd5 = md5Obj.ComputeHash(pwdMd5);
            for (int i = 0; i < pwdMd5.Length; i++)
            {
                if (pwdMd5[i] != user.AccountPwdMd5[i])
                {
                    _logger.Debug($"UserDataProvider.Login: user {user.AccountName} password md5 does not match");
                    return false;
                }
            }

            return true;
#endif
        }

        public async Task<User> CreateUserForIsusUserAsync(IsusUser isusUser, string password)
        {
            string[] nameParts = isusUser.CurrentName.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            var tenant = await GetActiveTenantAsync();

            User user = new User
            {
                UserName = isusUser.AccountName,
                Name = nameParts[1],
                Surname = nameParts[0],
                Password = password,
                EmailAddress = isusUser.Email ?? $"{isusUser.Id}@nshkola.ru",
                IsEmailConfirmed = true,
                IsActive = true,
                Roles = new List<UserRole>(),
                TenantId = tenant.Id,
                IsusUser = isusUser,
            };

            user.SetNormalizedNames();
            user.Password = _passwordHasher.HashPassword(user, password);

            var userResult = await _userManager.CreateAsync(user);
            userResult.CheckErrors(LocalizationManager);

            List<string> roleNames = new List<string>();
            if (isusUser.IsAdmin ?? false)
            {
                roleNames.Add(StaticRoleNames.Tenants.Admin);
            }

            if (isusUser.IsBoss ?? false)
            {
                roleNames.Add(StaticRoleNames.Tenants.Boss);
            }

            if (isusUser.IsDeveloper ?? false)
            {
                roleNames.Add(StaticRoleNames.Tenants.Developer);
            }

            if (isusUser.SurplusIsTeacher ?? false)
            {
                roleNames.Add(StaticRoleNames.Tenants.Teacher);
            }

            if (await _userParentshipRepository.FirstOrDefaultAsync(up => up.ParentId == isusUser.Id) != null)
            {
                roleNames.Add(StaticRoleNames.Tenants.Parent);
            }

            if (await _groupBasicMembersRepository.FirstOrDefaultAsync(gbm => gbm.PupilId == isusUser.Id) != null)
            {
                roleNames.Add(StaticRoleNames.Tenants.Pupil);
            }

            var rolesResult = await _userManager.SetRoles(user, roleNames.ToArray());
            rolesResult.CheckErrors(LocalizationManager);

            await CurrentUnitOfWork.SaveChangesAsync();

            return user;
        }

        private async Task<Tenant> GetActiveTenantAsync()
        {
            if (!AbpSession.TenantId.HasValue)
            {
                return null;
            }

            return await GetActiveTenantAsync(AbpSession.TenantId.Value);
        }

        private async Task<Tenant> GetActiveTenantAsync(int tenantId)
        {
            var tenant = await _tenantManager.FindByIdAsync(tenantId);
            if (tenant == null)
            {
                throw new UserFriendlyException(L("UnknownTenantId{0}", tenantId));
            }

            if (!tenant.IsActive)
            {
                throw new UserFriendlyException(L("TenantIdIsNotActive{0}", tenantId));
            }

            return tenant;
        }

        public async Task<long?> CreateUser(IsusUser user)
        {
            if (await _isusUserRepository.FirstOrDefaultAsync(iu => iu.AccountName == user.AccountName) != null)
            {
                throw new UserFriendlyException(L("Identity.DuplicateUserName"));
            }

            SetPassword(user, user.AccountPwd);

            user.BeforeSave();
            return await _isusUserRepository.InsertAndGetIdAsync(user);
        }

        public void SetPassword(IsusUser isusUser, string password)
        {
            isusUser.AccountPwd = password;
            System.Security.Cryptography.MD5CryptoServiceProvider md5Obj =
                new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] pwdMd5 = Encoding.UTF8.GetBytes(isusUser.AccountPwd);
            pwdMd5 = md5Obj.ComputeHash(pwdMd5);
            isusUser.AccountPwdMd5 = pwdMd5;
        }
    }
}
