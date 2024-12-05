using AutoMapper;
using HealthifyApp.Services.Mapping;

using static HealthifyApp.Common.EntityValidationConstants.ProgressLog;

namespace HealthifyApp.Web.ViewModels.ProgressLog
{
    using HealthifyApp.Data.Models;

    public class ProgressLogListViewModel : IMapTo<ProgressLog>, IHaveCustomMappings
    {
        public string Id { get; set; } = null!;

        public string Date { get; set; } = null!;

        public float CurrentWeight { get; set; }

        public float? Waist { get; set; }

        public float? Hips { get; set; }

        public float? Chest { get; set; }

        public void CreateMappings(IProfileExpression configurate)
        {
            configurate.CreateMap<ProgressLog, ProgressLogListViewModel>()
                .ForMember(x => x.Date, opt =>
                    opt.MapFrom(x => x.Date.ToString(DateInAddingProgress)));
        }
    }
}
