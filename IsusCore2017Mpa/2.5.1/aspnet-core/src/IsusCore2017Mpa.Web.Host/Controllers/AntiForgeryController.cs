using IsusCore2017Mpa.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace IsusCore2017Mpa.Web.Host.Controllers
{
    public class AntiForgeryController : IsusCore2017MpaControllerBase
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