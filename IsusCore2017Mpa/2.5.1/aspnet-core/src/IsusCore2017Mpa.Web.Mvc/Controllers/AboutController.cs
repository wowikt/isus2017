using IsusCore2017Mpa.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace IsusCore2017Mpa.Web.Controllers
{
    public class AboutController : IsusCore2017MpaControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}