using HealthifyApp.Web.ViewModels.ProgressLog;

namespace HealthifyApp.Service.Data.Interfaces
{
    public interface IProgressLogService
    {
        Task<IndexProgressLogViewModel> IndexGetProgressLogAsync(Guid userId);

        Task<bool> AddProgressLogAsync(AddProgressLogFormModel formModel, Guid userId);
    }
}
