using HealthifyApp.Service.Data.Interfaces;
using HealthifyApp.Services.Data.Interfaces;
using HealthifyApp.Web.Infrastructure.Extensions;
using HealthifyApp.Web.ViewModels.WaterIntake;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using static HealthifyApp.Common.ErrorMessages.WaterIntake;

namespace HealthifyApp.Web.Controllers
{
    public class WaterIntakeController : BaseController
    {
        private readonly IWaterIntakeService waterIntakeService;

        public WaterIntakeController(IBaseService baseService, IWaterIntakeService waterIntakeService)
            : base(baseService)
        {
            this.waterIntakeService = waterIntakeService;
        }
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Index()
        {
            return View(new WaterIntakeInputModel());
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> UpdateWaterIntake(WaterIntakeInputModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }

            var userId = User.GetUserId();

            float dailyGoal = this.waterIntakeService.CalculateWaterIntake(model.Weight, model.ActivityLevel);

            bool isUpdated = await this.waterIntakeService.CreateOrUpdateWaterIntakeAsync(new Guid(userId!), dailyGoal);

            if (!isUpdated)
            {
                TempData["Error"] = WaterIntakeUpdateFailed;
                return RedirectToAction(nameof(Index), "UserProfile");
            }

            var viewModel = await this.waterIntakeService.GetWaterIntakeAsync(dailyGoal);

            return View("Result", viewModel);
        }
    }
}
