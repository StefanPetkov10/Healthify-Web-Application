using HealthifyApp.Data.Models;
using HealthifyApp.Service.Data.Interfaces;
using HealthifyApp.Services.Data.Interfaces;
using HealthifyApp.Web.Infrastructure.Extensions;
using HealthifyApp.Web.ViewModels.Goal;
using HealthifyApp.Web.ViewModels.TargetNutrition;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using static HealthifyApp.Common.ErrorMessages.TargetNutrition;

namespace HealthifyApp.Web.Controllers
{
    public class TargetNutritionController : BaseController
    {
        private readonly INutritionCalculatorService nutritionCalculatorService;
        private readonly ITargetNutritionService targetNutritionService;
        private readonly IGoalService goalService;

        public TargetNutritionController(IBaseService baseService,
                                            INutritionCalculatorService nutritionCalculatorService,
                                                ITargetNutritionService targetNutritionService,
                                                    IGoalService goalService)
            : base(baseService)
        {
            this.nutritionCalculatorService = nutritionCalculatorService;
            this.targetNutritionService = targetNutritionService;
            this.goalService = goalService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var userId = User.GetUserId();
            var viewModel = await this.targetNutritionService.IndexGetTargetNutritionAsync(new Guid(userId!));

            if (viewModel == null)
            {
                return RedirectToAction("Index", "Goal");
            }
            return View(viewModel);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Create(string goalId)
        {
            Guid goalGuid = Guid.Empty;
            bool isIdValid = this.IsGuidValid(goalId, out goalGuid);
            if (!isIdValid)
            {
                return RedirectToAction("Index", "Goal");
            }

            var goal = await this.goalService.GetGoalByIdAsync(goalGuid);
            if (goal == null)
            {
                return RedirectToAction("Index", "Goal");
            }

            TargetNutrition calculatedNutrition = this.nutritionCalculatorService.CalculateTargetNutrition(goal);

            var viewModel = await this.targetNutritionService.CreateTargetNutritionAsync(calculatedNutrition, goalGuid);

            if (viewModel == null)
            {
                TempData["ErrorMessage"] = TargetNutritionAlreadyExist;
                return RedirectToAction("Index", "Goal");
            }

            return View(viewModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CreateTargetNutritionFormModel formModel)
        {
            Guid goalGuid = Guid.Empty;
            bool isIdValid = this.IsGuidValid(formModel.GoalId, out goalGuid);
            if (!isIdValid)
            {
                return RedirectToAction("Index", "Goal");
            }

            var goal = await this.goalService.GetGoalByIdAsync(goalGuid);
            if (goal == null)
            {
                return RedirectToAction("Index", "Goal");
            }

            var userId = User.GetUserId();

            bool result = await targetNutritionService.CreateTargetNutritionAsync(formModel, new Guid(userId!));

            if (!result)
            {
                return RedirectToAction("Create", new { goalId = formModel.GoalId });
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Delete(string? id)
        {
            if (!this.IsGuidValid(id, out Guid targetNutritionId))
            {
                return RedirectToAction(nameof(Index));
            }

            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }

            var viewModel = await this.targetNutritionService.DeleteTargetNutritionAsync(targetNutritionId);

            if (viewModel == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(viewModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Delete(DeleteGoalViewModel model)
        {
            bool result = await this.targetNutritionService.DeletePermanentlyTargetNutritionAsync(new Guid(model.Id));
            if (!result)
            {
                TempData["ErrorMessage"] = TargetNutritionDeleteError;

                return this.RedirectToAction(nameof(Delete), new { id = model.Id });
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
