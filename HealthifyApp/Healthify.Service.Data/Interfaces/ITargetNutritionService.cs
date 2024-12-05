using HealthifyApp.Data.Models;
using HealthifyApp.Web.ViewModels.TargetNutrition;

namespace HealthifyApp.Service.Data.Interfaces
{
    public interface ITargetNutritionService
    {
        Task<CreateTargetNutritionFormModel> CreateTargetNutritionAsync(TargetNutrition calculatedNutrition, Guid goalId);

        Task<bool> CreateTargetNutritionAsync(CreateTargetNutritionFormModel model, Guid userId);

        Task<IEnumerable<TargetNutritionListViewModel>> IndexGetTargetNutritionAsync(Guid userId);

        Task<DeleteTargetNutritionViewModel?> DeleteTargetNutritionAsync(Guid id);

        Task<bool> DeletePermanentlyTargetNutritionAsync(Guid id);
    }
}
