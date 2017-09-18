using Abp.AspNetCore.Mvc.ViewComponents;

namespace IsusCoreFullNet2017Mpa.Web.Views
{
    public abstract class IsusCoreFullNet2017MpaViewComponent : AbpViewComponent
    {
        protected IsusCoreFullNet2017MpaViewComponent()
        {
            LocalizationSourceName = IsusCoreFullNet2017MpaConsts.LocalizationSourceName;
        }
    }
}