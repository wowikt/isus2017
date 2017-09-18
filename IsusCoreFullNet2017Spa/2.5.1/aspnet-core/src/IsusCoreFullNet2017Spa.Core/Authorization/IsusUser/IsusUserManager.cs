using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Authorization.Users;
using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.IdentityFramework;
using Abp.Localization;
using Abp.Runtime.Session;
using Abp.UI;
using Castle.Core.Logging;
using IsusCoreFullNet2017Spa.Authorization.Users;
using IsusCoreFullNet2017Spa.MultiTenancy;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace IsusCoreFullNet2017Spa.Authorization.IsusUser
{
    public class IsusUserManager : DomainService
    {
        public IAbpSession AbpSession { get; set; }

        private readonly IRepository<IsusModels.IsusUser> _isusUserRepository;
        private readonly ILogger _logger;
        private readonly UserManager _userManager;
        private readonly IPasswordHasher<User> _passwordHasher;
        private readonly TenantManager _tenantManager;

        public IsusUserManager(IRepository<IsusModels.IsusUser> isusUserRepository, ILogger logger,
            UserManager userManager, TenantManager tenantManager, IPasswordHasher<User> passwordHasher)
        {
            _isusUserRepository = isusUserRepository;
            _logger = logger;
            _userManager = userManager;
            _passwordHasher = passwordHasher;
            _tenantManager = tenantManager;

            AbpSession = NullAbpSession.Instance;
        }

        public IsusModels.IsusUser FindUser(string tenancyName, string userName)
        {
            if (tenancyName.ToLower() != Tenant.NSchoolTenancyName.ToLower())
            {
                return null;
            }

            IsusModels.IsusUser user =
                _isusUserRepository.FirstOrDefault(u => u.AccountName == userName && (u.AccountValid ?? false));
            return user;
        }

        public bool TryUserLogin(IsusModels.IsusUser user, string password)
        {
#if DEBUG
            // В отладочном режиме - проверяем просто по паролю
            if (user.AccountPwd != password)
            {
                _logger.Debug($"UserDataProvider.Login: user {user.AccountName} password does not match");
                return false;
            }

            return true;
#else 
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

        public async Task<bool> CreateUserForIsusUserAsync(IsusModels.IsusUser isusUser, string password)
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
            };

            user.SetNormalizedNames();

            user.Password = _passwordHasher.HashPassword(user, password);
            var result = await _userManager.CreateAsync(user);
            result.CheckErrors(LocalizationManager);
            await CurrentUnitOfWork.SaveChangesAsync();

            return result.Succeeded;
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
    }
}
