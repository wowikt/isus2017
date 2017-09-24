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

namespace IsusCoreFullNet2017Spa.Authorization.Users
{
    public class UserManager : AbpUserManager<Role, User>
    {
        private readonly UserStore _userStore;

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
        }

        public async Task<long?> GetIsusUserId(long userId)
        {
            return (await _userStore.UserRepository.FirstOrDefaultAsync(userId))?.IsusUserId;
        }

        public async Task<long?> GetIsusUserId(User user)
        {
            return user == null ? null : (await _userStore.UserRepository.FirstOrDefaultAsync(user.Id))?.IsusUserId;
        }
    }
}