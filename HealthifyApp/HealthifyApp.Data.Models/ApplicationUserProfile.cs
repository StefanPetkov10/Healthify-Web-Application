namespace HealthifyApp.Data.Models
{
    public class ApplicationUserProfile
    {
        public Guid ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;

        public Guid UserProfileId { get; set; }
        public virtual UserProfile UserProfile { get; set; } = null!;
    }
}
