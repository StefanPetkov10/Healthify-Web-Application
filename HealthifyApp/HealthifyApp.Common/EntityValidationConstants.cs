namespace HealthifyApp.Common
{
    public class EntityValidationConstants
    {
        public static class UserProfile
        {
            public const int FirstNameMinLength = 2;
            public const int FirstNameMaxLength = 57;

            public const int LastNameMinLength = 2;
            public const int LastNameMaxLength = 57;

            public const int AgeMinValue = 10;
            public const int AgeMaxValue = 117;

            public const float HeightMinValue = 0.5F;
            public const float HeightMaxValue = 2.5F;

            public const int WeightMinValue = 30;
            public const int WeightMaxValue = 300;

            public const int GoalsMinLength = 10;
            public const int GoalsMaxLength = 250;

            public const string JoinDateTimeFormat = "dd-MM-yyyy";
        }
    }
}
