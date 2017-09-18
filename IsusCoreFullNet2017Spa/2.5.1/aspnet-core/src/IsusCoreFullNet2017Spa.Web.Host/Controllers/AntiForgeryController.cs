using IsusCoreFullNet2017Spa.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace IsusCoreFullNet2017Spa.Web.Host.Controllers
{
    public class AntiForgeryController : IsusCoreFullNet2017SpaControllerBase
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