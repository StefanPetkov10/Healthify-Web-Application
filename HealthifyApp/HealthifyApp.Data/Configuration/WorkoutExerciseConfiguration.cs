using HealthifyApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthifyApp.Data.Configuration
{
    public class WorkoutExerciseConfiguration : IEntityTypeConfiguration<WorkoutExercise>
    {
        public void Configure(EntityTypeBuilder<WorkoutExercise> builder)
        {
            builder
                .HasKey(um => new { um.WorkoutId, um.ExerciseId });

            builder
                .HasOne(um => um.Workout)
                .WithMany(u => u.WorkoutExercises)
                .HasForeignKey(um => um.WorkoutId);

            builder
                .HasOne(um => um.Exercise)
                .WithMany(m => m.WorkoutExercises)
                .HasForeignKey(um => um.ExerciseId);
        }
    }
}
