using HealthifyApp.Data.Configuration;
using HealthifyApp.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HealthifyApp.Data
{
    public class HealthifyDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        private readonly SeedData _seedData;
        public HealthifyDbContext()
        {
        }

        public HealthifyDbContext(DbContextOptions options, SeedData seedData)
            : base(options)
        {
            _seedData = seedData;
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

            modelBilder.ApplyConfiguration(new ApplicationUserProfileConfiguration());
            modelBilder.ApplyConfiguration(new ApplicationUserConfiguration(_seedData));
            modelBilder.ApplyConfiguration(new UserProfileConfiguration(_seedData));
            modelBilder.ApplyConfiguration(new WorkoutConfiguration(_seedData));
            modelBilder.ApplyConfiguration(new ExerciseConfiguration(_seedData));
            modelBilder.ApplyConfiguration(new ProgressLogConfiguration(_seedData));
            modelBilder.ApplyConfiguration(new NutritionPlanConfiguration(_seedData));
            modelBilder.ApplyConfiguration(new WaterIntakeConfiguration(_seedData));
            modelBilder.ApplyConfiguration(new BMICalculationConfiguration(_seedData));
            modelBilder.ApplyConfiguration(new WorkoutExerciseConfiguration(_seedData));

        }
    }
}
