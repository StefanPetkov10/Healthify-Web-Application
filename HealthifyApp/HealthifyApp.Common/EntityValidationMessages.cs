namespace HealthifyApp.Common
{
    public static class EntityValidationMessages
    {
        public static class UserProfile
        {
            public const string FirstNameLengthMessage = "The {0} must be at least {1} and at max {2} characters long.";
            public const string LastNameLengthMessage = "The {0} must be at least {1} and at max {2} characters long.";
            public const string AgeRangeMessage = "The {0} must be between {1} and {2}.";
            public const string HeightRangeMessage = "The {0} must be between {1} and {2}.";
            public const string WeightRangeMessage = "The {0} must be between {1} and {2}.";
            public const string GoalsLengthMessage = "The {0} must be at least {1} and at max {2} characters long.";
            public const string GenderRequiredMessage = "The {0} is required.";



        }
    }
}
