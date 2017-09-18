using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace IsusCoreFullNet2017Mpa.Controllers
{
    public abstract class IsusCoreFullNet2017MpaControllerBase: AbpController
    {
        protected IsusCoreFullNet2017MpaControllerBase()
        {
            LocalizationSourceName = IsusCoreFullNet2017MpaConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}