using HealthifyApp.Data.Models;
using HealthifyApp.Web.ViewModels.TargetNutrition;

namespace HealthifyApp.Service.Data.Interfaces
{
    public interface ITargetNutritionService
    {
        Task<IEnumerable<TargetNutritionListViewModel>> IndexGetTargetNutritionAsync(Guid userId);

        Task<CreateTargetNutritionFormModel> CreateTargetNutritionAsync(TargetNutrition calculatedNutrition, Guid goalId);

        Task<bool> CreateTargetNutritionAsync(CreateTargetNutritionFormModel inputModel, Guid userId);

        Task<DeleteTargetNutritionViewModel?> DeleteTargetNutritionAsync(Guid id);

        Task<bool> DeletePermanentlyTargetNutritionAsync(Guid id);
    }
}
