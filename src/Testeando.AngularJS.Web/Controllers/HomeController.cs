using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Testeando.AngularJS.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : AngularJSControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}