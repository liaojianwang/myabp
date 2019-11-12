using Microsoft.AspNetCore.Antiforgery;
using TheEndProject.Controllers;

namespace TheEndProject.Web.Host.Controllers
{
    public class AntiForgeryController : TheEndProjectControllerBase
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
