using HealthifyApp.Service.Data.Interfaces.AdminInterfaces;
using HealthifyApp.Services.Data.Interfaces;
using HealthifyApp.Web.Controllers;
using HealthifyApp.Web.ViewModels.Goal;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using static HealthifyApp.Common.ErrorMessages.TargetNutrition;

namespace HealthifyApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class TargetNutritionManagementController : BaseController
    {
        private readonly ITargetNutritionManagementService targetNutritionManagementService;

        public TargetNutritionManagementController(ITargetNutritionManagementService targetNutritionManagementService, IBaseService baseService)
            : base(baseService)
        {
            this.targetNutritionManagementService = targetNutritionManagementService;
        }

        public async Task<IActionResult> Index()
        {
            var usersWithGoals = await targetNutritionManagementService.GetAllTargetNutritionAsync();

            if (usersWithGoals == null || !usersWithGoals.Any())
            {
                return NotFound();
            }

            return View(usersWithGoals);
        }

        [HttpGet]
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

            var viewModel = await this.targetNutritionManagementService.AdminDeleteTargetNutritionAsync(targetNutritionId);

            if (viewModel == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(DeleteGoalViewModel model)
        {
            bool result = await this.targetNutritionManagementService.AdminDeletePermanentlyTargetNutritionAsync(new Guid(model.Id));
            if (!result)
            {
                TempData["ErrorMessage"] = TargetNutritionDeleteError;

                return this.RedirectToAction(nameof(Delete), new { id = model.Id });
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
