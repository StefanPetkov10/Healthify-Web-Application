using HealthifyApp.Data.Models.Enums;
using HealthifyApp.Service.Data.Interfaces;
using HealthifyApp.Services.Data.Interfaces;
using HealthifyApp.Web.Infrastructure.Extensions;
using HealthifyApp.Web.ViewModels.BMI;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using static HealthifyApp.Common.ErrorMessages.BMI;

namespace HealthifyApp.Web.Controllers
{
    public class BMIController : BaseController
    {
        private readonly IBMIService bmiService;

        public BMIController(IBaseService baseService,
                                IBMIService bmiService)
            : base(baseService)
        {
            this.bmiService = bmiService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Index()
        {
            return View(new BMICalculationInputModel());
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CalculateBMI(BMICalculationInputModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(nameof(Index), model);
            }

            var userId = User.GetUserId();

            float bmi = this.bmiService.CalculateBMI(model.Weight, model.Height);

            BMICategory category = this.bmiService.DetermineBMICategory(bmi);

            bool isUpdated = await this.bmiService.CreateOrUpdateBMIAsync(new Guid(userId!), bmi, category);

            if (!isUpdated)
            {
                TempData["Error"] = BMICalculationFailed;
                return RedirectToAction(nameof(Index), "UserProfile");
            }

            var viewModel = await this.bmiService.GetBMIAsync(bmi);

            return View("Result", viewModel);
        }
    }
}
