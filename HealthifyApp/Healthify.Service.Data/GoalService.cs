using Healthify.Service.Data.Interfaces;
using HealthifyApp.Data.Models;
using HealthifyApp.Data.Repository.Interfaces;
using HealthifyApp.Services.Mapping;
using HealthifyApp.Web.ViewModels.Goal;
using Microsoft.EntityFrameworkCore;

namespace Healthify.Service.Data
{
    public class GoalService : IGoalService
    {
        private readonly IRepository<Goal, Guid> goalRepository;
        private readonly IRepository<UserProfile, Guid> userProfileRepository;

        public GoalService(IRepository<Goal, Guid> goalRepository, IRepository<UserProfile, Guid> userProfileRepository)
        {
            this.goalRepository = goalRepository;
            this.userProfileRepository = userProfileRepository;
        }

        public async Task<IEnumerable<GoalViewModel?>> GetGoalAsync(Guid userId)
        {
            var userProfile = await userProfileRepository
                .FirstOrDefaultAsync(up =>
                    up.IsActiveProfile == true &&
                    up.ApplicationUserProfiles.Any(a => a.ApplicationUserId == userId));

            // Fetch goals filtered by the user profile ID
            return await this.goalRepository
                .GetAllAttached()
                .Where(i => i.UserProfileId == userProfile.Id)  // Filtering by valid userProfile ID
                .To<GoalViewModel>()  // Ensure that To<GoalViewModel> is correctly mapping entities
                .ToArrayAsync();
        }

        public async Task CreateGoalAsync(CreateGoalFormModel model)
        {

        }

    }
}
