using Healthify.Service.Data.Interfaces;
using HealthifyApp.Data.Models;
using HealthifyApp.Services.Data.Interfaces;
using HealthifyApp.Web.Infrastructure.Extensions;
using HealthifyApp.Web.ViewModels.TargetNutrition;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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

            if (calculatedNutrition == null)
            {
                return RedirectToAction("Index", "Goal");
            }

            var viewModel = await this.targetNutritionService.CreateTargetNutritionAsync(calculatedNutrition, goalGuid);

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

            return RedirectToAction("Index");
        }

    }
}
