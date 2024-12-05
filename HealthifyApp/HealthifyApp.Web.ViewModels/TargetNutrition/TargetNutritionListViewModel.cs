using HealthifyApp.Services.Mapping;

using static HealthifyApp.Common.EntityValidationConstants.TargetNutrition;

namespace HealthifyApp.Web.ViewModels.TargetNutrition
{
    using AutoMapper;
    using HealthifyApp.Data.Models;

    public class TargetNutritionListViewModel : IMapFrom<ProgressLog>, IHaveCustomMappings
    {
        public string Id { get; set; } = null!;

        public string GoalName { get; set; } = string.Empty;

        public string StartDate { get; set; } = null!;

        public int TargetCalories { get; set; }

        public int TargetProtein { get; set; }

        public int TargetCarbohydrates { get; set; }

        public int TargetFats { get; set; }

        public void CreateMappings(IProfileExpression configurate)
        {
            configurate.CreateMap<TargetNutrition, TargetNutritionListViewModel>()
                .ForMember(x => x.StartDate, opt =>
                    opt.MapFrom(x => x.StartDate.ToString(StartDateTimeFormat)));
        }
    }
}
