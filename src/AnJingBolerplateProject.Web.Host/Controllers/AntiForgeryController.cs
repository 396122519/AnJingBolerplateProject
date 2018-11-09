using Microsoft.AspNetCore.Antiforgery;
using AnJingBolerplateProject.Controllers;

namespace AnJingBolerplateProject.Web.Host.Controllers
{
    public class AntiForgeryController : AnJingBolerplateProjectControllerBase
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
