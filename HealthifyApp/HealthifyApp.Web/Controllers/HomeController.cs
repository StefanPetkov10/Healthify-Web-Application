using System.Diagnostics;
using Healthify.Service.Data.Interfaces;
using HealthifyApp.Web.Models;
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


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
