using System.ComponentModel.DataAnnotations;

using static HealthifyApp.Common.EntityValidationConstants.WorkoutExercise;

namespace HealthifyApp.Data.Models
{
    public class WorkoutExercise
    {
        public Guid WorkoutId { get; set; }
        public virtual Workout Workout { get; set; } = null!;

        public Guid ExerciseId { get; set; }
        public virtual Exercise Exercise { get; set; } = null!;

        [Required]
        [Range(SetsMinValue, SetsMaxValue)]
        public int Sets { get; set; }

        [Required]
        [Range(RepsMinValue, RepsMaxValue)]
        public int Reps { get; set; }

    }
}