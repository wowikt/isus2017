using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Isus2017Spa.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : Isus2017SpaControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}