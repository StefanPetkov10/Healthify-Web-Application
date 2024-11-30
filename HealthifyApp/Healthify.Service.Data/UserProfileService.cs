using Healthify.Service.Data.Interfaces;
using HealthifyApp.Data.Models;
using HealthifyApp.Data.Repository.Interfaces;
using HealthifyApp.Web.ViewModels.UserProfile;

namespace Healthify.Service.Data
{
    public class UserProfileService : IUserProfileService
    {
        private readonly IRepository<UserProfile, Guid> userProfileRepository;

        public UserProfileService(IRepository<UserProfile, Guid> userProfileRepository)
        {
            this.userProfileRepository = userProfileRepository;
        }

        public async Task<UserProfileViewModel?> GetUserProfile(Guid userId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> CreateUserProfile(CreateUserProfileFormModel model, Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
