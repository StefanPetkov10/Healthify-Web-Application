using HealthifyApp.Data;
using HealthifyApp.Data.Models;
using HealthifyApp.Data.Repository.Interfaces;
using HealthifyApp.Service.Data.Interfaces.AdminInterfaces;
using HealthifyApp.Web.ViewModels.Admin.UserManagement;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HealthifyApp.Service.Data.AdminServices
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole<Guid>> roleManager;
        private readonly IRepository<UserProfile, Guid> userProfileRepository;

        public UserService(UserManager<ApplicationUser> userManager,
                            RoleManager<IdentityRole<Guid>> roleManager,
                              IRepository<UserProfile, Guid> userProfileRepository)

        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.userProfileRepository = userProfileRepository;
        }


        public async Task<IEnumerable<AllUserViewModel>> GetAllUsersAsync()
        {
            IEnumerable<ApplicationUser> allUsers = await userManager.Users
            .Where(x => x.ApplicationUserProfiles.Any(p => p.UserProfile.IsActiveProfile == true))
            .ToArrayAsync();

            ICollection<AllUserViewModel> allUsersViewModel = new List<AllUserViewModel>();

            foreach (ApplicationUser user in allUsers)
            {
                IEnumerable<string> roles = await userManager.GetRolesAsync(user);

                allUsersViewModel.Add(new AllUserViewModel()
                {
                    Id = user.Id.ToString(),
                    Email = user.Email,
                    Roles = roles
                });
            }

            return allUsersViewModel;
        }

        public async Task<bool> UserExistsByIdAsync(Guid userId)
        {
            ApplicationUser? user = await userManager
                .FindByIdAsync(userId.ToString());

            return user != null;
        }
        public async Task<bool> AssignUserToRoleAsync(Guid userId, string roleName)
        {
            ApplicationUser? user = await userManager
                .FindByIdAsync(userId.ToString());
            bool roleExists = await roleManager.RoleExistsAsync(roleName);

            if (user == null || !roleExists)
            {
                return false;
            }

            bool alreadyInRole = await userManager.IsInRoleAsync(user, roleName);
            if (!alreadyInRole)
            {
                IdentityResult? result = await userManager
                    .AddToRoleAsync(user, roleName);

                if (!result.Succeeded)
                {
                    return false;
                }
            }

            return true;
        }

        public async Task<bool> RemoveUserRoleAsync(Guid userId, string roleName)
        {
            ApplicationUser? user = await userManager
                .FindByIdAsync(userId.ToString());
            bool roleExists = await roleManager.RoleExistsAsync(roleName);

            if (user == null || !roleExists)
            {
                return false;
            }

            bool alreadyInRole = await userManager.IsInRoleAsync(user, roleName);
            if (alreadyInRole)
            {
                IdentityResult? result = await userManager
                    .RemoveFromRoleAsync(user, roleName);

                if (!result.Succeeded)
                {
                    return false;
                }
            }

            return true;
        }

        public async Task<bool> SoftDeleteUserAsync(Guid userId)
        {
            UserProfile? userProfile = await userProfileRepository
                .GetAllAttached()
                .FirstOrDefaultAsync(up => up.ApplicationUserProfiles
                .Any(a => a.ApplicationUserId.ToString() == userId.ToString()));

            if (userProfile == null)
            {
                return false;
            }

            userProfile.IsActiveProfile = false;
            return await userProfileRepository.UpdateAsync(userProfile);
        }
    }
}
