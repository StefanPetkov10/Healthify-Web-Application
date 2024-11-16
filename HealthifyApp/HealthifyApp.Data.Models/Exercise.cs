using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using static HealthifyApp.Common.EntityValidationConstants.Exercise;

namespace HealthifyApp.Data.Models
{
    public class Exercise
    {
        public Exercise()
        {
            this.Id = Guid.NewGuid();
            this.WorkoutExercises = new HashSet<WorkoutExercise>();
        }

        [Key]
        [Comment("Primary key for the exercise.")]
        public Guid Id { get; set; }

        [Required]
        [Comment("Name of the exercise.")]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [Comment("Description of the exercise.")]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Comment("Duration of the exercise in minutes.")]
        [MaxLength(DurationMaxValue)]
        public int? Duration { get; set; }

        [Comment("URL of the image of the exercise.")]
        public string? ImageUrl { get; set; }

        public virtual ICollection<WorkoutExercise> WorkoutExercises { get; set; }
    }
}
