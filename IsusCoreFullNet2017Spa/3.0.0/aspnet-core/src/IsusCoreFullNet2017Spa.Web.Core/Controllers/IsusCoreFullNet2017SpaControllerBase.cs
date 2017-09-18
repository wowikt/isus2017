using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace IsusCoreFullNet2017Spa.Controllers
{
    public abstract class IsusCoreFullNet2017SpaControllerBase: AbpController
    {
        protected IsusCoreFullNet2017SpaControllerBase()
        {
            LocalizationSourceName = IsusCoreFullNet2017SpaConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}