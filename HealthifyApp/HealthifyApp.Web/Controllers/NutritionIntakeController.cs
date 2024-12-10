using HealthifyApp.Service.Data.Interfaces;
using HealthifyApp.Services.Data.Interfaces;
using HealthifyApp.Web.Infrastructure.Extensions;
using HealthifyApp.Web.ViewModels.NutritionIntake;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using static HealthifyApp.Common.ErrorMessages.NutritionIntake;

namespace HealthifyApp.Web.Controllers
{
    public class NutritionIntakeController : BaseController
    {
        private readonly INutritionIntakeService nutritionIntakeService;

        public NutritionIntakeController(IBaseService baseService, INutritionIntakeService nutritionIntakeService)
            : base(baseService)
        {
            this.nutritionIntakeService = nutritionIntakeService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var userId = User.GetUserId();

            var viewModel = await this.nutritionIntakeService.GetNutritionIntakeIndexAsync(new Guid(userId!));

            if (viewModel == null)
            {
                TempData["ErrorMessage"] = NutritionIntakeNotFound;
                return RedirectToAction("Index", "TargetNutrition");
            }

            return View(viewModel);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> AddIntake()
        {
            AddTodayNutritionIntakeFormModel? formModel = await this.nutritionIntakeService.AddNutritionIntakeAsync();

            if (formModel == null)
            {
                TempData["ErrorMessage"] = NutritionIntakeAlreadyExist;
                return RedirectToAction(nameof(Index));
            }

            return View(formModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddIntake(AddTodayNutritionIntakeFormModel formModel)
        {
            if (!ModelState.IsValid)
            {
                return View(formModel);
            }
            var userId = User.GetUserId();

            var result = await this.nutritionIntakeService.AddNutritionIntakeAsync(formModel, new Guid(userId!));
            if (result == null)
            {
                TempData["ErrorMessage"] = NutritionIntakeAlreadyExist;
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> AddMore()
        {
            AddTodayNutritionIntakeFormModel? formModel = await this.nutritionIntakeService.AddMoreNutritionIntakeAsync();

            if (formModel == null)
            {
                TempData["ErrorMessage"] = NutritionIntakeAlreadyExist;
                return RedirectToAction(nameof(Index));
            }

            return View(formModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddMore(AddTodayNutritionIntakeFormModel formModel)
        {
            if (!ModelState.IsValid)
            {
                return View(formModel);
            }
            var userId = User.GetUserId();

            var result = await this.nutritionIntakeService.AddMoreNutritionIntakeAsync(formModel, new Guid(userId!));
            if (result == null)
            {
                TempData["ErrorMessage"] = NutritionIntakeAlreadyExist;
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
