using HealthifyApp.Web.ViewModels.Home;

namespace HealthifyApp.Service.Data.Interfaces
{
    public interface IHomeService
    {
        Task<HomeIndexViewModel> GetHomeIndexViewModelAsync(string userName);
    }
}
