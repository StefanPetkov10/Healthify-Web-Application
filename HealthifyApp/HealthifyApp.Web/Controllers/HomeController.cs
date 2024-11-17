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

        public async Task<IActionResult> Index()
        {
            var userProfile = await _context.UserProfiles
                   .FirstOrDefaultAsync();

            var model = new HomeIndexViewModel
            {
                LastWorkout = userProfile.Workouts
                        .OrderByDescending(w => w.ScheduleDateTime)
                        .FirstOrDefault()?.Name ?? "No workouts yet",
                CurrentWeight = userProfile.ProgressLogs
                        .FirstOrDefault()?.CurrentWeight.ToString("F2") ?? "No actual information about weight",
                GoalWeight = userProfile.Goals
                    .FirstOrDefault()!.GoalWeight.ToString("F2"),
                WaterIntakeStatus = $"{userProfile.WaterIntakes.Where(w => w.Date.Date == DateTime.Today).Sum(w => w.Consumed ?? 0)} / {userProfile.WaterIntakes.FirstOrDefault()?.DailyGoal} liters",
                CalorieStatus = "1500/2000 kcal"
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
