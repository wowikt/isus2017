using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace IsusCore2017Mpa.Controllers
{
    public abstract class IsusCore2017MpaControllerBase: AbpController
    {
        protected IsusCore2017MpaControllerBase()
        {
            LocalizationSourceName = IsusCore2017MpaConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}