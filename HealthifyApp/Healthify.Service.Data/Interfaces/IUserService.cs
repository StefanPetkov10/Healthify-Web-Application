using HealthifyApp.Web.ViewModels.Admin.UserManagement;

namespace HealthifyApp.Service.Data.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<AllUserViewModel>> GetAllUsersAsync();

        //Task<bool> UserExistsByIdAsync(Guid userId);

        //Task<bool> AssignUserToRoleAsync(Guid userId, string roleName);

        //Task<bool> RemoveUserRoleAsync(Guid userId, string roleName);

        //Task<bool> DeleteUserAsync(Guid userId);
    }
}

