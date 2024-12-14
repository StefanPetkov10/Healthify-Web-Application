using HealthifyApp.Service.Data.Interfaces;
using HealthifyApp.Services.Data.Interfaces;
using HealthifyApp.Web.Infrastructure.Extensions;
using HealthifyApp.Web.ViewModels.Goal;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using static HealthifyApp.Common.ErrorMessages.Goal;

namespace HealthifyApp.Web.Controllers
{
    [Authorize]
    public class GoalController : BaseController
    {
        private readonly IGoalService goalService;
        private readonly INutritionCalculatorService nutritionCalculatorService;

        public GoalController(IGoalService goalService, IBaseService baseService, INutritionCalculatorService nutritionCalculatorService)
            : base(baseService)
        {
            this.goalService = goalService;
            this.nutritionCalculatorService = nutritionCalculatorService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var userId = User.GetUserId();

            var viewModel = await this.goalService.IndexGetGoalAsync(new Guid(userId!));

            if (viewModel == null)
            {
                return RedirectToAction(nameof(Create));
            }

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View(new CreateGoalFormModel());
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateGoalFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var userId = User.GetUserId();

            bool result = await this.goalService.CreateGoalAsync(model, new Guid(userId!));

            if (!result)
            {
                return RedirectToAction(nameof(Create));
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Details(string? id)
        {
            if (!this.IsGuidValid(id, out Guid goalId))
            {
                return RedirectToAction(nameof(Index));
            }

            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }

            var viewModel = await this.goalService.GetCinemaDetailsByIdAsync(goalId);

            if (viewModel == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(string? id)
        {
            if (!this.IsGuidValid(id, out Guid goalId))
            {
                return RedirectToAction(nameof(Index));
            }

            var viewModel = await this.goalService.DeleteGoalAsync(goalId);

            if (viewModel == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(DeleteGoalViewModel model)
        {
            bool result = await this.goalService.DeletePermanentlyGoalAsync(new Guid(model.Id));
            if (!result)
            {
                TempData["ErrorMessage"] = GoalDeleteError;

                return this.RedirectToAction(nameof(Delete), new { id = model.Id });
            }
            return RedirectToAction(nameof(Index));
        }


    }
}
