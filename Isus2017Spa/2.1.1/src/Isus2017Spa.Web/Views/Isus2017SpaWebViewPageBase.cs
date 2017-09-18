using Abp.Web.Mvc.Views;

namespace Isus2017Spa.Web.Views
{
    public abstract class Isus2017SpaWebViewPageBase : Isus2017SpaWebViewPageBase<dynamic>
    {

    }

    public abstract class Isus2017SpaWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected Isus2017SpaWebViewPageBase()
        {
            LocalizationSourceName = Isus2017SpaConsts.LocalizationSourceName;
        }
    }
}