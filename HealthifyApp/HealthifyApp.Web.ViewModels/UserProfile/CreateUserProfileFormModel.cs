using System.ComponentModel.DataAnnotations;
using static HealthifyApp.Common.EntityValidationConstants.UserProfile;
using static HealthifyApp.Common.EntityValidationMessages.UserProfile;

namespace HealthifyApp.Web.ViewModels.UserProfile
{
    public class CreateUserProfileFormModel
    {
        [Required(ErrorMessage = FirstNameRequiredMessage)]
        [MinLength(FirstNameMinLength)]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = LastNameRequiredMessage)]
        [MinLength(LastNameMinLength)]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = AgeRequiredMessage)]
        [Range(AgeMinValue, AgeMaxValue)]
        public int Age { get; set; }

        [Required(ErrorMessage = HeightRequiredMessage)]
        [Range(HeightMinValue, HeightMaxValue)]
        public float Height { get; set; }

        [Required(ErrorMessage = StartingWeightRequiredMessage)]
        [Range(WeightMinValue, WeightMaxValue)]
        public float StartingWeight { get; set; }

        [Required(ErrorMessage = GenderRequiredMessage)]
        public string Gender { get; set; } = null!;

        public bool IsActiveProfile { get; set; }
    }
}
