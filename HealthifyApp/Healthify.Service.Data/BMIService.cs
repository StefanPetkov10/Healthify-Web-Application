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

        public Task<bool> CreateOrUpdateBMIAsync(Guid userId, float bmi, BMICategory category)
        {
            throw new NotImplementedException();
        }

        public Task<BMICalculationViewModel> GetBMIAsync(float bmi)
        {
            throw new NotImplementedException();
        }

        public BMICategory DetermineBMICategory(float bmi)
        {
            throw new NotImplementedException();
        }

        public float CalculateBMI(float weight, float height)
        {
            throw new NotImplementedException();
        }
    }
}
