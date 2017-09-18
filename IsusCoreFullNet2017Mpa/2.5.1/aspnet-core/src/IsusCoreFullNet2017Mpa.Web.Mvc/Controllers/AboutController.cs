using IsusCoreFullNet2017Mpa.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace IsusCoreFullNet2017Mpa.Web.Controllers
{
    public class AboutController : IsusCoreFullNet2017MpaControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}