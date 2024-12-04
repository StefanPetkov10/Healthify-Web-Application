using HealthifyApp.Data.Models;

namespace HealthifyApp.Services.Data.Interfaces
{
    public interface IBaseService
    {
        bool IsGuidIdValid(string? id, ref Guid parsedGuidId);

        Task<UserProfile> GetUserProfileAsync(Guid userId);

        Task<bool> IsUserProfileValid(string? userId);
    }
}
