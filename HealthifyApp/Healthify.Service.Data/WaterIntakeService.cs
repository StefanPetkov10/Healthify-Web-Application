using HealthifyApp.Data.Models;
using HealthifyApp.Data.Models.Enums;
using HealthifyApp.Data.Repository.Interfaces;
using HealthifyApp.Service.Data.Interfaces;
using HealthifyApp.Services.Data;
using HealthifyApp.Web.ViewModels.WaterIntake;

namespace HealthifyApp.Service.Data
{
    public class WaterIntakeService : BaseService, IWaterIntakeService
    {
        private readonly IRepository<WaterIntake, Guid> waterIntakeRepository;

        public WaterIntakeService(IRepository<WaterIntake, Guid> waterIntakeRepository,
                                     IRepository<UserProfile, Guid> userProfileRepository)
            : base(userProfileRepository)
        {
            this.waterIntakeRepository = waterIntakeRepository;
        }

        public async Task<bool> CreateOrUpdateWaterIntakeAsync(Guid userId, float dailyGoal)
        {
            UserProfile userProfile = await GetUserProfileAsync(userId);

            if (userProfile == null || userProfile.IsActiveProfile == false)
            {
                return false;
            }

            WaterIntake waterIntake = await waterIntakeRepository
                .FirstOrDefaultAsync(x => x.UserProfileId == userProfile.Id);

            if (waterIntake == null)
            {
                waterIntake = new WaterIntake
                {
                    UserProfileId = userProfile.Id,
                    DailyGoal = dailyGoal
                };
                await waterIntakeRepository.AddAsync(waterIntake);
            }
            else
            {
                waterIntake.DailyGoal = dailyGoal;
                await waterIntakeRepository.UpdateAsync(waterIntake);
            }

            return true;
        }
        public async Task<WaterIntakeViewModel> GetWaterIntakeAsync(float dailyGoal)
        {
            return new WaterIntakeViewModel
            {
                RecommendedWaterIntake = Math.Round(dailyGoal, 2),
                Message = "Your daily water intake goal has been updated successfully!"
            };
        }

        public float CalculateWaterIntake(float weightInKg, Activity activityLevel)
        {
            float baseWaterIntake = weightInKg * 30;

            switch (activityLevel)
            {
                case Activity.Sedentary:
                    baseWaterIntake += 200; break;
                case Activity.LightlyActive:
                    baseWaterIntake += 400; break;
                case Activity.ModeratelyActive:
                    baseWaterIntake += 600; break;
                case Activity.VeryActive:
                    baseWaterIntake += 800; break;
                case Activity.ExtraActive:
                    baseWaterIntake += 1000; break;
            }

            return (float)Math.Round(baseWaterIntake / 1000, 2);
        }

    }
}
