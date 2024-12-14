using HealthifyApp.Service.Data.Interfaces;
using HealthifyApp.Services.Data.Interfaces;
using HealthifyApp.Web.Controllers;
using HealthifyApp.Web.ViewModels.Admin.UserManagement;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace HealthifyApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class UserManagementController : BaseController
    {
        private readonly IUserService userService;
        public UserManagementController(IBaseService baseService,
                                           IUserService userService)
            : base(baseService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<AllUserViewModel> allUsers = await this.userService
                .GetAllUsersAsync();

            return this.View(allUsers);
        }

        [HttpPost]
        public async Task<IActionResult> AssignRole(string userId, string role)
        {
            Guid userGuid = Guid.Empty;
            if (!this.IsGuidValid(userId, out userGuid))
            {
                return this.RedirectToAction(nameof(Index));
            }

            bool userExists = await this.userService
                .UserExistsByIdAsync(userGuid);
            if (!userExists)
            {
                return this.RedirectToAction(nameof(Index));
            }

            bool assignResult = await this.userService
                .AssignUserToRoleAsync(userGuid, role);
            if (!assignResult)
            {
                return this.RedirectToAction(nameof(Index));
            }

            return this.RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> RemoveRole(string userId, string role)
        {
            Guid userGuid = Guid.Empty;
            if (!this.IsGuidValid(userId, out userGuid))
            {
                return this.RedirectToAction(nameof(Index));
            }

            bool userExists = await this.userService
                .UserExistsByIdAsync(userGuid);
            if (!userExists)
            {
                return this.RedirectToAction(nameof(Index));
            }

            bool removeResult = await this.userService
                .RemoveUserRoleAsync(userGuid, role);
            if (!removeResult)
            {
                return this.RedirectToAction(nameof(Index));
            }

            return this.RedirectToAction(nameof(Index));
        }

        //        [HttpPost]
        //        public async Task<IActionResult> DeleteUser(string userId)
        //        {
        //            Guid userGuid = Guid.Empty;
        //            if (!this.IsGuidIdValid(userId, ref userGuid))
        //            {
        //                return this.RedirectToAction(nameof(Index));
        //            }

        //            bool userExists = await this.userService
        //                .UserExistsByIdAsync(userGuid);
        //            if (!userExists)
        //            {
        //                return this.RedirectToAction(nameof(Index));
        //            }

        //            bool removeResult = await this.userService
        //                .DeleteUserAsync(userGuid);
        //            if (!removeResult)
        //            {
        //                return this.RedirectToAction(nameof(Index));
        //            }

        //            return this.RedirectToAction(nameof(Index));
        //        }
    }
}

