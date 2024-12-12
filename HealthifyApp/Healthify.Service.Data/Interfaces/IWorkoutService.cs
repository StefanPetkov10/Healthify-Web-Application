using HealthifyApp.Web.ViewModels.Workout;

namespace HealthifyApp.Service.Data.Interfaces
{
    public interface IWorkoutService
    {
        Task<IEnumerable<WorkoutViewModel?>> IndexGetWorkoutAsync(Guid userId);

        Task<bool> CreateWorkoutAsync(CreateWorkoutFormModel model, Guid userId);
    }
}
