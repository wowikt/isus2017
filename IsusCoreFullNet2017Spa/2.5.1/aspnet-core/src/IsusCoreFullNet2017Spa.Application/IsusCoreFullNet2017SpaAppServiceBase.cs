using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using IsusCoreFullNet2017Spa.MultiTenancy;
using Abp.Runtime.Session;
using Abp.IdentityFramework;
using IsusCoreFullNet2017Spa.Authorization.Users;
using Microsoft.AspNetCore.Identity;

namespace IsusCoreFullNet2017Spa
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class IsusCoreFullNet2017SpaAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected IsusCoreFullNet2017SpaAppServiceBase()
        {
            LocalizationSourceName = IsusCoreFullNet2017SpaConsts.LocalizationSourceName;
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId().ToString());
            if (user == null)
            {
                throw new Exception("There is no current user!");
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