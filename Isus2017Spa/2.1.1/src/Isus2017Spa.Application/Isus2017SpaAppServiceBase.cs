using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using Isus2017Spa.Authorization.Users;
using Isus2017Spa.MultiTenancy;
using Isus2017Spa.Users;
using Microsoft.AspNet.Identity;

namespace Isus2017Spa
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class Isus2017SpaAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected Isus2017SpaAppServiceBase()
        {
            LocalizationSourceName = Isus2017SpaConsts.LocalizationSourceName;
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId());
            if (user == null)
            {
                throw new ApplicationException("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}