﻿using System.Globalization;
using HealthifyApp.Data.Models;
using HealthifyApp.Data.Repository.Interfaces;
using HealthifyApp.Service.Data.Interfaces;
using HealthifyApp.Services.Data;
using HealthifyApp.Services.Mapping;
using HealthifyApp.Web.ViewModels.TargetNutrition;
using Microsoft.EntityFrameworkCore;
using static HealthifyApp.Common.EntityValidationConstants.TargetNutrition;

namespace Healthify.Service.Data
{
    public class TargetNutritionService : BaseService, ITargetNutritionService
    {
        private readonly IRepository<Goal, Guid> goalRepository;
        private readonly IRepository<TargetNutrition, Guid> targetNutritionRepository;
        public TargetNutritionService(IRepository<Goal, Guid> goalRepository,
                                        IRepository<TargetNutrition, Guid> targetNutritionRepository,
                                            IRepository<UserProfile, Guid> userProfileRepository)
            : base(userProfileRepository)
        {
            this.goalRepository = goalRepository;
            this.targetNutritionRepository = targetNutritionRepository;
        }
        public async Task<IEnumerable<TargetNutritionListViewModel>> IndexGetTargetNutritionAsync(Guid userId)
        {
            UserProfile userProfile = await GetUserProfileAsync(userId);

            if (userProfile == null || userProfile.IsActiveProfile == false)
            {
                return null;
            }

            return await this.targetNutritionRepository
                .GetAllAttached()
                .Where(i => i.UserProfileId == userProfile.Id)
                .To<TargetNutritionListViewModel>()
                .ToArrayAsync();
        }

        public async Task<CreateTargetNutritionFormModel> CreateTargetNutritionAsync(TargetNutrition calculatedNutrition, Guid goalId)
        {
            Goal goal = await goalRepository
                .GetByIdAsync(goalId);

            if (await targetNutritionRepository.FirstOrDefaultAsync(x => x.GoalId == goal.Id) != null)
            {
                return null;
            }
            else
            {
                CreateTargetNutritionFormModel viewModel = new CreateTargetNutritionFormModel
                {
                    GoalId = goal.Id.ToString(),
                    GoalName = goal.GoalType.ToString(),
                    StartDate = DateTime.Now.ToString(StartDateTimeFormat),
                    TargetCalories = calculatedNutrition.TargetCalories,
                    TargetProtein = calculatedNutrition.TargetProtein,
                    TargetCarbohydrates = calculatedNutrition.TargetCarbohydrates,
                    TargetFats = calculatedNutrition.TargetFats
                };
                return viewModel;
            }
        }

        public async Task<bool> CreateTargetNutritionAsync(CreateTargetNutritionFormModel inputModel, Guid userId)
        {
            UserProfile userProfile = await GetUserProfileAsync(userId);
            if (userProfile == null || userProfile.IsActiveProfile == false)
            {
                return false;
            }

            bool isStartDate = DateTime.TryParseExact(inputModel.StartDate, StartDateTimeFormat,
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime releaseDate);
            if (!isStartDate)
            {
                return false;
            }

            TargetNutrition targetNutrition = new TargetNutrition();
            AutoMapperConfig.MapperInstance.Map(inputModel, targetNutrition);
            targetNutrition.UserProfileId = userProfile.Id;
            targetNutrition.StartDate = releaseDate;

            await targetNutritionRepository.AddAsync(targetNutrition);

            return true;
        }

        public async Task<DeleteTargetNutritionViewModel?> DeleteTargetNutritionAsync(Guid id)
        {
            DeleteTargetNutritionViewModel? targetNutritionDelete = await targetNutritionRepository
                .GetAllAttached()
                .To<DeleteTargetNutritionViewModel>()
                .FirstOrDefaultAsync(tn => tn.Id.ToLower() == id.ToString().ToLower());

            return targetNutritionDelete;
        }

        public async Task<bool> DeletePermanentlyTargetNutritionAsync(Guid id)
        {
            TargetNutrition targetNutrition = await targetNutritionRepository
                .GetByIdAsync(id);

            if (targetNutrition != null)
            {
                targetNutritionRepository.Delete(targetNutrition);
            }

            return true;
        }
    }
}
