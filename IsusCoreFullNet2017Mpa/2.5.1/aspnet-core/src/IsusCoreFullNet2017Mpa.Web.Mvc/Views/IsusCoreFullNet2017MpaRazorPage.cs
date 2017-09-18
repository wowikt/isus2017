using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace IsusCoreFullNet2017Mpa.Web.Views
{
    public abstract class IsusCoreFullNet2017MpaRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected IsusCoreFullNet2017MpaRazorPage()
        {
            LocalizationSourceName = IsusCoreFullNet2017MpaConsts.LocalizationSourceName;
        }
    }
}
