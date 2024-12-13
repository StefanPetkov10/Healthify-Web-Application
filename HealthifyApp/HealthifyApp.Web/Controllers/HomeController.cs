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
            if (statusCode.HasValue)
            {
                if (statusCode == 404)
                {
                    return View("Error404");
                }
                else if (statusCode == 500)
                {
                    return View("Error500");
                }
            }

            return View("Error500");
        }

        [Route("simulate-error")]
        public IActionResult SimulateError()
        {
            throw new Exception("This is a simulated 500 Internal Server Error.");
        }
    }
}
