namespace HealthifyApp.Web.ViewModels.NutritionIntake
{
    public class NutritionIntakeIndexViewModel
    {
        public int TargetCalories { get; set; }
        public int TargetProtein { get; set; }
        public int TargetCarbohydrates { get; set; }
        public int TargetFats { get; set; }

        public int CurrentCalories { get; set; }
        public int CurrentProtein { get; set; }
        public int CurrentCarbohydrates { get; set; }
        public int CurrentFats { get; set; }

        public int RemainingCalories => TargetCalories - CurrentCalories;
        public int RemainingProtein => TargetProtein - CurrentProtein;
        public int RemainingCarbohydrates => TargetCarbohydrates - CurrentCarbohydrates;
        public int RemainingFats => TargetFats - CurrentFats;
    }
}

