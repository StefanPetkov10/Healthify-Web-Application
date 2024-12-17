using HealthifyApp.Service.Data.Interfaces.AdminInterfaces;
using HealthifyApp.Services.Data.Interfaces;
using HealthifyApp.Web.Controllers;
using HealthifyApp.Web.ViewModels.Admin.Goal;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using static HealthifyApp.Common.ErrorMessages.Goal;

namespace HealthifyApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class GoalManagementController : BaseController
    {
        private readonly IGoalManagementService goalManagementService;

        public GoalManagementController(IGoalManagementService goalManagementService,
                                            IBaseService baseService)
            : base(baseService)
        {
            this.goalManagementService = goalManagementService;
        }

        public async Task<IActionResult> Index()
        {
            var usersWithGoals = await goalManagementService.GetAllGoalsAsync();

            if (usersWithGoals == null || !usersWithGoals.Any())
            {
                return NotFound();
            }

            return View(usersWithGoals);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(string? id)
        {
            if (!this.IsGuidValid(id, out Guid goalId))
            {
                return RedirectToAction(nameof(Index));
            }

            var viewModel = await this.goalManagementService.AdminDeleteGoalAsync(goalId);

            if (viewModel == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(AdminDeleteGoalViewModel model)
        {
            bool result = await this.goalManagementService.AdminDeletePermanentlyGoalAsync(new Guid(model.Id));
            if (!result)
            {
                TempData["ErrorMessage"] = GoalDeleteError;

                return this.RedirectToAction(nameof(Delete), new { id = model.Id });
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
