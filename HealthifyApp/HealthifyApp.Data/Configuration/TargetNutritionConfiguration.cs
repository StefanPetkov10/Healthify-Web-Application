using HealthifyApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthifyApp.Data.Configuration
{
    public class TargetNutritionConfiguration : IEntityTypeConfiguration<TargetNutrition>
    {
        private readonly SeedData _seedData;

        public TargetNutritionConfiguration(SeedData seedData)
        {
            _seedData = seedData;
        }

        public void Configure(EntityTypeBuilder<TargetNutrition> builder)
        {
            builder.HasData(
                _seedData.TargetNutrition1,
                _seedData.TargetNutrition2
            );
        }
    }
}
