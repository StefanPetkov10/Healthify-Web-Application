namespace HealthifyApp.Web.ViewModels.ProgressLog
{
    public class IndexProgressLogViewModel
    {

        public IndexProgressLogViewModel()
        {
            this.ProgressLogs = new HashSet<ProgressLogListViewModel>();
        }

        public string Id { get; set; } = null!;

        public float GoalWeight { get; set; }

        public IEnumerable<ProgressLogListViewModel> ProgressLogs { get; set; }
    }
}
