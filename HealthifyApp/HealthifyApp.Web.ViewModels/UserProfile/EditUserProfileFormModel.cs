using System.ComponentModel.DataAnnotations;
using AutoMapper;
using HealthifyApp.Services.Mapping;

using static HealthifyApp.Common.EntityValidationConstants.UserProfile;
using static HealthifyApp.Common.EntityValidationMessages.UserProfile;

namespace HealthifyApp.Web.ViewModels.UserProfile
{
    using HealthifyApp.Data.Models;
    public class EditUserProfileFormModel : IMapFrom<UserProfile>, IMapTo<UserProfile>, IHaveCustomMappings
    {
        [Required]
        public string Id { get; set; } = null!;

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

        public void CreateMappings(IProfileExpression configurate)
        {
            configurate.CreateMap<UserProfile, EditUserProfileFormModel>()
                .ForMember(up => up.Gender, opt =>
                    opt.Ignore());

            configurate.CreateMap<EditUserProfileFormModel, UserProfile>()
                .ForMember(up => up.Gender, opt =>
                    opt.Ignore())
                .ForMember(up => up.Id, opt =>
                    opt.Ignore());
        }
    }
}
