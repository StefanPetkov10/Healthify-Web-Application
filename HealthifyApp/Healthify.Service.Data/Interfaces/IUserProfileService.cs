using HealthifyApp.Web.ViewModels.UserProfile;

namespace HealthifyApp.Service.Data.Interfaces
{
    public interface IUserProfileService
    {
        Task<UserProfileViewModel?> IndexGetUserProfileAsync(Guid userId);

        Task<bool> CreateUserProfileAsync(CreateUserProfileFormModel model, Guid userId);

        Task<EditUserProfileFormModel?> GetEditUserProfileAsync(Guid userId);

        Task<bool> EditUserProfileAsync(EditUserProfileFormModel model);

        Task<DeleteUserProfileViewModel?> GetUserProfileForDeleteByIdAsync(Guid id);

        Task<bool> SoftDeleteUserProfileAsync(Guid userId);
    }
}
