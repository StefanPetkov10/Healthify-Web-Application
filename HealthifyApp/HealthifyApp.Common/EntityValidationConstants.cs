namespace HealthifyApp.Common
{
    public class EntityValidationConstants
    {
        public static class UserProfile
        {
            public const byte FirstNameMinLength = 2;
            public const byte FirstNameMaxLength = 57;

            public const byte LastNameMinLength = 2;
            public const byte LastNameMaxLength = 57;

            public const byte AgeMinValue = 10;
            public const byte AgeMaxValue = 117;

            public const byte HeightMinValue = 50;
            public const byte HeightMaxValue = 254;

            public const byte WeightMinValue = 30;
            public const short WeightMaxValue = 300;

            public const byte GoalsMinLength = 10;
            public const byte GoalsMaxLength = 254;

            public const string JoinDateTimeFormat = "dd-MM-yyyy";
        }

        public static class Workout
        {
            public const byte NameMinLength = 2;
            public const byte NameMaxLength = 50;

            public const byte DescriptionMinLength = 10;
            public const short DescriptionMaxLength = 1000;

            public const byte DurationMinValue = 5;
            public const byte DurationMaxValue = 240;

            public const string ScheduleDateTimeFormat = "dd-MM-yyyy HH:mm";
        }

        public static class Exercise
        {
            public const byte NameMinLength = 2;
            public const byte NameMaxLength = 50;

            public const byte DescriptionMinLength = 10;
            public const byte DescriptionMaxLength = 254;

            public const byte DurationMinValue = 1;
            public const byte DurationMaxValue = 240;
        }

        public static class WorkoutExercise
        {
            public const byte SetsMinValue = 1;
            public const byte SetsMaxValue = 10;

            public const byte RepsMinValue = 1;
            public const byte RepsMaxValue = 25;
        }


    }
}
