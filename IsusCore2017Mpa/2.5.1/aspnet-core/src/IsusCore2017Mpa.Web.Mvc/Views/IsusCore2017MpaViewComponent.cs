using Abp.AspNetCore.Mvc.ViewComponents;

namespace IsusCore2017Mpa.Web.Views
{
    public abstract class IsusCore2017MpaViewComponent : AbpViewComponent
    {
        protected IsusCore2017MpaViewComponent()
        {
            LocalizationSourceName = IsusCore2017MpaConsts.LocalizationSourceName;
        }
    }
}