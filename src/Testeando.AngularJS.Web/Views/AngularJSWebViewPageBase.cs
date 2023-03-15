using Abp.Web.Mvc.Views;

namespace Testeando.AngularJS.Web.Views
{
    public abstract class AngularJSWebViewPageBase : AngularJSWebViewPageBase<dynamic>
    {

    }

    public abstract class AngularJSWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected AngularJSWebViewPageBase()
        {
            LocalizationSourceName = AngularJSConsts.LocalizationSourceName;
        }
    }
}