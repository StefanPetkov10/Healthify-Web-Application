namespace HealthifyApp.Web.ViewModels.Admin.TargetNutrition
{
    public class UserTargetNutritionViewModel
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public ICollection<TargetNutritionViewModel> TargetNutrition { get; set; } = new HashSet<TargetNutritionViewModel>();
    }
}
