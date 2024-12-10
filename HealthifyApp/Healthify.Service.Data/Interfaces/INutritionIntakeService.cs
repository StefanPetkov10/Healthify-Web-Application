using HealthifyApp.Web.ViewModels.NutritionIntake;

namespace HealthifyApp.Service.Data.Interfaces
{
    public interface INutritionIntakeService
    {
        Task<NutritionIntakeIndexViewModel> GetNutritionIntakeIndexAsync(Guid userId);

        Task<AddTodayNutritionIntakeFormModel> AddNutritionIntakeAsync();

        Task<bool> AddNutritionIntakeAsync(AddTodayNutritionIntakeFormModel inpuyModel, Guid userId);
    }
}
