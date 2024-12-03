using HealthifyApp.Web.ViewModels.Goal;

namespace Healthify.Service.Data.Interfaces
{
    public interface IGoalService
    {
        Task<IEnumerable<GoalViewModel?>> IndexGetGoalAsync(Guid userId);

        Task<bool> CreateGoalAsync(CreateGoalFormModel model, Guid userId);

        Task<GoalDetailsViewModel?> GetCinemaDetailsByIdAsync(Guid id);

        Task<DeleteGoalViewModel?> DeleteGoalAsync(Guid id);

        Task<bool> DeletePermanentlyGoalAsync(Guid id);
    }
}
