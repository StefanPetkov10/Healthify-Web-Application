namespace HealthifyApp.Web.ViewModels.BMI
{
    public class BMICalculationViewModel
    {
        public float BMI { get; set; }
        public string Category { get; set; } = null!;
        public string Message { get; set; } = null!;
    }
}
