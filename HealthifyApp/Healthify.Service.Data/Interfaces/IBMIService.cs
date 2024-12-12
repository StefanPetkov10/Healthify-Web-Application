using HealthifyApp.Data.Models.Enums;
using HealthifyApp.Web.ViewModels.BMI;

namespace HealthifyApp.Service.Data.Interfaces
{
    public interface IBMIService
    {
        Task<bool> CreateOrUpdateBMIAsync(Guid userId, float bmi, BMICategory category);

        Task<BMICalculationViewModel> GetBMIAsync(float bmi);

        BMICategory DetermineBMICategory(float bmi);

        float CalculateBMI(float weight, float height);
    }
}
