using HealthifyApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthifyApp.Data.Configuration
{
    public class WorkoutConfiguration : IEntityTypeConfiguration<Workout>
    {
        private readonly SeedData _seedData;

        public WorkoutConfiguration(SeedData seedData)
        {
            _seedData = seedData;
        }

        public void Configure(EntityTypeBuilder<Workout> builder)
        {
            builder.HasData(
                _seedData.Workout1,
                _seedData.Workout2
            );
        }
    }
}
