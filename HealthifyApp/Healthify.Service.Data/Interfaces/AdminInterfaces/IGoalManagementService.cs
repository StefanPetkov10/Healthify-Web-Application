﻿using HealthifyApp.Web.ViewModels.Admin.Goal;

namespace HealthifyApp.Service.Data.Interfaces.AdminInterfaces
{
    public interface IGoalManagementService
    {
        public Task<IEnumerable<UserGoalsViewModel>> GetAllGoalsAsync();
    }
}
