using HealthifyApp.Web.ViewModels.Workout;

namespace HealthifyApp.Service.Data.Interfaces
{
    public interface IWorkoutService
    {
        Task<IEnumerable<WorkoutViewModel?>> IndexGetWorkoutAsync(Guid userId);

        Task<bool> CreateWorkoutAsync(CreateWorkoutFormModel model, Guid userId);

        Task<UpdateWorkoutFormModel?> GetUpdateWorkoutFormModelAsync(Guid workoutId);

        Task<bool> UpdateWorkoutAsync(UpdateWorkoutFormModel model, Guid userId);
    }
}
