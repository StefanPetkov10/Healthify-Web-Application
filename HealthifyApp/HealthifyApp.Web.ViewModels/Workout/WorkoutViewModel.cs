using HealthifyApp.Services.Mapping;

using static HealthifyApp.Common.EntityValidationConstants.Workout;
namespace HealthifyApp.Web.ViewModels.Workout
{
    using AutoMapper;
    using HealthifyApp.Data.Models;

    public class WorkoutViewModel : IMapFrom<Workout>, IHaveCustomMappings
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int? Duration { get; set; }
        public string ScheduleDateTime { get; set; } = null!;
        public string UserName { get; set; } = null!;

        public void CreateMappings(IProfileExpression configurate)
        {
            configurate.CreateMap<Workout, WorkoutViewModel>()
                .ForMember(x => x.ScheduleDateTime, opt =>
                    opt.MapFrom(x => x.ScheduleDateTime.ToString(ScheduleDateTimeFormat)));
        }
    }
}
