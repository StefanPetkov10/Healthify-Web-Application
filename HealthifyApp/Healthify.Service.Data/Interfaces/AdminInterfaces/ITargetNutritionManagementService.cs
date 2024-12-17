using HealthifyApp.Web.ViewModels.Admin.TargetNutrition;

namespace HealthifyApp.Service.Data.Interfaces.AdminInterfaces
{
    public interface ITargetNutritionManagementService
    {
        public Task<IEnumerable<UserTargetNutritionViewModel>> GetAllTargetNutritionAsync();

        Task<AdminDeleteTargetNutritionViewModel?> AdminDeleteTargetNutritionAsync(Guid id);

        Task<bool> AdminDeletePermanentlyTargetNutritionAsync(Guid id);
    }
}
