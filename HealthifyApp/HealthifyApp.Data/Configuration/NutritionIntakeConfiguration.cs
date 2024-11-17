using HealthifyApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthifyApp.Data.Configuration
{
    public class NutritionIntakeConfiguration : IEntityTypeConfiguration<NutritionIntake>
    {
        private readonly SeedData _seedData;

        public NutritionIntakeConfiguration(SeedData seedData)
        {
            _seedData = seedData;
        }

        public void Configure(EntityTypeBuilder<NutritionIntake> builder)
        {
            builder.HasData(
                _seedData.NutritionIntake1,
                _seedData.NutritionIntake2
            );
        }
    }
}
