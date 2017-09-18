using IsusCore2017Spa.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace IsusCore2017Spa.Web.Host.Controllers
{
    public class AntiForgeryController : IsusCore2017SpaControllerBase
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