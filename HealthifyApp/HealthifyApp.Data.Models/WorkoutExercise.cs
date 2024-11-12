using System.ComponentModel.DataAnnotations.Schema;

namespace HealthifyApp.Data.Models
{
    [Table("WorkoutExercises")]
    public class WorkoutExercise
    {
        public Guid WorkoutId { get; set; }
        public virtual Workout Workout { get; set; } = null!;

        public Guid ExerciseId { get; set; }
        public virtual Exercise Exercise { get; set; } = null!;

        public int? Sets { get; set; }

        public int? Reps { get; set; }

    }
}