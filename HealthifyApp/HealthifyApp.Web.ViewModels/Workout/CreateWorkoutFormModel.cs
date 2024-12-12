using System.ComponentModel.DataAnnotations;
using HealthifyApp.Services.Mapping;
using static HealthifyApp.Common.EntityValidationConstants.Workout;
using static HealthifyApp.Common.EntityValidationRequiredMessages.Workout;
namespace HealthifyApp.Web.ViewModels.Workout
{
    using AutoMapper;
    using HealthifyApp.Data.Models;
    public class CreateWorkoutFormModel : IMapTo<Workout>, IHaveCustomMappings
    {
        [Required(ErrorMessage = WorkoutNameRequiredMessage)]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = WorkoutDescriptionRequiredMessage)]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Range(DurationMinValue, DurationMaxValue)]
        public int? Duration { get; set; }

        [Required(ErrorMessage = WorkoutScheduleDateTimeRequiredMessage)]
        public string ScheduleDateTime { get; set; } = null!;

        public void CreateMappings(IProfileExpression configurate)
        {
            configurate.CreateMap<CreateWorkoutFormModel, Workout>()
                .ForMember(dest => dest.ScheduleDateTime, opt => opt.Ignore());
        }
    }
}
