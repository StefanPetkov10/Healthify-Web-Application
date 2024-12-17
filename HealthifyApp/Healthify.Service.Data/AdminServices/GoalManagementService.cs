using HealthifyApp.Data.Models;
using HealthifyApp.Data.Repository.Interfaces;
using HealthifyApp.Service.Data.Interfaces.AdminInterfaces;
using HealthifyApp.Services.Data;
using HealthifyApp.Services.Mapping;
using HealthifyApp.Web.ViewModels.Admin.Goal;
using Microsoft.EntityFrameworkCore;

namespace HealthifyApp.Service.Data.AdminServices
{
    public class GoalManagementService : BaseService, IGoalManagementService
    {
        private readonly IRepository<Goal, Guid> goalRepository;
        private readonly IRepository<TargetNutrition, Guid> targetNutritionRepository;
        private readonly IRepository<UserProfile, Guid> userProfileRepository;

        public GoalManagementService(IRepository<Goal, Guid> goalRepository,
                                    IRepository<UserProfile, Guid> userProfileRepository,
                                    IRepository<TargetNutrition, Guid> targetNutritionRepository)
            : base(userProfileRepository)
        {
            this.goalRepository = goalRepository;
            this.userProfileRepository = userProfileRepository;
            this.targetNutritionRepository = targetNutritionRepository;
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

        public async Task<AdminDeleteGoalViewModel?> AdminDeleteGoalAsync(Guid id)
        {
            AdminDeleteGoalViewModel? goalToDelete = await goalRepository
                .GetAllAttached()
                .To<AdminDeleteGoalViewModel>()
                .FirstOrDefaultAsync(g => g.Id.ToLower() == id.ToString().ToLower());

            return goalToDelete;
        }

        public async Task<bool> AdminDeletePermanentlyGoalAsync(Guid id)
        {
            Goal goal = await goalRepository.GetByIdAsync(id);
            TargetNutrition targetNutrition = await targetNutritionRepository
                .FirstOrDefaultAsync(x => x.GoalId == goal.Id);

            if (goal != null)
            {
                goalRepository.Delete(goal);
            }
            else
            {
                return false;
            }

            if (targetNutrition != null)
            {
                targetNutritionRepository.Delete(targetNutrition);
            }

            return true;
        }

    }
}
