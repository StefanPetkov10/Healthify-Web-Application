using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace HealthifyApp.Data
{
    public class HealthifyDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
    }
}
