using IsusCoreFullNet2017Mpa.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace IsusCoreFullNet2017Mpa.Web.Host.Controllers
{
    public class AntiForgeryController : IsusCoreFullNet2017MpaControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}