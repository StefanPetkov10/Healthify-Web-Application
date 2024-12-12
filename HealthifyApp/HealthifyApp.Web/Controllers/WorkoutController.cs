using HealthifyApp.Service.Data.Interfaces;
using HealthifyApp.Services.Data.Interfaces;
using HealthifyApp.Web.Infrastructure.Extensions;
using HealthifyApp.Web.ViewModels.Workout;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using static HealthifyApp.Common.ErrorMessages.Workout;

namespace HealthifyApp.Web.Controllers
{
    public class WorkoutController : BaseController
    {
        private readonly IWorkoutService workoutService;
        public WorkoutController(IWorkoutService workoutService, IBaseService baseService)
            : base(baseService)
        {
            this.workoutService = workoutService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var userId = User.GetUserId();
            var viewModel = await this.workoutService.IndexGetWorkoutAsync(new Guid(userId!));

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
            return View(new CreateWorkoutFormModel());
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CreateWorkoutFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var userId = User.GetUserId();

            bool result = await this.workoutService.CreateWorkoutAsync(model, new Guid(userId!));

            if (!result)
            {
                TempData["ErrorMessage"] = WorkoutCantBeCreated;
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
