using HealthifyApp.Services.Mapping;

namespace HealthifyApp.Web.ViewModels.TargetNutrition
{
    using HealthifyApp.Data.Models;
    public class DeleteTargetNutritionViewModel : IMapFrom<TargetNutrition>
    {
        public string Id { get; set; } = null!;

        public string GoalName { get; set; } = null!;
    }
}
