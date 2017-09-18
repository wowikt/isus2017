using Abp.AspNetCore.Mvc.Authorization;
using IsusCore2017Mpa.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace IsusCore2017Mpa.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : IsusCore2017MpaControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}