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

    }
}
