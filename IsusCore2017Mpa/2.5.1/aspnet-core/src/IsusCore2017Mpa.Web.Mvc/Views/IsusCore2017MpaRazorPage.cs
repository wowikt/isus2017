using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace IsusCore2017Mpa.Web.Views
{
    public abstract class IsusCore2017MpaRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected IsusCore2017MpaRazorPage()
        {
            LocalizationSourceName = IsusCore2017MpaConsts.LocalizationSourceName;
        }
    }
}
