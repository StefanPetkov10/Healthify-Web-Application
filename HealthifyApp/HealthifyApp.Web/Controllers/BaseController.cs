using Microsoft.AspNetCore.Mvc;

namespace HealthifyApp.Web.Controllers
{
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
