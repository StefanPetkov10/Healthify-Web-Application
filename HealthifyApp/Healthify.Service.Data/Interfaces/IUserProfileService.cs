using HealthifyApp.Web.ViewModels.UserProfile;

namespace Healthify.Service.Data.Interfaces
{
    public interface IUserProfileService
    {
        Task<UserProfileViewModel?> GetUserProfile(Guid userId);

        Task<bool> CreateUserProfile(CreateUserProfileFormModel model, Guid userId);

        //Task<bool> UpdateUserProfile(UserProfileFormModel model, Guid userId);
    }
}
