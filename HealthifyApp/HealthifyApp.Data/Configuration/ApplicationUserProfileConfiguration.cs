using HealthifyApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthifyApp.Data.Configuration
{
    public class ApplicationUserProfileConfiguration : IEntityTypeConfiguration<ApplicationUserProfile>
    {
        private readonly SeedData _seedData;

        public ApplicationUserProfileConfiguration(SeedData seedData)
        {
            _seedData = seedData;
        }

        public void Configure(EntityTypeBuilder<ApplicationUserProfile> builder)
        {
            builder
                .HasKey(um => new { um.ApplicationUserId, um.UserProfileId });

            builder
                .HasOne(um => um.ApplicationUser)
                .WithMany(u => u.ApplicationUserProfiles)
                .HasForeignKey(um => um.ApplicationUserId);

            builder
                .HasOne(um => um.UserProfile)
                .WithMany(m => m.ApplicationUserProfiles)
                .HasForeignKey(um => um.UserProfileId);

            builder
                .HasData(
                    _seedData.ApplicationUserProfile1,
                    _seedData.ApplicationUserProfile2
                );
        }
    }
}
