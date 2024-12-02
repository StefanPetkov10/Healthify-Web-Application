using System.ComponentModel.DataAnnotations;
using static HealthifyApp.Common.EntityValidationConstants.UserProfile;
using static HealthifyApp.Common.EntityValidationMessages.UserProfile;

namespace HealthifyApp.Web.ViewModels.UserProfile
{
    using AutoMapper;
    using HealthifyApp.Data.Models;
    using HealthifyApp.Services.Mapping;

    public class CreateUserProfileFormModel : IMapTo<UserProfile>, IHaveCustomMappings
    {
        [Required(ErrorMessage = FirstNameRequiredMessage)]
        [Display(Name = "First Name")]
        [MinLength(FirstNameMinLength)]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = LastNameRequiredMessage)]
        [Display(Name = "Last Name")]
        [MinLength(LastNameMinLength)]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = AgeRequiredMessage)]
        [Display(Name = "Age")]
        [Range(AgeMinValue, AgeMaxValue)]
        public int Age { get; set; }

        [Required(ErrorMessage = HeightRequiredMessage)]
        [Display(Name = "Height (cm)")]
        [Range(HeightMinValue, HeightMaxValue)]
        public float Height { get; set; }

        [Required(ErrorMessage = StartingWeightRequiredMessage)]
        [Display(Name = "Starting Weight (kg)")]
        [Range(WeightMinValue, WeightMaxValue)]
        public float StartingWeight { get; set; }

        [Required(ErrorMessage = GenderRequiredMessage)]
        public string Gender { get; set; } = null!;

        public bool IsActiveProfile { get; set; }

        public void CreateMappings(IProfileExpression configurate)
        {
            configurate.CreateMap<CreateUserProfileFormModel, UserProfile>()
                .ForMember(up => up.Gender, opt =>
                    opt.Ignore());
            configurate.CreateMap<CreateUserProfileFormModel, UserProfile>()
                .ForMember(up => up.IsActiveProfile, opt =>
                    opt.Ignore());
        }
    }
}
