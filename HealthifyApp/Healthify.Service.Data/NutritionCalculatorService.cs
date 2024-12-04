using HealthifyApp.Data.Models;
using HealthifyApp.Data.Models.Enums;
using HealthifyApp.Service.Data.Interfaces;

namespace Healthify.Service.Data
{
    public class NutritionCalculatorService : INutritionCalculatorService
    {
        public TargetNutrition CalculateTargetNutrition(Goal goal)
        {
            int baseCalories = 2000;

            var activityMultipliers = new Dictionary<Activity, float>
            {
                { Activity.Sedentary, 1.2f },
                { Activity.LightlyActive, 1.375f },
                { Activity.ModeratelyActive, 1.55f },
                { Activity.VeryActive, 1.725f },
                { Activity.ExtraActive, 1.9f }
            };

            var caloriesMultiplier = activityMultipliers[goal.Activity];
            int calories = (int)(baseCalories * caloriesMultiplier);

            switch (goal.GoalType)
            {
                case Goals.LoseWeight:
                    calories -= 500;
                    break;
                case Goals.GainWeight:
                    calories += 500;
                    break;
                case Goals.MaintainWeight:
                    break;
            }
            return new TargetNutrition
            {
                UserProfileId = goal.UserProfileId,
                GoalId = goal.Id,
                GoalName = goal.GoalType.ToString(),
                StartDate = goal.StartDate,
                TargetCalories = calories,
                TargetProtein = (int)(calories * 0.2 / 4),
                TargetFats = (int)(calories * 0.3 / 9),
                TargetCarbohydrates = (int)(calories * 0.5 / 4)
            };
        }
    }
}
