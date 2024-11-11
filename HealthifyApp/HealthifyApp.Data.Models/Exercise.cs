using System.ComponentModel.DataAnnotations;

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
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        [MaxLength(DurationMaxValue)]
        public string Duration { get; set; } = null!;

        public string? ImageUrl { get; set; }

        public virtual ICollection<WorkoutExercise> WorkoutExercises { get; set; }
    }
}
