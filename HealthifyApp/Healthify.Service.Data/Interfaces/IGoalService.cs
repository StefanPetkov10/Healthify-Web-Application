using HealthifyApp.Web.ViewModels.Goal;

namespace Healthify.Service.Data.Interfaces
{
    public interface IGoalService
    {
        Task<IEnumerable<GoalViewModel?>> GetGoalAsync(Guid userId);

        Task CreateGoalAsync(CreateGoalFormModel model);
    }
}
