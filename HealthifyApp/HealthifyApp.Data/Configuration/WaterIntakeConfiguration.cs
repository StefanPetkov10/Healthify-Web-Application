using HealthifyApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthifyApp.Data.Configuration
{
    public class WaterIntakeConfiguration : IEntityTypeConfiguration<WaterIntake>
    {
        private readonly SeedData _seedData;

        public WaterIntakeConfiguration(SeedData seedData)
        {
            _seedData = seedData;
        }

        public void Configure(EntityTypeBuilder<WaterIntake> builder)
        {
            builder.HasData(
                _seedData.WaterIntake1,
                _seedData.WaterIntake2
            );
        }
    }
}
