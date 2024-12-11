using HealthifyApp.Data.Models.Enums;

using static HealthifyApp.Common.EntityValidationConstants.WaterIntake;
using static HealthifyApp.Common.EntityValidationRequiredMessages.WaterIntake;

namespace HealthifyApp.Web.ViewModels.WaterIntake
{
    using System.ComponentModel.DataAnnotations;

    public class WaterIntakeInputModel
    {
        [Required(ErrorMessage = WaterIntakeWeightRequiredMessage)]
        [Range(WeightMinValue, WeightMaxValue)]
        public float Weight { get; set; }

        [Required(ErrorMessage = WaterIntakeActivityRequiredMessage)]
        public Activity ActivityLevel { get; set; }
    }
}
