using HealthifyApp.Data.Models;
using HealthifyApp.Web.ViewModels.TargetNutrition;

namespace Healthify.Service.Data.Interfaces
{
    public interface ITargetNutritionService
    {
        Task<CreateTargetNutritionFormModel> CreateTargetNutritionAsync(TargetNutrition calculatedNutrition, Guid goalId);
        Task<bool> CreateTargetNutritionAsync(CreateTargetNutritionFormModel model, Guid userId);
        //Task<IEnumerable<TargetNutritionListViewModel>> GetAllTargetsByUserAsync(Guid userId);
        //Task<TargetNutritionDetailsViewModel?> GetTargetNutritionDetailsAsync(Guid id);
    }
}
