using HealthifyApp.Data.Models;
using HealthifyApp.Data.Models.Enums;
using HealthifyApp.Data.Repository.Interfaces;
using HealthifyApp.Service.Data.Interfaces;
using HealthifyApp.Services.Data;
using HealthifyApp.Services.Mapping;
using HealthifyApp.Web.ViewModels.UserProfile;
using Microsoft.EntityFrameworkCore;

namespace Healthify.Service.Data
{
    public class UserProfileService : BaseService, IUserProfileService
    {
        private readonly IRepository<UserProfile, Guid> userProfileRepository;
        private readonly IRepository<ApplicationUserProfile, object> applicationUserProfileRepository;

        public UserProfileService(IRepository<UserProfile, Guid> userProfileRepository,
                                        IRepository<ApplicationUserProfile, object> applicationUserProfile)
            : base(userProfileRepository)
        {
            this.userProfileRepository = userProfileRepository;
            this.applicationUserProfileRepository = applicationUserProfile;
        }

        public async Task<UserProfileViewModel?> IndexGetUserProfileAsync(Guid userId)
        {
            UserProfile userProfile = await GetUserProfileAsync(userId);

            //    userProfileRepository.FirstOrDefaultAsync(up =>
            //up.IsActiveProfile == true &&
            //up.ApplicationUserProfiles.Any(a => a.ApplicationUserId.ToString() == userId.ToString()));

            if (userProfile == null)
            {
                return null;
            }

            var viewModel = await userProfileRepository
                .GetAllAttached()
                .Where(up => up.Id == userProfile.Id)
                .To<UserProfileViewModel>()
                .FirstOrDefaultAsync();

            //var viewModel = new UserProfileViewModel
            //{
            //    Id = userProfile.Id,
            //    FirstName = userProfile.FirstName,
            //    LastName = userProfile.LastName,
            //    Age = userProfile.Age,
            //    Height = userProfile.Height,
            //    StartingWeight = userProfile.StartingWeight,
            //    Gender = userProfile.Gender.ToString()
            //};

            if (viewModel == null)
            {
                return null;
            }

            return viewModel;
        }

        public async Task<bool> CreateUserProfileAsync(CreateUserProfileFormModel formModel, Guid userId)
        {

            UserProfile userProfile = new UserProfile();

            AutoMapperConfig.MapperInstance.Map(formModel, userProfile);
            userProfile.Gender = Enum.Parse<Gender>(formModel.Gender);
            userProfile.CreatedOn = DateTime.UtcNow;
            userProfile.IsActiveProfile = true;



            var applicationUserProfile = new ApplicationUserProfile
            {
                ApplicationUserId = userId,
                UserProfile = userProfile
            };

            await userProfileRepository.AddAsync(userProfile);
            await applicationUserProfileRepository.AddAsync(applicationUserProfile);

            return true;
        }

        public async Task<EditUserProfileFormModel?> GetEditUserProfileAsync(Guid userId)
        {
            EditUserProfileFormModel? editUserProfileFormModel = await userProfileRepository
                .GetAllAttached()
                .Where(up => up.IsActiveProfile == true)
                .To<EditUserProfileFormModel>()
                .FirstOrDefaultAsync(up => up.Id.ToLower() == userId.ToString().ToLower());

            return editUserProfileFormModel;
        }

        public async Task<bool> EditUserProfileAsync(EditUserProfileFormModel formModel)
        {


            Guid userProfileGuid = Guid.Empty;
            if (!this.IsGuidIdValid(formModel.Id, ref userProfileGuid))
            {
                return false;
            }

            UserProfile userProfile = await userProfileRepository.GetByIdAsync(userProfileGuid);
            if (userProfile == null)
            {
                return false;
            }

            var originalCreatedOn = userProfile.CreatedOn;

            // Update the existing entity instead of creating a new one
            userProfile = AutoMapperConfig.MapperInstance.Map(formModel, userProfile);
            userProfile.CreatedOn = originalCreatedOn;
            userProfile.IsActiveProfile = true;
            userProfile.Gender = Enum.Parse<Gender>(formModel.Gender);

            return await userProfileRepository.UpdateAsync(userProfile);
        }
        public async Task<DeleteUserProfileViewModel?> GetUserProfileForDeleteByIdAsync(Guid id)
        {
            DeleteUserProfileViewModel? deleteUserProfileViewModel = await userProfileRepository
                .GetAllAttached()
                .Where(up => up.IsActiveProfile == true)
                .To<DeleteUserProfileViewModel>()
                .FirstOrDefaultAsync(up => up.Id.ToLower() == id.ToString().ToLower());

            return deleteUserProfileViewModel;
        }

        public async Task<bool> SoftDeleteUserProfileAsync(Guid userId)
        {
            UserProfile userProfile = await userProfileRepository
                .FirstOrDefaultAsync(up => up.Id == userId);

            if (userProfile == null)
            {
                return false;
            }

            userProfile.IsActiveProfile = false;
            return await userProfileRepository.UpdateAsync(userProfile);
        }
    }
}
