using HealthifyApp.Web.ViewModels.Admin.TargetNutrition;

namespace HealthifyApp.Service.Data.Interfaces.AdminInterfaces
{
    public interface ITargetNutritionManagementService
    {
        public Task<IEnumerable<UserTargetNutritionViewModel>> GetAllTargetNutritionAsync();
    }
}
