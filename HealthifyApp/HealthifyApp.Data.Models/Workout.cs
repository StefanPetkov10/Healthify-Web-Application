using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
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
        [Comment("Primary key for the workout.")]
        public Guid Id { get; set; }

        [Required]
        [Comment("Name of the workout.")]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [Comment("Description of the workout.")]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Comment("Duration of the workout in minutes.")]
        public int? Duration { get; set; }

        [Required]
        [Comment("The schedule date and time of the workout.")]
        public DateTime ScheduleDateTime { get; set; }

        [Required]
        [Comment("The user profile ID.")]
        public Guid UserProfileId { get; set; }
        [ForeignKey(nameof(UserProfileId))]
        public virtual UserProfile UserProfile { get; set; }

        public virtual ICollection<WorkoutExercise> WorkoutExercises { get; set; }
    }
}
