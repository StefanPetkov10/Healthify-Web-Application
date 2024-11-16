using HealthifyApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthifyApp.Data.Configuration
{
    public class ProgressLogConfiguration : IEntityTypeConfiguration<ProgressLog>
    {
        private readonly SeedData _seedData;

        public ProgressLogConfiguration(SeedData seedData)
        {
            _seedData = seedData;
        }

        public void Configure(EntityTypeBuilder<ProgressLog> builder)
        {
            builder.HasData(
                _seedData.ProgressLog1,
                _seedData.ProgressLog2
            );
        }
    }
}
