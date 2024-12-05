using HealthifyApp.Services.Mapping;
using static HealthifyApp.Common.EntityValidationConstants.ProgressLog;
using static HealthifyApp.Common.EntityValidationRequiredMessages.ProgressLog;

namespace HealthifyApp.Web.ViewModels.ProgressLog
{
    using System.ComponentModel.DataAnnotations;
    using HealthifyApp.Data.Models;

    public class AddProgressLogFormModel : IMapTo<ProgressLog>
    {
        [Required(ErrorMessage = ProgressLogDateRequiredMessage)]
        public DateTime Date { get; set; } = DateTime.Now;

        [Required(ErrorMessage = ProgressLogWeightRequiredMessage)]
        [Display(Name = "Goal Weight (kg)")]
        [Range(CurrentWeightMinValue, CurrentWeightMaxValue)]
        public float CurrentWeight { get; set; }

        [Display(Name = "Goal Waist (optional)")]
        [Range(WaistMinValue, WaistMaxValue)]
        public float? GoalWaist { get; set; }

        [Display(Name = "Goal Hips (optional)")]
        [Range(HipsMinValue, HipsMaxValue)]
        public float? GoalHips { get; set; }

        [Display(Name = "Goal Chest (optional)")]
        [Range(ChestMinValue, ChestMaxValue)]
        public float? GoalChest { get; set; }
    }
}
