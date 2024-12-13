using HealthifyApp.Service.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HealthifyApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService homeService;

        public HomeController(IHomeService homeService)
        {
            this.homeService = homeService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {

            var userName = User.Identity.Name;
            var model = await homeService.GetHomeIndexViewModelAsync(userName!);
            return View(model);

        }


        public IActionResult Error(int? statusCode = null)
        {
            // TODO: Add other pages
            if (!statusCode.HasValue)
            {
                return this.View();
            }

            if (statusCode == 404)
            {
                return this.View("Error404");
            }
            else if (statusCode == 401 || statusCode == 403)
            {
                return this.View("Error403");
            }

            return this.View("Error500");
        }
    }
}
