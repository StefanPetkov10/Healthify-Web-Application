using HealthifyApp.Services.Data.Interfaces;
using HealthifyApp.Web.ViewModels.BMI;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HealthifyApp.Web.Controllers
{
    public class BMIController : BaseController
    {
        public BMIController(IBaseService baseService) : base(baseService)
        {
        }

        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {
            return View(new BMICalculationViewModel());
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CalculateBMI(BMICalculationViewModel model)
        {

        }
    }
}
