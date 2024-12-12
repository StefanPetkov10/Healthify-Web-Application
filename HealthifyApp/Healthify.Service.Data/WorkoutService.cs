using System.Globalization;
using HealthifyApp.Data.Models;
using HealthifyApp.Data.Repository.Interfaces;
using HealthifyApp.Service.Data.Interfaces;
using HealthifyApp.Services.Data;
using HealthifyApp.Services.Mapping;
using HealthifyApp.Web.ViewModels.Workout;
using Microsoft.EntityFrameworkCore;

namespace HealthifyApp.Service.Data
{
    public class WorkoutService : BaseService, IWorkoutService
    {
        private readonly IRepository<Workout, Guid> workoutRepository;

        public WorkoutService(IRepository<Workout, Guid> workoutRepository,
                                IRepository<UserProfile, Guid> userProfileRepository)
            : base(userProfileRepository)
        {
            this.workoutRepository = workoutRepository;
        }


        public async Task<IEnumerable<WorkoutViewModel?>> IndexGetWorkoutAsync(Guid userId)
        {
            UserProfile userProfile = await GetUserProfileAsync(userId);

            if (userProfile == null || userProfile.IsActiveProfile == false)
            {
                return null;
            }

            return await workoutRepository
                .GetAllAttached()
                .Where(w => w.UserProfileId == userProfile.Id)
                .To<WorkoutViewModel>()
                .ToArrayAsync();
        }

        public async Task<bool> CreateWorkoutAsync(CreateWorkoutFormModel model, Guid userId)
        {
            UserProfile userProfile = await GetUserProfileAsync(userId);

            if (userProfile == null || userProfile.IsActiveProfile == false)
            {
                return false;
            }

            bool isScheduledDate = DateTime.TryParseExact(model.ScheduleDateTime, "yyyy-MM-ddTHH:mm",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime scheduledDate);


            if (!isScheduledDate)
            {
                return false;
            }

            Workout workout = new();
            AutoMapperConfig.MapperInstance.Map(model, workout);
            workout.ScheduleDateTime = scheduledDate;
            workout.UserProfileId = userProfile.Id;

            await workoutRepository.AddAsync(workout);

            return true;
        }

        public async Task<UpdateWorkoutFormModel?> GetUpdateWorkoutFormModelAsync(Guid workoutId)
        {
            return await workoutRepository
                .GetAllAttached()
                .Where(w => w.Id == workoutId)
                .To<UpdateWorkoutFormModel>()
                .FirstOrDefaultAsync();
        }

        public async Task<bool> UpdateWorkoutAsync(UpdateWorkoutFormModel model, Guid userId)
        {
            UserProfile userProfile = await GetUserProfileAsync(userId);

            if (userProfile == null || userProfile.IsActiveProfile == false)
            {
                return false;
            }

            bool isScheduledDate = DateTime.TryParseExact(model.ScheduleDateTime, "yyyy-MM-ddTHH:mm",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime scheduledDate);

            if (!isScheduledDate)
            {
                return false;
            }

            Workout workout = await workoutRepository.GetByIdAsync(Guid.Parse(model.Id));

            if (workout == null)
            {
                return false;
            }

            AutoMapperConfig.MapperInstance.Map(model, workout);
            workout.ScheduleDateTime = scheduledDate;
            workout.UserProfileId = userProfile.Id;

            await workoutRepository.UpdateAsync(workout);

            return true;
        }
    }
}
