using HealthifyApp.Service.Data.Interfaces;
using HealthifyApp.Services.Data.Interfaces;
using HealthifyApp.Web.Infrastructure.Extensions;
using HealthifyApp.Web.ViewModels.ProgressLog;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static HealthifyApp.Common.ErrorMessages.ProgressLog;


namespace HealthifyApp.Web.Controllers
{
    public class ProgressLogController : BaseController
    {
        private readonly IProgressLogService progressLogService;

        public ProgressLogController(IBaseService baseService, IProgressLogService progressLogService)
            : base(baseService)
        {
            this.progressLogService = progressLogService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var userId = User.GetUserId();

            var viewModel = await this.progressLogService.IndexGetProgressLogAsync(new Guid(userId!));

            if (viewModel == null)
            {
                TempData["ErrorMessage"] = ProgressLogNotContainGoal;
                return RedirectToAction("Index", "Goal");
            }

            return View(viewModel);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> AddProgress(string progressLogId)
        {
            AddProgressLogFormModel? formModel = new AddProgressLogFormModel();

            formModel = await this.progressLogService.AddProgressLogAsync();

            if (formModel == null)
            {
                TempData["ErrorMessage"] = ProgressLogAlreadyExist;
                return RedirectToAction(nameof(Index));
            }

            return View(formModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddProgress(AddProgressLogFormModel formModel)
        {
            if (!ModelState.IsValid)
            {
                return View(formModel);
            }

            var userId = User.GetUserId();

            var viewModel = await this.progressLogService.AddProgressLogAsync(formModel, new Guid(userId!));

            if (viewModel == false)
            {
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
