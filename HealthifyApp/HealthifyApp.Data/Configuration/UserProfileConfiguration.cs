using HealthifyApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthifyApp.Data.Configuration
{
    public class UserProfileConfiguration : IEntityTypeConfiguration<UserProfile>
    {
        private readonly SeedData _seedData;

        public UserProfileConfiguration(SeedData seedData)
        {
            _seedData = seedData;
        }

        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder
                .Property(p => p.IsActiveProfile)
                .HasDefaultValue(false);

            builder.HasData(
                _seedData.UserProfile1,
                _seedData.UserProfile2
            );
        }
    }
}

