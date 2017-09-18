using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Isus2017CoreSpa.Controllers
{
    public abstract class Isus2017CoreSpaControllerBase: AbpController
    {
        protected Isus2017CoreSpaControllerBase()
        {
            LocalizationSourceName = Isus2017CoreSpaConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}