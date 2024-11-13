using HealthifyApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthifyApp.Data.Configuration
{
    public class ApplicationUserProfileConfiguration : IEntityTypeConfiguration<ApplicationUserProfile>
    {
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
        }
    }
}
