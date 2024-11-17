namespace HealthifyApp.Web.ViewModels.Home
{
    public class HomeIndexViewModel
    {
        public string LastWorkout { get; set; } = null!;
        public string CurrentWeight { get; set; } = null!;
        public string GoalWeight { get; set; } = null!;
        public string WaterIntakeStatus { get; set; } = null!;
        public string CalorieStatus { get; set; } = null!;
    }
}
