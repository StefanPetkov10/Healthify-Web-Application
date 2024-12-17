using HealthifyApp.Web.ViewModels.Admin.UserManagement;

namespace HealthifyApp.Service.Data.Interfaces.AdminInterfaces
{
    public interface IUserService
    {
        Task<IEnumerable<AllUserViewModel>> GetAllUsersAsync();

        Task<bool> UserExistsByIdAsync(Guid userId);

        Task<bool> AssignUserToRoleAsync(Guid userId, string roleName);

        Task<bool> RemoveUserRoleAsync(Guid userId, string roleName);

        Task<bool> SoftDeleteUserAsync(Guid userId);
    }
}

