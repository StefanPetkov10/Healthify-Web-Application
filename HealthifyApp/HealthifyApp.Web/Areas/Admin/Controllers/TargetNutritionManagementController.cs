using HealthifyApp.Service.Data.Interfaces.AdminInterfaces;
using HealthifyApp.Services.Data.Interfaces;
using HealthifyApp.Web.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
    }
}
