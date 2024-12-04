using HealthifyApp.Data;
using HealthifyApp.Service.Data.Interfaces;
using HealthifyApp.Web.ViewModels.Home;
using Microsoft.EntityFrameworkCore;

namespace Healthify.Service.Data
{
    public class HomeService : IHomeService
    {
        private readonly HealthifyDbContext dbContext;

        public HomeService(HealthifyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<HomeIndexViewModel> GetHomeIndexViewModelAsync(string userName)
        {
            var userProfile = await dbContext.UserProfiles
            .Include(up => up.Workouts)
            .Include(up => up.ProgressLogs)
            .Include(up => up.Goals)
            .Include(up => up.WaterIntakes)
            .Include(up => up.NutritionIntake)
            .Include(up => up.TargetNutritional)
            .Where(up => up.IsActiveProfile)
            .FirstOrDefaultAsync(up => up.ApplicationUserProfiles
                .Any(a => a.ApplicationUser.UserName == userName));

            if (userProfile == null)
            {
                return new HomeIndexViewModel
                {
                    HasProfile = false,
                    UserName = userName
                };
            }

            // Manually mapping UserProfile to HomeIndexViewModel
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

            return model;
        }
    }
}
