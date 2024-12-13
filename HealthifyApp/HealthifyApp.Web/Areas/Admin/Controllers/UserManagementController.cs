using HealthifyApp.Service.Data.Interfaces;
using HealthifyApp.Services.Data.Interfaces;
using HealthifyApp.Web.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HealthifyApp.Web.Areas.Admin.Controllers
{
    [Area("AdminRole")]
    [Authorize(Roles = "AdminRole")]
    public class UserManagementController : BaseController
    {
        private readonly IUserProfileService userProfileService;
        public UserManagementController(IBaseService baseService,
                                           IUserProfileService userProfileService)
            : base(baseService)
        {
            this.userProfileService = userProfileService;
        }
    }
}
