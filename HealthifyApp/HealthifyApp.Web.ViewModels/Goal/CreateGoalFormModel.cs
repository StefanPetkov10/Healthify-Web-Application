using System.ComponentModel.DataAnnotations;
using AutoMapper;
using HealthifyApp.Services.Mapping;
using static HealthifyApp.Common.EntityValidationMessages.Goal;

namespace HealthifyApp.Web.ViewModels.Goal
{
    using HealthifyApp.Data.Models;

    public class CreateGoalFormModel : IMapTo<Goal>, IHaveCustomMappings
    {
        public string Id { get; set; } = null!;

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
        [Range(1, 500, ErrorMessage = "Weight must be between 1 and 500 kg.")]
        public float GoalWeight { get; set; }

        [Display(Name = "Goal Waist (optional)")]
        [Range(10, 300, ErrorMessage = "Waist must be between 10 and 300 cm.")]
        public float? GoalWaist { get; set; }

        [Display(Name = "Goal Hips (optional)")]
        [Range(10, 300, ErrorMessage = "Hips must be between 10 and 300 cm.")]
        public float? GoalHips { get; set; }

        [Display(Name = "Goal Chest (optional)")]
        [Range(10, 300, ErrorMessage = "Chest must be between 10 and 300 cm.")]
        public float? GoalChest { get; set; }

        public void CreateMappings(IProfileExpression configurate)
        {
            throw new NotImplementedException();
        }
    }
}

