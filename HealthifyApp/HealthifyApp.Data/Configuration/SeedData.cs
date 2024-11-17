using HealthifyApp.Data.Models;
using HealthifyApp.Data.Models.Enums;
using Microsoft.AspNetCore.Identity;

namespace HealthifyApp.Data.Configuration
{
    public class SeedData
    {
        public ApplicationUser User1 { get; set; }
        public ApplicationUser User2 { get; set; }
        public UserProfile UserProfile1 { get; set; }
        public UserProfile UserProfile2 { get; set; }
        public BMICalculation BMICalculation1 { get; set; }
        public BMICalculation BMICalculation2 { get; set; }
        public TargetNutrition TargetNutrition1 { get; set; }
        public TargetNutrition TargetNutrition2 { get; set; }
        public NutritionIntake NutritionIntake1 { get; set; }
        public NutritionIntake NutritionIntake2 { get; set; }
        public Goal Goal1 { get; set; }
        public Goal Goal2 { get; set; }
        public ProgressLog ProgressLog1 { get; set; }
        public ProgressLog ProgressLog2 { get; set; }
        public WaterIntake WaterIntake1 { get; set; }
        public WaterIntake WaterIntake2 { get; set; }
        public Workout Workout1 { get; set; }
        public Workout Workout2 { get; set; }
        public Exercise Exercise1 { get; set; }
        public Exercise Exercise2 { get; set; }
        public WorkoutExercise WorkoutExercise1 { get; set; }
        public WorkoutExercise WorkoutExercise2 { get; set; }

        public SeedData()
        {
            SeedUsersAndProfiles();
            SeedBMICalculations();
            SeedTargetNutrition();
            SeedNutritionIntakes();
            SeedGoals();
            SeedProgressLogs();
            SeedWaterIntake();
            SeedWorkouts();
            SeedExercises();
            SeedWorkoutExercises();
        }

        private void SeedUsersAndProfiles()
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            User1 = new ApplicationUser()
            {
                UserName = "User1",
                NormalizedUserName = "USER1",
                Email = "user1@example.com",
                NormalizedEmail = "USER1@EXAMPLE.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),

            };
            User1.PasswordHash = hasher.HashPassword(User1, "user1");

            User2 = new ApplicationUser()
            {
                UserName = "User2",
                NormalizedUserName = "USER2",
                Email = "user2@example.com",
                NormalizedEmail = "USER2@EXAMPLE.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),

            };
            User2.PasswordHash = hasher.HashPassword(User2, "user2!");

            UserProfile1 = new UserProfile()
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 30,
                Height = 180,
                StartingWeight = 80,
                Gender = Gender.Male,
                Goals = "Lose weight",
                CreatedOn = DateTime.Now
            };

            UserProfile2 = new UserProfile()
            {
                FirstName = "Jane",
                LastName = "Smith",
                Age = 25,
                Height = 165,
                StartingWeight = 60,
                Gender = Gender.Female,
                Goals = "Gain muscle",
                CreatedOn = DateTime.Now
            };
        }

        private void SeedBMICalculations()
        {
            BMICalculation1 = new BMICalculation()
            {

                UserProfileId = UserProfile1.Id,
                Date = DateTime.Now,
                Height = 180,
                Weight = 80,
                BMI = 24.7f,
                Category = BMICategory.NormalWeight
            };

            BMICalculation2 = new BMICalculation()
            {
                UserProfileId = UserProfile2.Id,
                Date = DateTime.Now,
                Height = 165,
                Weight = 60.6f,
                BMI = 22.0f,
                Category = BMICategory.NormalWeight
            };
        }

        private void SeedTargetNutrition()
        {
            TargetNutrition1 = new TargetNutrition()
            {
                UserProfileId = UserProfile1.Id,
                GoalName = "Lose weight",
                TargetCalories = 2000,
                TargetProtein = 150,
                TargetCarbohydrates = 100,
                TargetFats = 50
            };

            TargetNutrition2 = new TargetNutrition()
            {
                UserProfileId = UserProfile2.Id,
                GoalName = "Gain muscle",
                TargetCalories = 2500,
                TargetProtein = 200,
                TargetCarbohydrates = 200,
                TargetFats = 60
            };
        }

        private void SeedNutritionIntakes()
        {
            NutritionIntake1 = new NutritionIntake()
            {
                UserProfileId = UserProfile1.Id,
                Date = DateTime.Today.AddDays(1),
                Calories = 1800,
                Protein = 140,
                Carbohydrates = 90,
                Fats = 45
            };

            NutritionIntake2 = new NutritionIntake()
            {
                UserProfileId = UserProfile2.Id,
                Date = DateTime.Today.AddDays(1),
                Calories = 2600,
                Protein = 210,
                Carbohydrates = 220,
                Fats = 63
            };
        }

        private void SeedGoals()
        {
            Goal1 = new Goal()
            {
                UserProfileId = UserProfile1.Id,
                StartDate = DateTime.Today,
                GoalType = Goals.LoseWeight,
                Activity = Activity.ModeratelyActive,
                GoalWeight = 75.0f,
                GoalWaist = 85.0f,
                GoalChest = 95.0f
            };

            Goal2 = new Goal()
            {
                UserProfileId = UserProfile2.Id,
                StartDate = DateTime.Today,
                GoalType = Goals.GainWeight,
                Activity = Activity.VeryActive,
                GoalWeight = 67.0f,
                GoalHips = 97.0f
            };
        }

        private void SeedProgressLogs()
        {
            ProgressLog1 = new ProgressLog()
            {
                UserProfileId = UserProfile1.Id,
                Date = DateTime.Today.AddDays(1),
                CurrentWeight = 79.5f,
                Waist = 90.0f,
                Chest = 100.0f
            };

            ProgressLog2 = new ProgressLog()
            {
                UserProfileId = UserProfile2.Id,
                Date = DateTime.Today.AddDays(1),
                CurrentWeight = 60.5f,
                Hips = 95.0f
            };
        }

        private void SeedWaterIntake()
        {
            WaterIntake1 = new WaterIntake()
            {
                UserProfileId = UserProfile1.Id,
                Date = DateTime.Today,
                DailyGoal = 2.5f,
                Consumed = 2.0f
            };

            WaterIntake2 = new WaterIntake()
            {
                UserProfileId = UserProfile2.Id,
                Date = DateTime.Today,
                DailyGoal = 3.0f,
                Consumed = 2.8f
            };
        }

        private void SeedWorkouts()
        {

            Workout2 = new Workout()
            {
                UserProfileId = UserProfile1.Id,
                Name = "Evening Cardio",
                Description = "High-intensity cardio for fat burn.",
                ScheduleDateTime = DateTime.Now.AddHours(3),
                Duration = 45
            };

            Workout1 = new Workout()
            {
                UserProfileId = UserProfile2.Id,
                Name = "Morning Strength",
                Description = "A full-body workout to start the day.",
                ScheduleDateTime = DateTime.Now.AddHours(1),
                Duration = 60
            };
        }

        private void SeedExercises()
        {
            Exercise1 = new Exercise()
            {
                Name = "Push-Up",
                Description = "A bodyweight exercise for upper body strength.",
                Duration = 30,
                ImageUrl = "https://anabolicaliens.com/cdn/shop/articles/199990_400x.png?v=1645089103"
            };

            Exercise2 = new Exercise()
            {
                Name = "Squat",
                Description = "A lower body exercise for strength and endurance.",
                Duration = 40,
                ImageUrl = "https://weighttraining.guide/wp-content/uploads/2016/10/barbell-squat-resized-FIXED-2.png"
            };
        }

        public void SeedWorkoutExercises()
        {
            WorkoutExercise1 = new WorkoutExercise()
            {
                WorkoutId = Workout1.Id,
                ExerciseId = Exercise1.Id,
                Sets = 3,
                Reps = 10
            };

            WorkoutExercise2 = new WorkoutExercise()
            {
                WorkoutId = Workout2.Id,
                ExerciseId = Exercise2.Id,
                Sets = 4,
                Reps = 15
            };
        }
    }
}
