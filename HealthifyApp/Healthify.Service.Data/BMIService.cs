using HealthifyApp.Data.Models;
using HealthifyApp.Data.Models.Enums;
using HealthifyApp.Data.Repository.Interfaces;
using HealthifyApp.Service.Data.Interfaces;
using HealthifyApp.Services.Data;
using HealthifyApp.Web.ViewModels.BMI;

namespace HealthifyApp.Service.Data
{
    public class BMIService : BaseService, IBMIService
    {
        private readonly IRepository<BMICalculation, Guid> bmiCalculationRepository;

        public BMIService(IRepository<BMICalculation, Guid> bmiCalculationRepository,
            IRepository<UserProfile, Guid> userProfileRepository)
            : base(userProfileRepository)
        {
            this.bmiCalculationRepository = bmiCalculationRepository;
        }

        public async Task<bool> CreateOrUpdateBMIAsync(Guid userId, float bmi, BMICategory category)
        {
            UserProfile userProfile = await GetUserProfileAsync(userId);

            if (userProfile == null || userProfile.IsActiveProfile == false)
            {
                return false;
            }

            BMICalculation bmiCalculation = await bmiCalculationRepository
                .FirstOrDefaultAsync(x => x.UserProfileId == userProfile.Id);

            if (bmiCalculation == null)
            {
                bmiCalculation = new BMICalculation
                {
                    UserProfileId = userProfile.Id,
                    BMI = bmi,
                    Category = category
                };
                await bmiCalculationRepository.AddAsync(bmiCalculation);
            }
            else
            {
                bmiCalculation.BMI = bmi;
                bmiCalculation.Category = category;
                await bmiCalculationRepository.UpdateAsync(bmiCalculation);
            }

            return true;
        }

        public async Task<BMICalculationViewModel> GetBMIAsync(float bmi)
        {
            return new BMICalculationViewModel
            {
                BMI = (float)Math.Round(bmi, 2),
                Category = DetermineBMICategory(bmi).ToString(),
                Message = "Your BMI has been calculated successfully!"
            };
        }

        public BMICategory DetermineBMICategory(float bmi)
        {
            if (bmi < 18.5) return BMICategory.UnderWeight;
            if (bmi < 24.9) return BMICategory.NormalWeight;
            if (bmi < 29.9) return BMICategory.OverWeight;
            return BMICategory.Obese;
        }

        public float CalculateBMI(float weight, float height)
        {
            return weight / (height * height);
        }
    }
}
