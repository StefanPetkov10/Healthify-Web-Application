using HealthifyApp.Web.ViewModels.ProgressLog;

namespace HealthifyApp.Service.Data.Interfaces
{
    public interface IProgressLogService
    {
        Task<IndexProgressLogViewModel> IndexGetProgressLogAsync(Guid userId);

        Task<AddProgressLogFormModel?> AddProgressLogAsync();

        Task<bool> AddProgressLogAsync(AddProgressLogFormModel inputModel, Guid userId);
    }
}
