using HealthifyApp.Data.Models;

namespace HealthifyApp.Service.Data.Interfaces
{
    public interface INutritionCalculatorService
    {
        TargetNutrition CalculateTargetNutrition(Goal goal);
    }
}
