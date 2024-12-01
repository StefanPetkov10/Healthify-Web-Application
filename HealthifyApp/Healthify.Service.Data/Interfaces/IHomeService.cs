using HealthifyApp.Data.Models;

namespace Healthify.Service.Data.Interfaces
{
    public interface IHomeService
    {
        Task<UserProfile?> GetActiveUserProfileNameAsync(string userName);

        Task<bool>(HomeIndexViewModel formModel);
    }
}
