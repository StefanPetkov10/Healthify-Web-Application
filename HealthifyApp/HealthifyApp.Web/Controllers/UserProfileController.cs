using HealthifyApp.Service.Data.Interfaces;
using HealthifyApp.Services.Data.Interfaces;
using HealthifyApp.Web.Infrastructure.Extensions;
using HealthifyApp.Web.ViewModels.UserProfile;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static HealthifyApp.Common.ErrorMessages.UserProfile;

namespace HealthifyApp.Web.Controllers
{
    public class UserProfileController : BaseController
    {
        private readonly IUserProfileService userProfileService;

        public UserProfileController(IBaseService baseService, IUserProfileService userProfileService)
            : base(baseService)
        {
            this.userProfileService = userProfileService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var userId = User.GetUserId();

            var viewModel = await this.userProfileService.IndexGetUserProfileAsync(new Guid(userId));

            if (viewModel == null)
            {
                return RedirectToAction(nameof(Create));
            }

            return View(viewModel);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Create()
        {
            return View(new CreateUserProfileFormModel());
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CreateUserProfileFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var userId = User.GetUserId();

            await this.userProfileService.CreateUserProfileAsync(model, new Guid(userId!));

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit(string? id)
        {
            Guid userGuid = Guid.Empty;
            bool isIdValid = this.IsGuidValid(id, out userGuid);
            if (!isIdValid)
            {
                return this.RedirectToAction(nameof(Index));
            }

            EditUserProfileFormModel? formModel = await this.userProfileService
                .GetEditUserProfileAsync(userGuid);

            if (formModel == null)
            {
                return this.RedirectToAction(nameof(Index));
            }

            return View(formModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Edit(EditUserProfileFormModel formModel)
        {
            if (!ModelState.IsValid)
            {
                return View(formModel);
            }

            bool isUpdated = await this.userProfileService.EditUserProfileAsync(formModel);

            if (!isUpdated)
            {
                ModelState.AddModelError(string.Empty, UserProfileUpdateError);
                return this.View(formModel);
            }

            return this.RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Delete(string? id)
        {
            Guid cinemaGuid = Guid.Empty;
            if (!this.IsGuidValid(id, out cinemaGuid))
            {
                return this.RedirectToAction(nameof(Index));
            }

            DeleteUserProfileViewModel? userProfileToDeleteViewModel =
                await this.userProfileService.GetUserProfileForDeleteByIdAsync(cinemaGuid);
            if (userProfileToDeleteViewModel == null)
            {
                return this.RedirectToAction(nameof(Index));
            }

            return this.View(userProfileToDeleteViewModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> SoftDeleteConfirmed(DeleteUserProfileViewModel userProfile)
        {
            Guid userGuid = Guid.Empty;
            bool isIdValid = this.IsGuidValid(userProfile.Id, out userGuid);
            if (!isIdValid)
            {
                return this.RedirectToAction(nameof(Index));
            }

            bool isDeleted = await this.userProfileService.SoftDeleteUserProfileAsync(userGuid);

            if (!isDeleted)
            {
                TempData["ErrorMessage"] = UserProfileDeleteError;
                return this.RedirectToAction(nameof(Delete), new { id = userProfile.Id });
            }

            return this.RedirectToAction(nameof(Index));
        }

    }
}


