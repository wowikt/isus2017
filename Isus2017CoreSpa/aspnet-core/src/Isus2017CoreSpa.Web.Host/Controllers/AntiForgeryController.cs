using Isus2017CoreSpa.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace Isus2017CoreSpa.Web.Host.Controllers
{
    public class AntiForgeryController : Isus2017CoreSpaControllerBase
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