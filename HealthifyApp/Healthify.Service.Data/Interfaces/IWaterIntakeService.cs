using HealthifyApp.Data.Models.Enums;
using HealthifyApp.Web.ViewModels.WaterIntake;

namespace HealthifyApp.Service.Data.Interfaces
{
    public interface IWaterIntakeService
    {
        Task<bool> CreateOrUpdateWaterIntakeAsync(Guid userId, float dailyGoal);

        Task<WaterIntakeViewModel> GetWaterIntakeAsync(float dailyGoal);

        float CalculateWaterIntake(float weightInKg, Activity activityLevel);
    }
}
