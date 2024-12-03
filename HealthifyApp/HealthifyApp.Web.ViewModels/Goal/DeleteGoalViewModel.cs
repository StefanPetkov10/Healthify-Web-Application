using HealthifyApp.Services.Mapping;

namespace HealthifyApp.Web.ViewModels.Goal
{
    using HealthifyApp.Data.Models;
    public class DeleteGoalViewModel : IMapFrom<Goal>
    {
        public string Id { get; set; } = null!;

        public string GoalType { get; set; } = null!;
    }
}
