using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthifyApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedStartDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationUserProfiles",
                keyColumns: new[] { "ApplicationUserId", "UserProfileId" },
                keyValues: new object[] { new Guid("26c70f6a-5f07-46a0-beb8-a21af9955a2d"), new Guid("395c5591-a0b8-4249-9d58-ee5e7ec171cf") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserProfiles",
                keyColumns: new[] { "ApplicationUserId", "UserProfileId" },
                keyValues: new object[] { new Guid("49813fcd-5b78-4cca-b5a2-8ee7a9006941"), new Guid("51d32863-946a-42af-8d5a-73621b1ee35e") });

            migrationBuilder.DeleteData(
                table: "BMICalculations",
                keyColumn: "Id",
                keyValue: new Guid("3b675970-24e3-4d5c-9d68-35e7afea32ae"));

            migrationBuilder.DeleteData(
                table: "BMICalculations",
                keyColumn: "Id",
                keyValue: new Guid("f5d324c1-9826-4c3f-8a49-bcecbea01982"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("2e3f591f-0e4d-42c3-beb7-d6fa059505b0"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("a358f9df-b0d8-4dae-888c-b450e94b706a"));

            migrationBuilder.DeleteData(
                table: "NutritionIntake",
                keyColumn: "Id",
                keyValue: new Guid("b9c84c74-29c7-4859-932a-34d69dbaaef8"));

            migrationBuilder.DeleteData(
                table: "NutritionIntake",
                keyColumn: "Id",
                keyValue: new Guid("fdeebb94-2676-4dfc-800b-cc4fa495a0e3"));

            migrationBuilder.DeleteData(
                table: "ProgressLogs",
                keyColumn: "Id",
                keyValue: new Guid("bba676f0-1716-4bc9-bce3-72e3063854b3"));

            migrationBuilder.DeleteData(
                table: "ProgressLogs",
                keyColumn: "Id",
                keyValue: new Guid("eb36c836-38aa-496f-a68a-35b0d31c2f15"));

            migrationBuilder.DeleteData(
                table: "TargetNutritional",
                keyColumn: "Id",
                keyValue: new Guid("63363bb1-6855-46a3-a910-08277f1fe180"));

            migrationBuilder.DeleteData(
                table: "TargetNutritional",
                keyColumn: "Id",
                keyValue: new Guid("64623ff1-de05-420d-a2e2-b3bac6477932"));

            migrationBuilder.DeleteData(
                table: "WaterIntakes",
                keyColumn: "Id",
                keyValue: new Guid("52227c04-6706-4f2d-84c2-ae7b51663f3b"));

            migrationBuilder.DeleteData(
                table: "WaterIntakes",
                keyColumn: "Id",
                keyValue: new Guid("96c67bd6-c77a-44ec-ba38-658c6b1c3c5d"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumns: new[] { "ExerciseId", "WorkoutId" },
                keyValues: new object[] { new Guid("60ad6a78-419e-4925-8db1-5ae6169461dc"), new Guid("101adcc6-4441-4032-adff-184e7c954f5b") });

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumns: new[] { "ExerciseId", "WorkoutId" },
                keyValues: new object[] { new Guid("652a5be2-031f-49fa-9f25-b78146427c85"), new Guid("7de01856-d7b1-4bc6-9864-c508c340e193") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("26c70f6a-5f07-46a0-beb8-a21af9955a2d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("49813fcd-5b78-4cca-b5a2-8ee7a9006941"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("60ad6a78-419e-4925-8db1-5ae6169461dc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("652a5be2-031f-49fa-9f25-b78146427c85"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("101adcc6-4441-4032-adff-184e7c954f5b"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("7de01856-d7b1-4bc6-9864-c508c340e193"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("395c5591-a0b8-4249-9d58-ee5e7ec171cf"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("51d32863-946a-42af-8d5a-73621b1ee35e"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("093fd604-0626-45a7-b5bb-7f4c40e92040"), 0, "9362f72d-c825-4b65-bcbb-78ca4b0cea24", "user1@example.com", true, false, null, "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEIV0XGtUwRfImqxzRNR/ZSelhz6yS6VbL4ypQ1sQT/ippTXbGLbE4v0zqcAq/mh+mw==", null, false, "261d60e9-a99f-4509-9de0-897aeab13376", false, "User1" },
                    { new Guid("f95693a9-1a81-48cc-8266-6e0190355242"), 0, "7558ef24-3dd7-4eb6-afef-1173b4421425", "user2@example.com", true, false, null, "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAENsvPTylUZzHZVmydSraxszbb9VyZ6hGlLTuPz0O81e7kTZixLLqHr8n1vcPOAaWfQ==", null, false, "ae3dd404-dc12-4ec5-a934-47cc9c673f78", false, "User2" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Duration", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("5610f24d-abd3-4cd2-9833-a086046c701c"), "A lower body exercise for strength and endurance.", 40, "https://weighttraining.guide/wp-content/uploads/2016/10/barbell-squat-resized-FIXED-2.png", "Squat" },
                    { new Guid("b087f457-c83f-4c1b-9689-0577f60a7249"), "A bodyweight exercise for upper body strength.", 30, "https://anabolicaliens.com/cdn/shop/articles/199990_400x.png?v=1645089103", "Push-Up" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Age", "CreatedOn", "FirstName", "Gender", "Height", "IsActiveProfile", "LastName", "StartingWeight" },
                values: new object[,]
                {
                    { new Guid("3d021538-439f-48cd-be61-1ee2f19f7719"), 30, new DateTime(2024, 12, 17, 22, 43, 36, 932, DateTimeKind.Local).AddTicks(1720), "John", 1, 180m, true, "Doe", 80m },
                    { new Guid("b38e91f4-a483-41dd-8a84-6e3577350714"), 25, new DateTime(2024, 12, 17, 22, 43, 36, 936, DateTimeKind.Local).AddTicks(2443), "Jane", 2, 165m, true, "Smith", 60m }
                });

            migrationBuilder.InsertData(
                table: "ApplicationUserProfiles",
                columns: new[] { "ApplicationUserId", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("093fd604-0626-45a7-b5bb-7f4c40e92040"), new Guid("3d021538-439f-48cd-be61-1ee2f19f7719") },
                    { new Guid("f95693a9-1a81-48cc-8266-6e0190355242"), new Guid("b38e91f4-a483-41dd-8a84-6e3577350714") }
                });

            migrationBuilder.InsertData(
                table: "BMICalculations",
                columns: new[] { "Id", "BMI", "Category", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("1478640d-653f-45f2-a2ff-61d6bba41275"), 24.7m, 2, new Guid("3d021538-439f-48cd-be61-1ee2f19f7719") },
                    { new Guid("d7eb4d21-180f-4350-8532-73d97ccbb0b3"), 22m, 2, new Guid("b38e91f4-a483-41dd-8a84-6e3577350714") }
                });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "Activity", "GoalChest", "GoalHips", "GoalType", "GoalWaist", "GoalWeight", "StartDate", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("7a9611a5-63bb-430c-8389-7247c1dbf686"), 3, 95f, null, 1, 85f, 75m, new DateTime(2024, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3d021538-439f-48cd-be61-1ee2f19f7719") },
                    { new Guid("9210433e-8f2e-4d71-8a3e-e85486663248"), 4, null, 97f, 2, null, 67m, new DateTime(2024, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b38e91f4-a483-41dd-8a84-6e3577350714") }
                });

            migrationBuilder.InsertData(
                table: "NutritionIntake",
                columns: new[] { "Id", "Calories", "Carbohydrates", "Date", "Fats", "Protein", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("1e50c95f-f255-4edf-8396-db07ea5a27b9"), 2600, 220, new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), 63, 210, new Guid("b38e91f4-a483-41dd-8a84-6e3577350714") },
                    { new Guid("8181e98c-1aa4-41dd-8b16-5d2cc4ec86f3"), 1800, 90, new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), 45, 140, new Guid("3d021538-439f-48cd-be61-1ee2f19f7719") }
                });

            migrationBuilder.InsertData(
                table: "ProgressLogs",
                columns: new[] { "Id", "Chest", "CurrentWeight", "Date", "Hips", "UserProfileId", "Waist" },
                values: new object[,]
                {
                    { new Guid("22a8c9c9-b20e-433f-9254-72c43c3a6dde"), null, 60.5m, new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), 95m, new Guid("b38e91f4-a483-41dd-8a84-6e3577350714"), null },
                    { new Guid("79b1b2b9-0f92-4010-9345-7751c5efb706"), 100m, 79.5m, new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), null, new Guid("3d021538-439f-48cd-be61-1ee2f19f7719"), 90m }
                });

            migrationBuilder.InsertData(
                table: "TargetNutritional",
                columns: new[] { "Id", "GoalId", "GoalName", "StartDate", "TargetCalories", "TargetCarbohydrates", "TargetFats", "TargetProtein", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("5a52bdb7-4854-4052-afea-f5bfacfae8c2"), new Guid("00000000-0000-0000-0000-000000000000"), "Lose weight", new DateTime(2024, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), 2000, 100, 50, 150, new Guid("3d021538-439f-48cd-be61-1ee2f19f7719") },
                    { new Guid("ca793373-1bfb-457a-8821-c0e5565a4f76"), new Guid("00000000-0000-0000-0000-000000000000"), "Gain muscle", new DateTime(2024, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), 2500, 200, 60, 200, new Guid("b38e91f4-a483-41dd-8a84-6e3577350714") }
                });

            migrationBuilder.InsertData(
                table: "WaterIntakes",
                columns: new[] { "Id", "DailyGoal", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("3122e6b6-e266-478e-816b-531badb6aa4c"), 2.5f, new Guid("3d021538-439f-48cd-be61-1ee2f19f7719") },
                    { new Guid("c5f1c45d-af7d-4fde-8975-ca1cc97f633c"), 3f, new Guid("b38e91f4-a483-41dd-8a84-6e3577350714") }
                });

            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "Id", "Description", "Duration", "Name", "ScheduleDateTime", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("6c3c0900-ba08-4db6-85db-f98b69beebd4"), "A full-body workout to start the day.", 60, "Morning Strength", new DateTime(2024, 12, 17, 23, 43, 36, 943, DateTimeKind.Local).AddTicks(495), new Guid("b38e91f4-a483-41dd-8a84-6e3577350714") },
                    { new Guid("a9cc86d6-9ed8-409a-a89e-73d9c0d68aab"), "High-intensity cardio for fat burn.", 45, "Evening Cardio", new DateTime(2024, 12, 18, 1, 43, 36, 942, DateTimeKind.Local).AddTicks(8405), new Guid("3d021538-439f-48cd-be61-1ee2f19f7719") }
                });

            migrationBuilder.InsertData(
                table: "WorkoutExercises",
                columns: new[] { "ExerciseId", "WorkoutId", "Reps", "Sets" },
                values: new object[,]
                {
                    { new Guid("b087f457-c83f-4c1b-9689-0577f60a7249"), new Guid("6c3c0900-ba08-4db6-85db-f98b69beebd4"), 10, 3 },
                    { new Guid("5610f24d-abd3-4cd2-9833-a086046c701c"), new Guid("a9cc86d6-9ed8-409a-a89e-73d9c0d68aab"), 15, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationUserProfiles",
                keyColumns: new[] { "ApplicationUserId", "UserProfileId" },
                keyValues: new object[] { new Guid("093fd604-0626-45a7-b5bb-7f4c40e92040"), new Guid("3d021538-439f-48cd-be61-1ee2f19f7719") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserProfiles",
                keyColumns: new[] { "ApplicationUserId", "UserProfileId" },
                keyValues: new object[] { new Guid("f95693a9-1a81-48cc-8266-6e0190355242"), new Guid("b38e91f4-a483-41dd-8a84-6e3577350714") });

            migrationBuilder.DeleteData(
                table: "BMICalculations",
                keyColumn: "Id",
                keyValue: new Guid("1478640d-653f-45f2-a2ff-61d6bba41275"));

            migrationBuilder.DeleteData(
                table: "BMICalculations",
                keyColumn: "Id",
                keyValue: new Guid("d7eb4d21-180f-4350-8532-73d97ccbb0b3"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("7a9611a5-63bb-430c-8389-7247c1dbf686"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("9210433e-8f2e-4d71-8a3e-e85486663248"));

            migrationBuilder.DeleteData(
                table: "NutritionIntake",
                keyColumn: "Id",
                keyValue: new Guid("1e50c95f-f255-4edf-8396-db07ea5a27b9"));

            migrationBuilder.DeleteData(
                table: "NutritionIntake",
                keyColumn: "Id",
                keyValue: new Guid("8181e98c-1aa4-41dd-8b16-5d2cc4ec86f3"));

            migrationBuilder.DeleteData(
                table: "ProgressLogs",
                keyColumn: "Id",
                keyValue: new Guid("22a8c9c9-b20e-433f-9254-72c43c3a6dde"));

            migrationBuilder.DeleteData(
                table: "ProgressLogs",
                keyColumn: "Id",
                keyValue: new Guid("79b1b2b9-0f92-4010-9345-7751c5efb706"));

            migrationBuilder.DeleteData(
                table: "TargetNutritional",
                keyColumn: "Id",
                keyValue: new Guid("5a52bdb7-4854-4052-afea-f5bfacfae8c2"));

            migrationBuilder.DeleteData(
                table: "TargetNutritional",
                keyColumn: "Id",
                keyValue: new Guid("ca793373-1bfb-457a-8821-c0e5565a4f76"));

            migrationBuilder.DeleteData(
                table: "WaterIntakes",
                keyColumn: "Id",
                keyValue: new Guid("3122e6b6-e266-478e-816b-531badb6aa4c"));

            migrationBuilder.DeleteData(
                table: "WaterIntakes",
                keyColumn: "Id",
                keyValue: new Guid("c5f1c45d-af7d-4fde-8975-ca1cc97f633c"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumns: new[] { "ExerciseId", "WorkoutId" },
                keyValues: new object[] { new Guid("b087f457-c83f-4c1b-9689-0577f60a7249"), new Guid("6c3c0900-ba08-4db6-85db-f98b69beebd4") });

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumns: new[] { "ExerciseId", "WorkoutId" },
                keyValues: new object[] { new Guid("5610f24d-abd3-4cd2-9833-a086046c701c"), new Guid("a9cc86d6-9ed8-409a-a89e-73d9c0d68aab") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("093fd604-0626-45a7-b5bb-7f4c40e92040"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f95693a9-1a81-48cc-8266-6e0190355242"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5610f24d-abd3-4cd2-9833-a086046c701c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b087f457-c83f-4c1b-9689-0577f60a7249"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("6c3c0900-ba08-4db6-85db-f98b69beebd4"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("a9cc86d6-9ed8-409a-a89e-73d9c0d68aab"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("3d021538-439f-48cd-be61-1ee2f19f7719"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("b38e91f4-a483-41dd-8a84-6e3577350714"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("26c70f6a-5f07-46a0-beb8-a21af9955a2d"), 0, "965ca297-6294-4340-a4e7-7d92d61a644f", "user2@example.com", true, false, null, "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEM5yz3aDhAzte6S1MxV9JU5YTWs130OlzmXY41oRFUcEKsdm5yql9Taw75wfeoelNQ==", null, false, "ed8cafa3-fcec-43b3-af02-b1ec474465a5", false, "User2" },
                    { new Guid("49813fcd-5b78-4cca-b5a2-8ee7a9006941"), 0, "3bf31377-0b35-486e-a614-79176d863c1e", "user1@example.com", true, false, null, "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEMcxF0nm+WI7oc2oaxeeQhWQalfxqMxHsX/LbRBjmWMIPEdPirPZybZkJYl5Z2vcUw==", null, false, "47cb53bc-4603-4876-bb82-4dad4537acad", false, "User1" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Duration", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("60ad6a78-419e-4925-8db1-5ae6169461dc"), "A lower body exercise for strength and endurance.", 40, "https://weighttraining.guide/wp-content/uploads/2016/10/barbell-squat-resized-FIXED-2.png", "Squat" },
                    { new Guid("652a5be2-031f-49fa-9f25-b78146427c85"), "A bodyweight exercise for upper body strength.", 30, "https://anabolicaliens.com/cdn/shop/articles/199990_400x.png?v=1645089103", "Push-Up" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Age", "CreatedOn", "FirstName", "Gender", "Height", "IsActiveProfile", "LastName", "StartingWeight" },
                values: new object[,]
                {
                    { new Guid("395c5591-a0b8-4249-9d58-ee5e7ec171cf"), 25, new DateTime(2024, 12, 12, 15, 9, 30, 784, DateTimeKind.Local).AddTicks(2230), "Jane", 2, 165m, true, "Smith", 60m },
                    { new Guid("51d32863-946a-42af-8d5a-73621b1ee35e"), 30, new DateTime(2024, 12, 12, 15, 9, 30, 782, DateTimeKind.Local).AddTicks(3746), "John", 1, 180m, true, "Doe", 80m }
                });

            migrationBuilder.InsertData(
                table: "ApplicationUserProfiles",
                columns: new[] { "ApplicationUserId", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("26c70f6a-5f07-46a0-beb8-a21af9955a2d"), new Guid("395c5591-a0b8-4249-9d58-ee5e7ec171cf") },
                    { new Guid("49813fcd-5b78-4cca-b5a2-8ee7a9006941"), new Guid("51d32863-946a-42af-8d5a-73621b1ee35e") }
                });

            migrationBuilder.InsertData(
                table: "BMICalculations",
                columns: new[] { "Id", "BMI", "Category", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("3b675970-24e3-4d5c-9d68-35e7afea32ae"), 24.7m, 2, new Guid("51d32863-946a-42af-8d5a-73621b1ee35e") },
                    { new Guid("f5d324c1-9826-4c3f-8a49-bcecbea01982"), 22m, 2, new Guid("395c5591-a0b8-4249-9d58-ee5e7ec171cf") }
                });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "Activity", "GoalChest", "GoalHips", "GoalType", "GoalWaist", "GoalWeight", "StartDate", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("2e3f591f-0e4d-42c3-beb7-d6fa059505b0"), 3, 95f, null, 1, 85f, 75m, new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51d32863-946a-42af-8d5a-73621b1ee35e") },
                    { new Guid("a358f9df-b0d8-4dae-888c-b450e94b706a"), 4, null, 97f, 2, null, 67m, new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("395c5591-a0b8-4249-9d58-ee5e7ec171cf") }
                });

            migrationBuilder.InsertData(
                table: "NutritionIntake",
                columns: new[] { "Id", "Calories", "Carbohydrates", "Date", "Fats", "Protein", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("b9c84c74-29c7-4859-932a-34d69dbaaef8"), 2600, 220, new DateTime(2024, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), 63, 210, new Guid("395c5591-a0b8-4249-9d58-ee5e7ec171cf") },
                    { new Guid("fdeebb94-2676-4dfc-800b-cc4fa495a0e3"), 1800, 90, new DateTime(2024, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), 45, 140, new Guid("51d32863-946a-42af-8d5a-73621b1ee35e") }
                });

            migrationBuilder.InsertData(
                table: "ProgressLogs",
                columns: new[] { "Id", "Chest", "CurrentWeight", "Date", "Hips", "UserProfileId", "Waist" },
                values: new object[,]
                {
                    { new Guid("bba676f0-1716-4bc9-bce3-72e3063854b3"), 100m, 79.5m, new DateTime(2024, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), null, new Guid("51d32863-946a-42af-8d5a-73621b1ee35e"), 90m },
                    { new Guid("eb36c836-38aa-496f-a68a-35b0d31c2f15"), null, 60.5m, new DateTime(2024, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), 95m, new Guid("395c5591-a0b8-4249-9d58-ee5e7ec171cf"), null }
                });

            migrationBuilder.InsertData(
                table: "TargetNutritional",
                columns: new[] { "Id", "GoalId", "GoalName", "StartDate", "TargetCalories", "TargetCarbohydrates", "TargetFats", "TargetProtein", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("63363bb1-6855-46a3-a910-08277f1fe180"), new Guid("00000000-0000-0000-0000-000000000000"), "Lose weight", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2000, 100, 50, 150, new Guid("51d32863-946a-42af-8d5a-73621b1ee35e") },
                    { new Guid("64623ff1-de05-420d-a2e2-b3bac6477932"), new Guid("00000000-0000-0000-0000-000000000000"), "Gain muscle", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2500, 200, 60, 200, new Guid("395c5591-a0b8-4249-9d58-ee5e7ec171cf") }
                });

            migrationBuilder.InsertData(
                table: "WaterIntakes",
                columns: new[] { "Id", "DailyGoal", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("52227c04-6706-4f2d-84c2-ae7b51663f3b"), 3f, new Guid("395c5591-a0b8-4249-9d58-ee5e7ec171cf") },
                    { new Guid("96c67bd6-c77a-44ec-ba38-658c6b1c3c5d"), 2.5f, new Guid("51d32863-946a-42af-8d5a-73621b1ee35e") }
                });

            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "Id", "Description", "Duration", "Name", "ScheduleDateTime", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("101adcc6-4441-4032-adff-184e7c954f5b"), "High-intensity cardio for fat burn.", 45, "Evening Cardio", new DateTime(2024, 12, 12, 18, 9, 30, 786, DateTimeKind.Local).AddTicks(4079), new Guid("51d32863-946a-42af-8d5a-73621b1ee35e") },
                    { new Guid("7de01856-d7b1-4bc6-9864-c508c340e193"), "A full-body workout to start the day.", 60, "Morning Strength", new DateTime(2024, 12, 12, 16, 9, 30, 786, DateTimeKind.Local).AddTicks(4678), new Guid("395c5591-a0b8-4249-9d58-ee5e7ec171cf") }
                });

            migrationBuilder.InsertData(
                table: "WorkoutExercises",
                columns: new[] { "ExerciseId", "WorkoutId", "Reps", "Sets" },
                values: new object[,]
                {
                    { new Guid("60ad6a78-419e-4925-8db1-5ae6169461dc"), new Guid("101adcc6-4441-4032-adff-184e7c954f5b"), 15, 4 },
                    { new Guid("652a5be2-031f-49fa-9f25-b78146427c85"), new Guid("7de01856-d7b1-4bc6-9864-c508c340e193"), 10, 3 }
                });
        }
    }
}
