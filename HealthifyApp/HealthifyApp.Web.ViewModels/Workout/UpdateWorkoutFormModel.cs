using System.ComponentModel.DataAnnotations;
using AutoMapper;
using HealthifyApp.Services.Mapping;
using static HealthifyApp.Common.EntityValidationConstants.Workout;
using static HealthifyApp.Common.EntityValidationRequiredMessages.Workout;

namespace HealthifyApp.Web.ViewModels.Workout
{
    using HealthifyApp.Data.Models;
    public class UpdateWorkoutFormModel : IMapFrom<Workout>, IMapTo<Workout>, IHaveCustomMappings
    {
        [Required]
        public string Id { get; set; } = null!;

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
            configurate.CreateMap<Workout, UpdateWorkoutFormModel>()
                .ForMember(dest => dest.ScheduleDateTime, opt => opt.Ignore());

            configurate.CreateMap<UpdateWorkoutFormModel, Workout>()
                .ForMember(dest => dest.ScheduleDateTime, opt => opt.Ignore())
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}
