using HealthifyApp.Services.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HealthifyApp.Web.Controllers
{
    public class WaterIntakeController : BaseController
    {
        public WaterIntakeController(IBaseService baseService)
            : base(baseService)
        {
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
