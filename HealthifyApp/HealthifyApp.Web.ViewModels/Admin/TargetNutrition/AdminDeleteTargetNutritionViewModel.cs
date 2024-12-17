using HealthifyApp.Services.Mapping;

namespace HealthifyApp.Web.ViewModels.Admin.TargetNutrition
{
    using HealthifyApp.Data.Models;

    public class AdminDeleteTargetNutritionViewModel : IMapFrom<TargetNutrition>
    {
        public string Id { get; set; } = null!;

        public string GoalName { get; set; } = null!;
    }
}
