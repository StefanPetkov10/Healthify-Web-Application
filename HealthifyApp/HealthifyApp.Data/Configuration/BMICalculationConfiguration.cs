using HealthifyApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthifyApp.Data.Configuration
{
    public class BMICalculationConfiguration : IEntityTypeConfiguration<BMICalculation>
    {
        private readonly SeedData _seedData;

        public BMICalculationConfiguration(SeedData seedData)
        {
            _seedData = seedData;
        }

        public void Configure(EntityTypeBuilder<BMICalculation> builder)
        {
            builder.HasData(
                _seedData.BMICalculation1,
                _seedData.BMICalculation2
            );
        }
    }
}
