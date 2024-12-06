using HealthifyApp.Services.Mapping;
using static HealthifyApp.Common.EntityValidationConstants.ProgressLog;
using static HealthifyApp.Common.EntityValidationRequiredMessages.ProgressLog;

namespace HealthifyApp.Web.ViewModels.ProgressLog
{
    using System.ComponentModel.DataAnnotations;
    using AutoMapper;
    using HealthifyApp.Data.Models;

    public class AddProgressLogFormModel : IMapFrom<ProgressLog>, IMapTo<ProgressLog>, IHaveCustomMappings
    {
        [Required(ErrorMessage = ProgressLogDateRequiredMessage)]
        public string Date { get; set; } = null!;

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

        public void CreateMappings(IProfileExpression configurate)
        {
            configurate.CreateMap<ProgressLog, AddProgressLogFormModel>()
                .ForMember(x => x.Date, opt =>
                    opt.MapFrom(x => DateTime.Now.ToString(DateInAddingProgress)));
        }
    }
}
