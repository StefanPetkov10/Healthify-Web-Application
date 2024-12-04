using System.Globalization;
using HealthifyApp.Data.Models;
using HealthifyApp.Data.Models.Enums;
using HealthifyApp.Data.Repository.Interfaces;
using HealthifyApp.Service.Data.Interfaces;
using HealthifyApp.Services.Data;
using HealthifyApp.Services.Mapping;
using HealthifyApp.Web.ViewModels.Goal;
using Microsoft.EntityFrameworkCore;

using static HealthifyApp.Common.EntityValidationConstants.Goal;

namespace Healthify.Service.Data
{
    public class GoalService : BaseService, IGoalService
    {
        private readonly IRepository<Goal, Guid> goalRepository;
        private readonly IRepository<TargetNutrition, Guid> targetNutritionRepository;
        private readonly IRepository<UserProfile, Guid> userProfileRepository;

        public GoalService(IRepository<Goal, Guid> goalRepository,
                             IRepository<TargetNutrition, Guid> targetNutritionRepository,
                               IRepository<UserProfile, Guid> userProfileRepository)
            : base(userProfileRepository)
        {
            this.goalRepository = goalRepository;
            this.targetNutritionRepository = targetNutritionRepository;
            this.userProfileRepository = userProfileRepository;
        }

        public async Task<IEnumerable<GoalListViewModel?>> IndexGetGoalAsync(Guid userId)
        {
            UserProfile userProfile = await GetUserProfileAsync(userId);

            // Fetch goals filtered by the user profile ID
            return await this.goalRepository
                .GetAllAttached()
                .Where(i => i.UserProfileId == userProfile.Id)  // Filtering by valid userProfile ID
                .To<GoalListViewModel>()  // Ensure that To<GoalViewModel> is correctly mapping entities
                .ToArrayAsync();
        }

        public async Task<bool> CreateGoalAsync(CreateGoalFormModel formModel, Guid userId)
        {
            bool isStartDate = DateTime.TryParseExact(formModel.StartDate, StartDateTimeFormat,
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime releaseDate);
            if (!isStartDate)
            {
                return false;
            }

            Goal goal = new Goal();
            UserProfile userProfile = await GetUserProfileAsync(userId);
            AutoMapperConfig.MapperInstance.Map(formModel, goal);
            goal.UserProfileId = userProfile.Id;
            goal.StartDate = releaseDate;
            goal.GoalType = Enum.Parse<Goals>(formModel.GoalType);
            goal.Activity = Enum.Parse<Activity>(formModel.Activity);

            await this.goalRepository.AddAsync(goal);

            return true;
        }
        public async Task<GoalDetailsViewModel?> GetCinemaDetailsByIdAsync(Guid id)
        {
            Goal goal = await goalRepository
                .GetByIdAsync(id);

            GoalDetailsViewModel viewModel = new GoalDetailsViewModel();
            if (goal != null)
            {
                AutoMapperConfig.MapperInstance.Map(goal, viewModel);
            }

            return viewModel;
        }

        public async Task<DeleteGoalViewModel?> DeleteGoalAsync(Guid id)
        {
            DeleteGoalViewModel? goalToDelete = await goalRepository
                .GetAllAttached()
                .To<DeleteGoalViewModel>()
                .FirstOrDefaultAsync(g => g.Id.ToLower() == id.ToString().ToLower());

            return goalToDelete;
        }

        public async Task<bool> DeletePermanentlyGoalAsync(Guid id)
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

        public async Task<Goal> GetGoalByIdAsync(Guid id)
        {
            return await goalRepository.GetByIdAsync(id);
        }
    }
}
