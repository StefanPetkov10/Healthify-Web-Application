using HealthifyApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthifyApp.Data.Configuration
{
    public class NutritionPlanConfiguration : IEntityTypeConfiguration<NutritionPlan>
    {
        private readonly SeedData _seedData;

        public NutritionPlanConfiguration(SeedData seedData)
        {
            _seedData = seedData;
        }

        public void Configure(EntityTypeBuilder<NutritionPlan> builder)
        {
            builder.HasData(
                _seedData.NutritionPlan1,
                _seedData.NutritionPlan2
            );
        }
    }
}
