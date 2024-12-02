using HealthifyApp.Services.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HealthifyApp.Web.Controllers
{
    public class BaseController : Controller
    {
        private readonly IBaseService _baseService;

        public BaseController(IBaseService baseService)
        {
            this._baseService = baseService;
        }

        protected bool IsGuidValid(string? id, out Guid parsedGuidId)
        {
            parsedGuidId = Guid.Empty;
            return _baseService.IsGuidIdValid(id, ref parsedGuidId);
        }
    }
}
