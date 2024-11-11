using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static HealthifyApp.Common.EntityValidationConstants.Workout;

namespace HealthifyApp.Data.Models
{
    public class Workout
    {
        public Workout()
        {
            this.Id = Guid.NewGuid();
            this.WorkoutExercises = new HashSet<WorkoutExercise>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Range(DurationMinValue, DurationMaxValue)]
        public int? Duration { get; set; }

        [Required]
        public DateTime ScheduleDateTime { get; set; }

        public Guid UserProfileId { get; set; }
        [ForeignKey(nameof(UserProfileId))]
        public virtual UserProfile UserProfile { get; set; }

        public virtual ICollection<WorkoutExercise> WorkoutExercises { get; set; }
    }
}
