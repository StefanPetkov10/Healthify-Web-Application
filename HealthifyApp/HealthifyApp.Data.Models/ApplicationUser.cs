using HealthifyApp.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace HealthifyApp.Data
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid();
            this.ApplicationUserProfiles = new HashSet<ApplicationUserProfile>();
        }

        public virtual ICollection<ApplicationUserProfile> ApplicationUserProfiles { get; set; }
    }
}