using CinemaApp.Services.Data.Interfaces;
using HealthifyApp.Data;
using HealthifyApp.Data.Models;
using HealthifyApp.Data.Models.Enums;
using HealthifyApp.Web.Infrastructure.Extensions;
using HealthifyApp.Web.ViewModels.UserProfile;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HealthifyApp.Web.Controllers
{
    public class UserProfileController : BaseController
    {
        private readonly HealthifyDbContext _dbContext;

        public UserProfileController(IBaseService baseService, HealthifyDbContext dbContext)
            : base(baseService)
        {
            this._dbContext = dbContext;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var userId = User.GetUserId();

            var userProfile = _dbContext.UserProfiles
                .Include(up => up.ApplicationUserProfiles)
                .Where(up => up.IsActiveProfile == true)
                .FirstOrDefault(up => up.ApplicationUserProfiles
                .Any(a => a.ApplicationUserId.ToString() == userId));

            if (userProfile == null)
            {
                return RedirectToAction(nameof(Create));
            }

            var viewModel = new UserProfileViewModel
            {
                Id = userProfile.Id,
                FirstName = userProfile.FirstName,
                LastName = userProfile.LastName,
                Age = userProfile.Age,
                Height = userProfile.Height,
                StartingWeight = userProfile.StartingWeight,
                Gender = userProfile.Gender.ToString(),
            };

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreateUserProfileFormModel());
        }

        [HttpPost]
        public IActionResult Create(CreateUserProfileFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var userId = User.GetUserId();

            var userProfile = new UserProfile
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Age = model.Age,
                Height = model.Height,
                StartingWeight = model.StartingWeight,
                Gender = Enum.Parse<Gender>(model.Gender),
                CreatedOn = DateTime.UtcNow,
                IsActiveProfile = true
            };

            var applicationUserProfile = new ApplicationUserProfile
            {
                ApplicationUserId = new Guid(userId!),
                UserProfile = userProfile
            };

            _dbContext.ApplicationUserProfiles.Add(applicationUserProfile);
            _dbContext.UserProfiles.Add(userProfile);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
