using HealthifyApp.Services.Mapping;

using static HealthifyApp.Common.EntityValidationConstants.Goal;

namespace HealthifyApp.Web.ViewModels.Goal
{
    using AutoMapper;
    using HealthifyApp.Data.Models;

    public class GoalListViewModel : IMapFrom<Goal>, IHaveCustomMappings
    {
        public string Id { get; set; } = null!;

        public string StartDate { get; set; } = null!;

        public string GoalType { get; set; } = null!;

        public string Activity { get; set; } = null!;

        public float GoalWeight { get; set; }

        public void CreateMappings(IProfileExpression configurate)
        {
            configurate.CreateMap<Goal, GoalListViewModel>()
                .ForMember(x => x.StartDate, opt =>
                    opt.MapFrom(x => x.StartDate.ToString(StartDateTimeFormat)));
        }
    }
}