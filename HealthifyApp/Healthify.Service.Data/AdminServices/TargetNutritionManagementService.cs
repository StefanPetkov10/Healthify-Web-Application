using HealthifyApp.Data.Models;
using HealthifyApp.Data.Repository.Interfaces;
using HealthifyApp.Service.Data.Interfaces.AdminInterfaces;
using HealthifyApp.Services.Data;
using HealthifyApp.Services.Mapping;
using HealthifyApp.Web.ViewModels.Admin.TargetNutrition;
using Microsoft.EntityFrameworkCore;

using static HealthifyApp.Common.EntityValidationConstants.TargetNutrition;
namespace HealthifyApp.Service.Data.AdminServices
{
    public class TargetNutritionManagementService : BaseService, ITargetNutritionManagementService
    {
        private readonly IRepository<UserProfile, Guid> userProfileRepository;
        private readonly IRepository<TargetNutrition, Guid> targetNutritionRepository;

        public TargetNutritionManagementService(IRepository<UserProfile, Guid> userProfileRepository,
                                                   IRepository<TargetNutrition, Guid> targetNutritionRepository)
            : base(userProfileRepository)
        {
            this.userProfileRepository = userProfileRepository;
            this.targetNutritionRepository = targetNutritionRepository;
        }
        public async Task<IEnumerable<UserTargetNutritionViewModel>> GetAllTargetNutritionAsync()
        {
            var userProfiles = await userProfileRepository
                .GetAllAttached()
                .Where(x => x.IsActiveProfile == true)
                .Include(x => x.TargetNutritional)  // Eager load Goals to avoid N+1 query problem
                .ToListAsync();

            if (!userProfiles.Any())
            {
                return Enumerable.Empty<UserTargetNutritionViewModel>();
            }

            return userProfiles
                .Where(up => up.TargetNutritional.Any()) // Filter out profiles with no goals
                .Select(userProfile => new UserTargetNutritionViewModel
                {
                    FirstName = userProfile.FirstName,
                    LastName = userProfile.LastName,
                    TargetNutrition = userProfile.TargetNutritional.Select(g => new TargetNutritionViewModel
                    {
                        Id = g.Id.ToString(),
                        GoalName = g.GoalName.ToString(),
                        StartDate = g.StartDate.ToString(StartDateTimeFormat) // Format date for consistency
                    }).ToList()
                })
                .ToList();
        }

        public async Task<AdminDeleteTargetNutritionViewModel?> AdminDeleteTargetNutritionAsync(Guid id)
        {
            AdminDeleteTargetNutritionViewModel? targetNutritionDelete = await targetNutritionRepository
                .GetAllAttached()
                .To<AdminDeleteTargetNutritionViewModel>()
                .FirstOrDefaultAsync(tn => tn.Id.ToLower() == id.ToString().ToLower());

            return targetNutritionDelete;
        }

        public async Task<bool> AdminDeletePermanentlyTargetNutritionAsync(Guid id)
        {
            TargetNutrition targetNutrition = await targetNutritionRepository
                .GetByIdAsync(id);

            if (targetNutrition != null)
            {
                targetNutritionRepository.Delete(targetNutrition);
            }

            return true;
        }
    }
}
