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

            public const string JoinDateTimeFormat = "dd-MM-yyyy";
        }

        public static class Goal
        {
            public const string StartDateTimeFormat = "dd-MM-yyyy";

            public const byte WeightMinValue = 30;
            public const short WeightMaxValue = 300;

            public const byte WaistMinValue = 30;
            public const byte WaistMaxValue = 254;

            public const byte HipsMinValue = 30;
            public const byte HipsMaxValue = 254;

            public const byte ChestMinValue = 40;
            public const byte ChestMaxValue = 254;
        }

        public static class TargetNutrition
        {
            public const byte TargetCaloriesMinValue = 100;
            public const short TargetCaloriesMaxValue = 20000;

            public const byte TargetProteinMinValue = 1;
            public const short TargetProteinMaxValue = 1300;

            public const byte TargetCarbohydratesMinValue = 1;
            public const short TargetCarbohydratesMaxValue = 2500;

            public const byte TargetFatsMinValue = 1;
            public const short TargetFatsMaxValue = 550;

            public const string StartDateTimeFormat = "dd-MM-yyyy";
        }

        public static class ProgressLog
        {
            public const byte CurrentWeightMinValue = 30;
            public const short CurrentWeightMaxValue = 300;

            public const byte WaistMinValue = 30;
            public const byte WaistMaxValue = 254;

            public const byte HipsMinValue = 30;
            public const byte HipsMaxValue = 254;

            public const byte ChestMinValue = 40;
            public const byte ChestMaxValue = 254;

            public const string DateInAddingProgress = "dd-MM-yyyy";
        }

        public static class NutritionIntake
        {
            public const byte CaloriesMinValue = 100;
            public const short CaloriesMaxValue = 20000;
            public const byte ProteinMinValue = 1;
            public const short ProteinMaxValue = 1300;
            public const byte CarbohydratesMinValue = 1;
            public const short CarbohydratesMaxValue = 2500;
            public const byte FatsMinValue = 1;
            public const short FatsMaxValue = 550;
            public const string DateInAddingProgress = "dd-MM-yyyy";
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

        public static class WaterIntake
        {
            public const byte WeightMinValue = 30;
            public const short WeightMaxValue = 300;
        }

    }
}
