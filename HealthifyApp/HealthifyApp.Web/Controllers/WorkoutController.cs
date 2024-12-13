using HealthifyApp.Service.Data.Interfaces;
using HealthifyApp.Services.Data.Interfaces;
using HealthifyApp.Web.Infrastructure.Extensions;
using HealthifyApp.Web.ViewModels.Workout;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using static HealthifyApp.Common.ErrorMessages.Workout;

namespace HealthifyApp.Web.Controllers
{
    [Authorize(Roles = "UserRole")]

    public class WorkoutController : BaseController
    {
        private readonly IWorkoutService workoutService;
        public WorkoutController(IWorkoutService workoutService, IBaseService baseService)
            : base(baseService)
        {
            this.workoutService = workoutService;
        }

        [HttpGet]
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
        public async Task<IActionResult> Create()
        {
            return View(new CreateWorkoutFormModel());
        }

        [HttpPost]
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

        [HttpGet]
        public async Task<IActionResult> Update(string? id)
        {
            if (!IsGuidValid(id, out Guid parsedGuidId))
            {
                return RedirectToAction(nameof(Index));
            }

            var viewModel = await this.workoutService.GetUpdateWorkoutFormModelAsync(parsedGuidId);

            if (viewModel == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateWorkoutFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }

            var userId = User.GetUserId();

            bool result = await this.workoutService.UpdateWorkoutAsync(model, new Guid(userId!));
            if (!result)
            {
                TempData["ErrorMessage"] = WorkoutUpdateError;
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(string? id)
        {
            if (!IsGuidValid(id, out Guid parsedGuidId))
            {
                return RedirectToAction(nameof(Index));
            }

            var viewModel = await this.workoutService.GetDeleteWorkoutViewModelAsync(parsedGuidId);

            if (viewModel == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(DeleteWorkoutViewModel model)
        {
            bool result = await this.workoutService.DeleteWorkoutAsync(Guid.Parse(model.Id));

            if (!result)
            {
                TempData["ErrorMessage"] = WorkoutDeleteError;
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
