namespace HealthifyApp.Web.ViewModels.Admin.Goal
{
    public class UserGoalsViewModel
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public ICollection<GoalViewModel> Goals { get; set; } = new HashSet<GoalViewModel>();
    }
}
