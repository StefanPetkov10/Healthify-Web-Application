using HealthifyApp.Data.Models;
using HealthifyApp.Data.Repository.Interfaces;
using HealthifyApp.Service.Data.Interfaces;
using HealthifyApp.Services.Data;
using HealthifyApp.Services.Mapping;
using HealthifyApp.Web.ViewModels.ProgressLog;
using Microsoft.EntityFrameworkCore;

namespace HealthifyApp.Service.Data
{
    public class ProgressLogService : BaseService, IProgressLogService
    {
        private readonly IRepository<ProgressLog, Guid> progressLogRepository;
        private readonly IRepository<UserProfile, Guid> userProfileRepository;
        private readonly IRepository<Goal, Guid> goalRepository;

        public ProgressLogService(IRepository<ProgressLog, Guid> progressLogRepository,
                                    IRepository<UserProfile, Guid> userProfileRepository,
                                        IRepository<Goal, Guid> goalRepository)
            : base(userProfileRepository)
        {
            this.progressLogRepository = progressLogRepository;
            this.goalRepository = goalRepository;
        }


        public async Task<IndexProgressLogViewModel> IndexGetProgressLogAsync(Guid userId)
        {
            UserProfile userProfile = await GetUserProfileAsync(userId);

            if (userProfile == null || userProfile.IsActiveProfile == false)
            {
                return null;
            }

            Goal? goal = await this.goalRepository
                .GetAllAttached()
                .Include(g => g.UserProfile.ProgressLogs)
                .Where(g => g.UserProfileId == userProfile.Id)
                .FirstOrDefaultAsync();

            ProgressLogListViewModel[] progressLogs = await this.progressLogRepository
                .GetAllAttached()
                .Where(i => i.UserProfileId == userProfile.Id)  // Filtering by valid userProfile ID
                .To<ProgressLogListViewModel>()  // Ensure that To<ProgressLogViewModel> is correctly mapping entities
                .ToArrayAsync();

            IndexProgressLogViewModel viewModel = new IndexProgressLogViewModel()
            {
                GoalWeight = goal.GoalWeight,
                ProgressLogs = progressLogs
            };

            return viewModel;
        }
        public async Task<bool> AddProgressLogAsync(AddProgressLogFormModel inputModel, Guid userId)
        {
            UserProfile userProfile = await GetUserProfileAsync(userId);

            if (userProfile == null || !userProfile.IsActiveProfile)
            {
                return false;
            }

            ProgressLog progressLog = new ProgressLog();
            AutoMapperConfig.MapperInstance.Map(inputModel, progressLog);
            progressLog.UserProfileId = userProfile.Id;

            await progressLogRepository.AddAsync(progressLog);

            return true;
        }
    }
}
