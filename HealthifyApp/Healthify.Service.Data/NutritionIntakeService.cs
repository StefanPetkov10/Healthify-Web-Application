using HealthifyApp.Data.Models;
using HealthifyApp.Data.Repository.Interfaces;
using HealthifyApp.Service.Data.Interfaces;
using HealthifyApp.Services.Data;
using HealthifyApp.Services.Mapping;
using HealthifyApp.Web.ViewModels.NutritionIntake;
using Microsoft.EntityFrameworkCore;

using static HealthifyApp.Common.EntityValidationConstants.NutritionIntake;

namespace HealthifyApp.Service.Data
{
    public class NutritionIntakeService : BaseService, INutritionIntakeService
    {
        private readonly IRepository<NutritionIntake, Guid> nutritionIntakeRepository;
        private readonly IRepository<TargetNutrition, Guid> targetNutritionRepository;

        public NutritionIntakeService(IRepository<NutritionIntake, Guid> nutritionIntakeRepository,
                                        IRepository<TargetNutrition, Guid> targetNutritionRepository,
                                           IRepository<UserProfile, Guid> userProfileRepository)
            : base(userProfileRepository)
        {
            this.nutritionIntakeRepository = nutritionIntakeRepository;
            this.targetNutritionRepository = targetNutritionRepository;
        }


        public async Task<NutritionIntakeIndexViewModel> GetNutritionIntakeIndexAsync(Guid userId)
        {
            UserProfile userProfile = await GetUserProfileAsync(userId);

            if (userProfile == null || userProfile.IsActiveProfile == false)
            {
                return null;
            }

            TargetNutrition? targetNutrition = await this.targetNutritionRepository
                .GetAllAttached()
                .Where(g => g.UserProfileId == userProfile.Id)
                .FirstOrDefaultAsync();

            var intake = await nutritionIntakeRepository
                .GetAllAttached()
                .Where(ni => ni.UserProfileId == userProfile.Id && ni.Date.Date == DateTime.UtcNow.Date)
                .FirstOrDefaultAsync();

            if (targetNutrition == null)
            {
                return null;
            }

            NutritionIntakeIndexViewModel viewModel = new NutritionIntakeIndexViewModel()
            {
                TargetCalories = targetNutrition.TargetCalories,
                TargetProtein = targetNutrition.TargetProtein,
                TargetCarbohydrates = targetNutrition.TargetCarbohydrates,
                TargetFats = targetNutrition.TargetFats,

                CurrentCalories = intake?.Calories ?? 0,
                CurrentProtein = intake?.Protein ?? 0,
                CurrentCarbohydrates = intake?.Carbohydrates ?? 0,
                CurrentFats = intake?.Fats ?? 0
            };

            return viewModel;
        }
        public async Task<AddTodayNutritionIntakeFormModel?> AddNutritionIntakeAsync()
        {
            var nutritionIntake = await nutritionIntakeRepository.GetAllAsync();

            string date = nutritionIntake
                .Select(ni => ni.Date)
                .FirstOrDefault()
                .ToString(DateInAddingProgress);

            if (date == DateTime.Now.ToString(DateInAddingProgress))
            {
                return null;
            }

            return new AddTodayNutritionIntakeFormModel
            {
                Date = DateTime.UtcNow.Date.ToString(DateInAddingProgress)
            };
        }

        public async Task<bool> AddNutritionIntakeAsync(AddTodayNutritionIntakeFormModel inputModel, Guid userId)
        {
            UserProfile userProfile = await GetUserProfileAsync(userId);

            if (userProfile == null || !userProfile.IsActiveProfile)
            {
                return false;
            }

            NutritionIntake nutritionIntake = new NutritionIntake();
            AutoMapperConfig.MapperInstance.Map(inputModel, nutritionIntake);
            nutritionIntake.UserProfileId = userProfile.Id;

            await nutritionIntakeRepository.AddAsync(nutritionIntake);

            return true;
        }
    }
}
