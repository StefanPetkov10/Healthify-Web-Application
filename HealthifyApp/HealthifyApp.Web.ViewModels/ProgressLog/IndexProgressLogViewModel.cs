namespace HealthifyApp.Web.ViewModels.ProgressLog
{
    public class IndexProgressLogViewModel
    {

        public IndexProgressLogViewModel()
        {
            this.ProgressLogs = new HashSet<ProgressLogListViewModel>();
        }

        public float GoalWeight { get; set; }

        public IEnumerable<ProgressLogListViewModel> ProgressLogs { get; set; }
    }
}
