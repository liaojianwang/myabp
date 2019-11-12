using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using TheEndProject.Controllers;

namespace TheEndProject.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : TheEndProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
