namespace HealthifyApp.Common
{
    public static class EntityValidationRequiredMessages
    {
        public static class UserProfile
        {
            public const string FirstNameRequiredMessage = "The first name is required!";
            public const string LastNameRequiredMessage = "The last name is required!";
            public const string AgeRequiredMessage = "The age is required!";
            public const string HeightRequiredMessage = "The height is required!";
            public const string StartingWeightRequiredMessage = "The starting weight is required!";
            public const string GenderRequiredMessage = "The {0} is required.";
        }

        public static class Goal
        {
            public const string GoalStartDateRequiredMessage = "The goal start date is required!";
            public const string GoalTypeRequiredMessage = "The goal type is required!";
            public const string GoalActivityRequiredMessage = "The activity is required!";
            public const string GoalWeightRequiredMessage = "The goal weight is required!";
        }

        public static class ProgressLog
        {
            public const string ProgressLogDateRequiredMessage = "The progress log date is required!";
            public const string ProgressLogWeightRequiredMessage = "The progress log weight is required!";
        }

        public static class NutritionIntake
        {
            public const string NutritionIntakeDateRequiredMessage = "The nutrition intake date is required!";
            public const string NutritionIntakeCaloriesRequiredMessage = "The calories intake is required!";
            public const string NutritionIntakeProteinRequiredMessage = "The protein intake is required!";
            public const string NutritionIntakeCarbohydratesRequiredMessage = "The carbohydrates intake is required!";
            public const string NutritionIntakeFatsRequiredMessage = "The fats intake is required!";
        }

        public static class WaterIntake
        {
            public const string WaterIntakeWeightRequiredMessage = "The weight is required!";
            public const string WaterIntakeActivityRequiredMessage = "The activity is required!";
        }

        public static class BMICalculation
        {
            public const string WeightRequiredMessage = "The weight is required!";
            public const string HeightRequiredMessage = "The height is required!";
        }
    }
}
