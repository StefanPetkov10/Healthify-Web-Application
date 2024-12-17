using HealthifyApp.Service.Data.Interfaces.AdminInterfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HealthifyApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class GoalManagementController : Controller
    {
        private readonly IGoalManagementService goalManagementService;

        public GoalManagementController(IGoalManagementService goalManagementService)
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
    }
}
