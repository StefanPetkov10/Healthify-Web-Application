namespace HealthifyApp.Common
{
    public static class ErrorMessages
    {
        public static class UserProfile
        {
            public const string UserProfileNotFound = "User Profile not found!";
            public const string UserProfileCreateError = "Unexpected error occurred while creating the Profile! Please contact administrator";
            public const string UserProfileUpdateError = "Unexpected error occurred while updating the Profile! Please contact administrator";
            public const string UserProfileDeleteError = "Unexpected error occurred while deleting the Profile! Please contact administrator";
        }

        public static class Goal
        {
            public const string GoalNotFound = "Goal not found!";
            public const string GoalDeleteError = "Unexpected error occurred while trying to delete the goal(maybe a Target also)! " +
                "Please contact system administrator!";
        }

        public static class TargetNutrition
        {
            public const string TargetNutritionAlreadyExist = "Already has a target nutrition";
            public const string TargetNutritionDeleteError = "Unexpected error occurred while trying to delete the goal(maybe a Target also)!" +
                " Please contact system administrator!";
        }

        public static class ProgressLog
        {
            public const string ProgressLogNotContainGoal = "You don't have a set goal";
            public const string ProgressLogAlreadyExist = "You already log progress for this day";
        }

        public static class NutritionIntake
        {
            public const string NutritionIntakeNotFound = "Nutrition Intake not found!";
            public const string NutritionIntakeAlreadyExist = "You already log nutrition intake for this day";
        }

        public static class WaterIntake
        {
            public const string WaterIntakeUpdateFailed = "Failed to update water intake. Please try again.";
        }

        public static class BMI
        {
            public const string BMICalculationFailed = "Failed to calculate BMI. Please try again.";
        }

        public static class Workout
        {
            public const string WorkoutCantBeCreated = "Workout can't be created!";
            public const string WorkoutNotFound = "Workout not found!";
            public const string WorkoutDeleteError = "Unexpected error occurred while trying to delete the workout! Please contact system administrator!";
        }
    }
}
