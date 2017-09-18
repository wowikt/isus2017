using System;
using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Authorization.Users;
using Abp.Configuration;
using Abp.Configuration.Startup;
using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.Zero.Configuration;
using IsusCoreFullNet2017Spa.Authorization.IsusUser;
using IsusCoreFullNet2017Spa.Authorization.Roles;
using IsusCoreFullNet2017Spa.Authorization.Users;
using IsusCoreFullNet2017Spa.MultiTenancy;
using Microsoft.AspNetCore.Identity;

namespace IsusCoreFullNet2017Spa.Authorization
{
    public class LogInManager : AbpLogInManager<Tenant, Role, User>
    {
        private readonly IsusUserManager _isusUserManager;
        private readonly UserRegistrationManager _userRegistrationManager;

        public LogInManager(
            UserManager userManager,
            IsusUserManager isusUserManager,
            IMultiTenancyConfig multiTenancyConfig,
            IRepository<Tenant> tenantRepository,
            IUnitOfWorkManager unitOfWorkManager,
            ISettingManager settingManager,
            IRepository<UserLoginAttempt, long> userLoginAttemptRepository,
            IUserManagementConfig userManagementConfig,
            IIocResolver iocResolver,
            IPasswordHasher<User> passwordHasher,
            RoleManager roleManager, UserRegistrationManager userRegistrationManager,
            UserClaimsPrincipalFactory claimsPrincipalFactory)
            : base(
                userManager,
                multiTenancyConfig,
                tenantRepository,
                unitOfWorkManager,
                settingManager,
                userLoginAttemptRepository,
                userManagementConfig,
                iocResolver,
                passwordHasher,
                roleManager,
                claimsPrincipalFactory)
        {
            _isusUserManager = isusUserManager;
            _userRegistrationManager = userRegistrationManager;
        }

        public override async Task<AbpLoginResult<Tenant, User>> LoginAsync(string userNameOrEmailAddress,
            string plainPassword, string tenancyName = null,
            bool shouldLockout = true)
        {
            var result = await base.LoginAsync(userNameOrEmailAddress, plainPassword, tenancyName, shouldLockout);

            if (result.Result == AbpLoginResultType.InvalidUserNameOrEmailAddress)
            {
                var isusUser = _isusUserManager.FindUser(tenancyName, userNameOrEmailAddress);
                if (isusUser == null)
                {
                    return result;
                }

                if (_isusUserManager.TryUserLogin(isusUser, plainPassword))
                {
                    string[] nameParts = isusUser.CurrentName.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    User user = await _userRegistrationManager.RegisterAsync(nameParts[1], nameParts[0],
                        isusUser.Email ?? $"{isusUser.Id}@nshkola.ru", isusUser.AccountName, plainPassword, true);

                    if (user != null)
                    {
                        return await base.LoginAsync(userNameOrEmailAddress, plainPassword, tenancyName, shouldLockout);
                    }

                    return result;
                }

                return result;
            }

            return result;
        }
    }
}
