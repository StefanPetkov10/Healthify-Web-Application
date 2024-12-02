
using Healthify.Service.Data.Interfaces;
using HealthifyApp.Services.Data.Interfaces;
using HealthifyApp.Web.Infrastructure.Extensions;
using HealthifyApp.Web.ViewModels.Goal;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HealthifyApp.Web.Controllers
{
    public class GoalController : BaseController
    {
        private readonly IGoalService goalService;

        public GoalController(IGoalService goalService, IBaseService baseService)
            : base(baseService)
        {
            this.goalService = goalService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var userId = User.GetUserId();

            var viewModel = await this.goalService.GetGoalAsync(new Guid(userId!));

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
            return View(new CreateGoalFormModel());
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CreateGoalFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var userId = User.GetUserId();

            await this.goalService.CreateGoalAsync(model);

            return RedirectToAction(nameof(Index));
        }
    }
}
