using HealthifyApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthifyApp.Data.Configuration
{
    public class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
    {
        private readonly SeedData _seedData;

        public ExerciseConfiguration(SeedData seedData)
        {
            _seedData = seedData;
        }

        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            builder.HasData(
                _seedData.Exercise1,
                _seedData.Exercise2
            );
        }
    }
}
