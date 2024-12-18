﻿using HealthifyApp.Data.Models;
using HealthifyApp.Web.ViewModels.Goal;

namespace HealthifyApp.Service.Data.Interfaces
{
    public interface IGoalService
    {
        Task<IEnumerable<GoalListViewModel?>> IndexGetGoalAsync(Guid userId);

        Task<bool> CreateGoalAsync(CreateGoalFormModel inputModel, Guid userId);

        Task<GoalDetailsViewModel?> GetGoalDetailsByIdAsync(Guid id);

        Task<DeleteGoalViewModel?> DeleteGoalAsync(Guid id);

        Task<bool> DeletePermanentlyGoalAsync(Guid id);

        Task<Goal> GetGoalByIdAsync(Guid id);
    }
}
