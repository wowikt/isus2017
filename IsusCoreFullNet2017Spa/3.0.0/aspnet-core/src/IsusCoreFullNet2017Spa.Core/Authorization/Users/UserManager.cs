using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Authorization.Users;
using Abp.Configuration;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.Organizations;
using Abp.Runtime.Caching;
using IsusCoreFullNet2017Spa.Authorization.Roles;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using IsusCoreFullNet2017Spa.IsusModels;

namespace IsusCoreFullNet2017Spa.Authorization.Users
{
    public class UserManager : AbpUserManager<Role, User>
    {
        private readonly UserStore _userStore;
        private readonly IRepository<IsusUser, long> _isusUserRepository;

        public UserManager(
            RoleManager roleManager,
            UserStore store, 
            IOptions<IdentityOptions> optionsAccessor, 
            IPasswordHasher<User> passwordHasher, 
            IEnumerable<IUserValidator<User>> userValidators, 
            IEnumerable<IPasswordValidator<User>> passwordValidators,
            ILookupNormalizer keyNormalizer, 
            IdentityErrorDescriber errors, 
            IServiceProvider services, 
            ILogger<UserManager<User>> logger, 
            IPermissionManager permissionManager, 
            IUnitOfWorkManager unitOfWorkManager, 
            ICacheManager cacheManager, 
            IRepository<OrganizationUnit, long> organizationUnitRepository, 
            IRepository<UserOrganizationUnit, long> userOrganizationUnitRepository,
            IRepository<IsusUser, long> isusUserRepository,
            IOrganizationUnitSettings organizationUnitSettings, 
            ISettingManager settingManager)
            : base(
                roleManager, 
                store, 
                optionsAccessor, 
                passwordHasher, 
                userValidators, 
                passwordValidators, 
                keyNormalizer, 
                errors, 
                services, 
                logger, 
                permissionManager, 
                unitOfWorkManager, 
                cacheManager,
                organizationUnitRepository, 
                userOrganizationUnitRepository, 
                organizationUnitSettings, 
                settingManager)
        {
            _userStore = store;
            _isusUserRepository = isusUserRepository;
        }

        public async Task<long?> GetIsusUserId(long userId)
        {
            return (await _userStore.UserRepository.FirstOrDefaultAsync(userId))?.IsusUserId;
        }

        public long? GetIsusUserId(User user)
        {
            return user?.IsusUserId;
        }

        public override async Task<User> GetUserByIdAsync(long userId)
        {
            var result = await base.GetUserByIdAsync(userId);
            if (result.IsusUser == null && result.IsusUserId.HasValue)
            {
                result.IsusUser = _isusUserRepository.Get(result.IsusUserId.Value);
            }

            return result;
        }
    }
}