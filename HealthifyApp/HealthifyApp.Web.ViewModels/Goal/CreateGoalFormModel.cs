using System.ComponentModel.DataAnnotations;
using AutoMapper;
using HealthifyApp.Services.Mapping;
using static HealthifyApp.Common.EntityValidationConstants.Goal;
using static HealthifyApp.Common.EntityValidationRequiredMessages.Goal;

namespace HealthifyApp.Web.ViewModels.Goal
{
    using HealthifyApp.Data.Models;

    public class CreateGoalFormModel : IMapTo<Goal>, IHaveCustomMappings
    {
        [Required(ErrorMessage = GoalStartDateRequiredMessage)]
        [Display(Name = "Start Date in format dd-MM-yyyy")]
        public string StartDate { get; set; } = null!;

        [Required(ErrorMessage = GoalTypeRequiredMessage)]
        [Display(Name = "Goal Type")]
        public string GoalType { get; set; } = null!;

        [Required(ErrorMessage = GoalActivityRequiredMessage)]
        [Display(Name = "Activity Level")]
        public string Activity { get; set; } = null!;

        [Required(ErrorMessage = GoalWeightRequiredMessage)]
        [Display(Name = "Goal Weight (kg)")]
        [Range(WeightMinValue, WeightMaxValue)]
        public float GoalWeight { get; set; }

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
            configurate.CreateMap<CreateGoalFormModel, Goal>()
                .ForMember(dest => dest.StartDate, opt => opt.Ignore())
                .ForMember(dest => dest.GoalType, opt => opt.Ignore())
                .ForMember(dest => dest.Activity, opt => opt.Ignore());
        }
    }
}

