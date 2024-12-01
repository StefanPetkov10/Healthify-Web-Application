using HealthifyApp.Web.ViewModels.Home;

namespace Healthify.Service.Data.Interfaces
{
    public interface IHomeService
    {
        Task<HomeIndexViewModel> GetHomeIndexViewModelAsync(string userName);
    }
}
