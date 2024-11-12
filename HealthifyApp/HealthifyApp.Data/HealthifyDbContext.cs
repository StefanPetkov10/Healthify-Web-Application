using System.Reflection;
using HealthifyApp.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HealthifyApp.Data
{
    public class HealthifyDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public HealthifyDbContext()
        {
        }

        public HealthifyDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public virtual DbSet<UserProfile> UserProfiles { get; set; } = null!;
        public virtual DbSet<ApplicationUserProfile> ApplicationUserProfiles { get; set; } = null!;
        public virtual DbSet<Workout> Workouts { get; set; } = null!;
        public virtual DbSet<Exercise> Exercises { get; set; } = null!;
        public virtual DbSet<WorkoutExercise> WorkoutExercises { get; set; } = null!;
        public virtual DbSet<ProgressLog> ProgressLogs { get; set; } = null!;
        public virtual DbSet<NutritionPlan> NutritionPlans { get; set; } = null!;
        public virtual DbSet<BMICalculation> BMICalculations { get; set; } = null!;
        public virtual DbSet<WaterIntake> WaterIntakes { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBilder)
        {
            base.OnModelCreating(modelBilder);
            modelBilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
