using HealthifyApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthifyApp.Data.Configuration
{
    public class GoalConfiguration : IEntityTypeConfiguration<Goal>
    {
        private readonly SeedData _seedData;

        public GoalConfiguration(SeedData seedData)
        {
            _seedData = seedData;
        }

        public void Configure(EntityTypeBuilder<Goal> builder)
        {
            builder.HasData(
                _seedData.Goal1,
                _seedData.Goal2
            );
        }
    }
}
