using HealthifyApp.Services.Mapping;

namespace HealthifyApp.Web.ViewModels.Workout
{
    using HealthifyApp.Data.Models;
    public class DeleteWorkoutViewModel : IMapFrom<Workout>
    {
        public string Id { get; set; } = null!;
        public string WorkoutName { get; set; } = null!;
    }
}
