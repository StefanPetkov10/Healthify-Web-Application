using System.ComponentModel.DataAnnotations.Schema;

namespace HealthifyApp.Data.Models
{
    [Table("ApplicationUserProfiles")]
    public class ApplicationUserProfile
    {
        public Guid ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;

        public Guid UserProfileId { get; set; }
        public virtual UserProfile UserProfile { get; set; } = null!;
    }
}
