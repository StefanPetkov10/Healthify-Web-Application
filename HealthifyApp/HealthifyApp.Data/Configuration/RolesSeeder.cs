using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using static HealthifyApp.Common.ApplicationConstants;

namespace HealthifyApp.Data.Configuration
{
    public static class RolesSeeder
    {
        public static void SeedRoles(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole<Guid>>>();

            string[] roles = { AdminRole, UserRole };

            foreach (var role in roles)
            {
                var roleExist = roleManager.RoleExistsAsync(role).GetAwaiter().GetResult();
                if (!roleExist)
                {
                    var result = roleManager.CreateAsync(new IdentityRole<Guid> { Name = role }).GetAwaiter().GetResult();
                    if (!result.Succeeded)
                    {
                        throw new Exception($"Failed to create role: {role}");
                    }
                }
            }
        }

        public static void AssignAdminRole(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var configuration = serviceProvider.GetRequiredService<IConfiguration>();

            string adminEmail = configuration["AdminSettings:Username"];
            string adminPassword = configuration["AdminSettings:Password"];

            var existingAdmin = userManager.FindByEmailAsync(adminEmail!).GetAwaiter().GetResult();

            if (existingAdmin == null)
            {
                var adminUser = new ApplicationUser
                {
                    UserName = adminEmail,
                    Email = adminEmail
                };

                var result = userManager.CreateAsync(adminUser, adminPassword!).GetAwaiter().GetResult();

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(adminUser, AdminRole).GetAwaiter().GetResult();
                }
                else
                {
                    throw new Exception("Failed to create admin user");
                }
            }
        }
    }
}