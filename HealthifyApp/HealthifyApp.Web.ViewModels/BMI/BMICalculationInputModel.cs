using System.ComponentModel.DataAnnotations;

using static HealthifyApp.Common.EntityValidationConstants.BMICalculation;
using static HealthifyApp.Common.EntityValidationRequiredMessages.BMICalculation;

namespace HealthifyApp.Web.ViewModels.BMI
{
    public class BMICalculationInputModel
    {
        [Required(ErrorMessage = WeightRequiredMessage)]
        [Range(WeightMinValue, WeightMaxValue)]
        public float Weight { get; set; }

        [Required(ErrorMessage = HeightRequiredMessage)]
        [Range(HeightMinValue, HeightMaxValue)]
        public float Height { get; set; }
    }
}
