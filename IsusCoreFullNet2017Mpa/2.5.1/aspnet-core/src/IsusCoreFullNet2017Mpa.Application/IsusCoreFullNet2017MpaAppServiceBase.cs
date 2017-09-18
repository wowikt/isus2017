using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using IsusCoreFullNet2017Mpa.MultiTenancy;
using Abp.Runtime.Session;
using Abp.IdentityFramework;
using IsusCoreFullNet2017Mpa.Authorization.Users;
using Microsoft.AspNetCore.Identity;

namespace IsusCoreFullNet2017Mpa
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class IsusCoreFullNet2017MpaAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected IsusCoreFullNet2017MpaAppServiceBase()
        {
            LocalizationSourceName = IsusCoreFullNet2017MpaConsts.LocalizationSourceName;
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