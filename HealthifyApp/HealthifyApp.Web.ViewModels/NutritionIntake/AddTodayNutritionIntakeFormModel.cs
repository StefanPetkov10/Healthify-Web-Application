using System.ComponentModel.DataAnnotations;
using HealthifyApp.Services.Mapping;
using static HealthifyApp.Common.EntityValidationConstants.NutritionIntake;
using static HealthifyApp.Common.EntityValidationRequiredMessages.NutritionIntake;

namespace HealthifyApp.Web.ViewModels.NutritionIntake
{
    using AutoMapper;
    using HealthifyApp.Data.Models;

    public class AddTodayNutritionIntakeFormModel : IMapFrom<NutritionIntake>, IHaveCustomMappings
    {
        [Required(ErrorMessage = NutritionIntakeDateRequiredMessage)]
        public string Date { get; set; } = null!;

        [Required(ErrorMessage = NutritionIntakeCaloriesRequiredMessage)]
        [Display(Name = "Calories intake")]
        [Range(CaloriesMinValue, CaloriesMaxValue)]
        public int Calories { get; set; }

        [Required(ErrorMessage = NutritionIntakeProteinRequiredMessage)]
        [Display(Name = "Protein intake")]
        [Range(ProteinMinValue, ProteinMaxValue)]
        public int Protein { get; set; }

        [Required(ErrorMessage = NutritionIntakeCarbohydratesRequiredMessage)]
        [Display(Name = "Carbohydrates intake")]
        [Range(CarbohydratesMinValue, CarbohydratesMaxValue)]
        public int Carbohydrates { get; set; }

        [Required(ErrorMessage = NutritionIntakeFatsRequiredMessage)]
        [Display(Name = "Fats intake")]
        [Range(FatsMinValue, FatsMaxValue)]
        public int Fats { get; set; }

        public void CreateMappings(IProfileExpression configurate)
        {
            configurate.CreateMap<NutritionIntake, AddTodayNutritionIntakeFormModel>()
                .ForMember(x => x.Date, opt =>
                    opt.MapFrom(x => DateTime.Now.ToString(DateInAddingProgress)));
        }
    }
}
