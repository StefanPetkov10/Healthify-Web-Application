using HealthifyApp.Data.Models;

namespace Healthify.Service.Data.Interfaces
{
    public interface INutritionCalculatorService
    {
        TargetNutrition CalculateTargetNutrition(Goal goal);
    }
}
