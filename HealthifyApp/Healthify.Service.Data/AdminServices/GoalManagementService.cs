using HealthifyApp.Data.Models;
using HealthifyApp.Data.Repository.Interfaces;
using HealthifyApp.Service.Data.Interfaces.AdminInterfaces;
using HealthifyApp.Services.Data;
using HealthifyApp.Web.ViewModels.Admin.Goal;
using Microsoft.EntityFrameworkCore;

namespace HealthifyApp.Service.Data.AdminServices
{
    public class GoalManagementService : BaseService, IGoalManagementService
    {
        private readonly IRepository<Goal, Guid> goalRepository;
        private readonly IRepository<UserProfile, Guid> userProfileRepository;

        public GoalManagementService(IRepository<Goal, Guid> goalRepository,
                                    IRepository<UserProfile, Guid> userProfileRepository)
            : base(userProfileRepository)
        {
            this.goalRepository = goalRepository;
            this.userProfileRepository = userProfileRepository;
        }

        public async Task<IEnumerable<UserGoalsViewModel>> GetAllGoalsAsync()
        {
            var userProfiles = await userProfileRepository
                .GetAllAttached()
                .Where(x => x.IsActiveProfile == true)
                .Include(x => x.Goals)  // Eager load Goals to avoid N+1 query problem
                .ToListAsync();

            if (!userProfiles.Any())
            {
                return Enumerable.Empty<UserGoalsViewModel>();
            }

            return userProfiles
                .Where(up => up.Goals.Any()) // Filter out profiles with no goals
                .Select(userProfile => new UserGoalsViewModel
                {
                    FirstName = userProfile.FirstName,
                    LastName = userProfile.LastName,
                    Goals = userProfile.Goals.Select(g => new GoalViewModel
                    {
                        GoalId = g.Id.ToString(),
                        GoalType = g.GoalType.ToString(),
                        StartDate = g.StartDate.ToString("yyyy-MM-dd") // Format date for consistency
                    }).ToList()
                })
                .ToList();
        }
    }
}
