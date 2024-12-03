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
    }
}
