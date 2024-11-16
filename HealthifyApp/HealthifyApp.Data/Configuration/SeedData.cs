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
        public NutritionPlan NutritionPlan1 { get; set; }
        public NutritionPlan NutritionPlan2 { get; set; }
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
            SeedNutritionPlans();
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
                Weight = 80,
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
                Weight = 60,
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
                Category = "Normal weight"
            };

            BMICalculation2 = new BMICalculation()
            {
                UserProfileId = UserProfile2.Id,
                Date = DateTime.Now,
                Height = 165,
                Weight = 60.6f,
                BMI = 22.0f,
                Category = "Normal weight"
            };
        }

        private void SeedNutritionPlans()
        {
            NutritionPlan1 = new NutritionPlan()
            {
                UserProfileId = UserProfile1.Id,
                Goal = "Lose weight",
                Calories = 2000,
                Protein = 150,
                Carbohydrates = 100,
                Fats = 50
            };

            NutritionPlan2 = new NutritionPlan()
            {
                UserProfileId = UserProfile2.Id,
                Goal = "Gain muscle",
                Calories = 2500,
                Protein = 200,
                Carbohydrates = 200,
                Fats = 60
            };
        }

        private void SeedProgressLogs()
        {
            ProgressLog1 = new ProgressLog()
            {
                UserProfileId = UserProfile1.Id,
                Date = DateTime.Now,
                Weight = 79.5f,
                Waist = 90.0f,
                Chest = 100.0f
            };

            ProgressLog2 = new ProgressLog()
            {
                UserProfileId = UserProfile2.Id,
                Date = DateTime.Now,
                Weight = 60.5f,
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
            Workout1 = new Workout()
            {
                UserProfileId = UserProfile1.Id,
                Name = "Morning Strength",
                Description = "A full-body workout to start the day.",
                ScheduleDateTime = DateTime.Now.AddHours(1),
                Duration = 60
            };

            Workout2 = new Workout()
            {
                UserProfileId = UserProfile2.Id,
                Name = "Evening Cardio",
                Description = "High-intensity cardio for fat burn.",
                ScheduleDateTime = DateTime.Now.AddHours(3),
                Duration = 45
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
