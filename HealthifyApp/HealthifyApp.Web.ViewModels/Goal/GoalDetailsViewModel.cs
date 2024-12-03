using static HealthifyApp.Common.EntityValidationConstants.Goal;

namespace HealthifyApp.Web.ViewModels.Goal
{
    using AutoMapper;
    using HealthifyApp.Data.Models;
    using HealthifyApp.Services.Mapping;

    public class GoalDetailsViewModel : IMapFrom<Goal>, IHaveCustomMappings
    {
        public string StartDate { get; set; } = null!;

        public string GoalType { get; set; } = null!;

        public string Activity { get; set; } = null!;

        public float GoalWeight { get; set; }

        public float? GoalWaist { get; set; }

        public float? GoalHips { get; set; }

        public float? GoalChest { get; set; }

        public void CreateMappings(IProfileExpression configurate)
        {
            configurate.CreateMap<Goal, GoalDetailsViewModel>()
                .ForMember(x => x.StartDate, opt => opt.MapFrom(y => y.StartDate.ToString(StartDateTimeFormat)));
        }
    }
}
