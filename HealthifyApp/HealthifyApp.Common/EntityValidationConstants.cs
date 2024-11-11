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

        public static class Workout
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 50;

            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 1000;

            public const int DurationMinValue = 5;
            public const int DurationMaxValue = 180;

            public const string ScheduleDateTimeFormat = "dd-MM-yyyy HH:mm";
        }

        public static class Exercise
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 50;

            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 250;

            public const int DurationMinValue = 1;
            public const int DurationMaxValue = 180;
        }

        public static class WorkoutExercise
        {
            public const int SetsMinValue = 1;
            public const int SetsMaxValue = 10;

            public const int RepsMinValue = 1;
            public const int RepsMaxValue = 25;
        }
    }
}
