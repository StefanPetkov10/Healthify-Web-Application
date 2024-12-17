using HealthifyApp.Services.Mapping;

namespace HealthifyApp.Web.ViewModels.Admin.Goal
{
    using HealthifyApp.Data.Models;
    public class AdminDeleteGoalViewModel : IMapFrom<Goal>
    {
        public string Id { get; set; } = null!;

        public string GoalType { get; set; } = null!;
    }
}
