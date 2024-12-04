using HealthifyApp.Services.Mapping;

namespace HealthifyApp.Web.ViewModels.TargetNutrition
{
    using AutoMapper;
    using HealthifyApp.Data.Models;

    public class CreateTargetNutritionFormModel : IMapTo<TargetNutrition>, IHaveCustomMappings
    {
        public string GoalId { get; set; } = null!;
        public string GoalName { get; set; } = null!;
        public string StartDate { get; set; } = null!;
        public int TargetCalories { get; set; }
        public int TargetProtein { get; set; }
        public int TargetCarbohydrates { get; set; }
        public int TargetFats { get; set; }

        public void CreateMappings(IProfileExpression configurate)
        {
            configurate.CreateMap<CreateTargetNutritionFormModel, TargetNutrition>()
                .ForMember(x => x.StartDate, opt => opt.Ignore());
        }
    }
}
