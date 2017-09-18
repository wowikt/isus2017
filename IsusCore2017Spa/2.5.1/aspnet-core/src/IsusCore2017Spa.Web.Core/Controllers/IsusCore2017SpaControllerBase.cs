using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace IsusCore2017Spa.Controllers
{
    public abstract class IsusCore2017SpaControllerBase: AbpController
    {
        protected IsusCore2017SpaControllerBase()
        {
            LocalizationSourceName = IsusCore2017SpaConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}