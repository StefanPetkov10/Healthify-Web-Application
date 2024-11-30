using System.Diagnostics;
using HealthifyApp.Data;
using HealthifyApp.Web.Models;
using HealthifyApp.Web.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HealthifyApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HealthifyDbContext _context;

        public HomeController(ILogger<HomeController> logger, HealthifyDbContext healthifyDbContext)
        {
            _logger = logger;
            _context = healthifyDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            if (User.Identity == null || !User.Identity.IsAuthenticated)
            {
                return View(new HomeIndexViewModel { HasProfile = false });
            }

            var userName = User.Identity.Name;
            // Fetch user profile for the authenticated user
            var userProfile = await _context.UserProfiles
                .Include(up => up.Workouts)
                .Include(up => up.ProgressLogs)
                .Include(up => up.Goals)
                .Include(up => up.WaterIntakes)
                .Include(up => up.NutritionIntake)
                .Include(up => up.TargetNutritional)
                .FirstOrDefaultAsync(up => up.ApplicationUserProfiles
                    .Any(a => a.ApplicationUser.UserName == User.Identity.Name));

            if (userProfile == null)
            {
                return View(new HomeIndexViewModel
                {
                    HasProfile = false,
                    UserName = userName!
                });
            }

            // Populate the view model with data
            var model = new HomeIndexViewModel
            {
                HasProfile = true,
                LastWorkout = userProfile.Workouts?
                    .OrderByDescending(w => w.ScheduleDateTime)
                    .FirstOrDefault()?.Name ?? "No workouts yet",
                CurrentWeight = userProfile.ProgressLogs?
                    .OrderByDescending(pl => pl.Date)
                    .FirstOrDefault()?.CurrentWeight.ToString("F2") ?? "No actual information about weight",
                GoalWeight = userProfile.Goals?
                    .FirstOrDefault()?.GoalWeight.ToString("F2") ?? "No goal weight set",
                WaterIntakeStatus = $"{userProfile.WaterIntakes?
                    .Where(w => w.Date.Date == DateTime.Today)
                    .Sum(w => w.Consumed ?? 0) ?? 0} / {userProfile.WaterIntakes?
                    .FirstOrDefault()?.DailyGoal ?? 0} liters",
                CalorieStatus = $"{userProfile.NutritionIntake?
                    .Where(n => n.Date.Date == DateTime.Today)
                    .Sum(c => c.Calories) ?? 0} / {userProfile.TargetNutritional?
                    .FirstOrDefault()?.TargetCalories ?? 0} kca"
            };

            return View(model);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
