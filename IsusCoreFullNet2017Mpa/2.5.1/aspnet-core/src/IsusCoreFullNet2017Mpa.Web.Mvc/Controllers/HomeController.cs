using Abp.AspNetCore.Mvc.Authorization;
using IsusCoreFullNet2017Mpa.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace IsusCoreFullNet2017Mpa.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : IsusCoreFullNet2017MpaControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}