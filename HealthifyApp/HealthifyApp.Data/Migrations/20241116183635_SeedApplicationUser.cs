using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthifyApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedApplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("723e7be4-bfc6-4570-aa3e-78aceccbb79f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b39823d7-cc6d-4f8a-a060-3bdb72c2d70b"));

            migrationBuilder.DeleteData(
                table: "BMICalculations",
                keyColumn: "Id",
                keyValue: new Guid("5400854c-3e39-4602-9e47-f70cc434c226"));

            migrationBuilder.DeleteData(
                table: "BMICalculations",
                keyColumn: "Id",
                keyValue: new Guid("91f188f3-3a6a-451a-8b4c-5dce1d5f25e3"));

            migrationBuilder.DeleteData(
                table: "NutritionPlans",
                keyColumn: "Id",
                keyValue: new Guid("92456ba8-1840-4b6f-b67e-8dd503a98102"));

            migrationBuilder.DeleteData(
                table: "NutritionPlans",
                keyColumn: "Id",
                keyValue: new Guid("93a06393-d017-4fbc-aaab-071355d2a10f"));

            migrationBuilder.DeleteData(
                table: "ProgressLogs",
                keyColumn: "Id",
                keyValue: new Guid("c92607ff-eb5f-4190-9147-ace721e5670a"));

            migrationBuilder.DeleteData(
                table: "ProgressLogs",
                keyColumn: "Id",
                keyValue: new Guid("cce69394-6a7e-4327-bd9f-14d6a579e1ea"));

            migrationBuilder.DeleteData(
                table: "WaterIntakes",
                keyColumn: "Id",
                keyValue: new Guid("90691960-ddd2-415c-9544-5ac8a14619f6"));

            migrationBuilder.DeleteData(
                table: "WaterIntakes",
                keyColumn: "Id",
                keyValue: new Guid("d8193c79-e8a7-4e4c-a4fd-3a168691eb2f"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumns: new[] { "ExerciseId", "WorkoutId" },
                keyValues: new object[] { new Guid("542e80cf-567d-4ac4-bc62-f56f506da909"), new Guid("3f25b785-3a91-4ffc-9c03-3abf58d69a95") });

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumns: new[] { "ExerciseId", "WorkoutId" },
                keyValues: new object[] { new Guid("6b6d177d-55fb-4337-a668-6cc4bb3aa4cc"), new Guid("bc78ee23-8506-4a5b-9889-e2339fc00556") });

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("542e80cf-567d-4ac4-bc62-f56f506da909"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6b6d177d-55fb-4337-a668-6cc4bb3aa4cc"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("3f25b785-3a91-4ffc-9c03-3abf58d69a95"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("bc78ee23-8506-4a5b-9889-e2339fc00556"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("0afcd5a0-79cb-4103-9aaa-91d793320d6b"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("37f40018-98bb-4883-970e-e8d3436d503f"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("43879187-035d-4559-aad8-6e110290dcb9"), 0, "69b52737-6634-41d4-8a1f-4fca671c4d8b", "user1@example.com", true, false, null, "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEJxugAlrbMu4VP54Pb1iAwkKmLsxUi2bQBujyZhz0i+ikM+L/g+ii8EzQteaMXpKRw==", null, false, "bbe7ffa1-8a06-4c85-9b44-6977730ba029", false, "User1" },
                    { new Guid("e2b0b923-cd70-4c78-aeef-75ddcf4fa362"), 0, "3771df6a-62cb-4fc7-ae20-478877e217ba", "user2@example.com", true, false, null, "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAELcNq4jpTUMDWXAM6lDduWLkCG/bnzVca16Q4KsTcOwKmNEZLlpRihQ2rI1o7zGZwA==", null, false, "3fd7de7f-a651-4e27-bbf0-7c12283e07f7", false, "User2" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Duration", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("0fb3b860-232e-4258-b15d-a210955cbafd"), "A bodyweight exercise for upper body strength.", 30, "https://anabolicaliens.com/cdn/shop/articles/199990_400x.png?v=1645089103", "Push-Up" },
                    { new Guid("ded77619-c2d5-4358-adf8-d1b0b12c5b02"), "A lower body exercise for strength and endurance.", 40, "https://weighttraining.guide/wp-content/uploads/2016/10/barbell-squat-resized-FIXED-2.png", "Squat" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Age", "CreatedOn", "FirstName", "Gender", "Goals", "Height", "LastName", "Weight" },
                values: new object[,]
                {
                    { new Guid("2e5da47a-5de2-4772-bb5d-d57b07b7f205"), 30, new DateTime(2024, 11, 16, 20, 36, 32, 636, DateTimeKind.Local).AddTicks(6258), "John", 1, "Lose weight", 180m, "Doe", 80m },
                    { new Guid("cec2f685-c9e2-43db-87f2-8524a41c80a2"), 25, new DateTime(2024, 11, 16, 20, 36, 32, 639, DateTimeKind.Local).AddTicks(9965), "Jane", 2, "Gain muscle", 165m, "Smith", 60m }
                });

            migrationBuilder.InsertData(
                table: "BMICalculations",
                columns: new[] { "Id", "BMI", "Category", "Date", "Height", "UserProfileId", "Weight" },
                values: new object[,]
                {
                    { new Guid("763fb6f9-bd86-4edf-82a5-b79e27110ead"), 22m, "Normal weight", new DateTime(2024, 11, 16, 20, 36, 32, 640, DateTimeKind.Local).AddTicks(7114), 165m, new Guid("cec2f685-c9e2-43db-87f2-8524a41c80a2"), 60.6m },
                    { new Guid("cd09fd52-4fd7-43ea-a7e3-d3805ca621fd"), 24.7m, "Normal weight", new DateTime(2024, 11, 16, 20, 36, 32, 640, DateTimeKind.Local).AddTicks(5084), 180m, new Guid("2e5da47a-5de2-4772-bb5d-d57b07b7f205"), 80m }
                });

            migrationBuilder.InsertData(
                table: "NutritionPlans",
                columns: new[] { "Id", "Calories", "Carbohydrates", "Fats", "Goal", "Protein", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("8e83560e-36f3-481f-b07d-f996e03a1ab8"), 2500, 200, 60, "Gain muscle", 200, new Guid("cec2f685-c9e2-43db-87f2-8524a41c80a2") },
                    { new Guid("ec8b3060-d1bb-4e1f-b2ed-c65072b4b9ee"), 2000, 100, 50, "Lose weight", 150, new Guid("2e5da47a-5de2-4772-bb5d-d57b07b7f205") }
                });

            migrationBuilder.InsertData(
                table: "ProgressLogs",
                columns: new[] { "Id", "Chest", "Date", "Hips", "UserProfileId", "Waist", "Weight" },
                values: new object[,]
                {
                    { new Guid("5261e559-90f8-4dd3-a629-40b261f4ec49"), 100m, new DateTime(2024, 11, 16, 20, 36, 32, 641, DateTimeKind.Local).AddTicks(7519), null, new Guid("2e5da47a-5de2-4772-bb5d-d57b07b7f205"), 90m, 79.5m },
                    { new Guid("aa39bc5f-6aed-4e00-b287-50c7adb26c66"), null, new DateTime(2024, 11, 16, 20, 36, 32, 641, DateTimeKind.Local).AddTicks(9565), 95m, new Guid("cec2f685-c9e2-43db-87f2-8524a41c80a2"), null, 60.5m }
                });

            migrationBuilder.InsertData(
                table: "WaterIntakes",
                columns: new[] { "Id", "Consumed", "DailyGoal", "Date", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("66d8abd7-976e-45cf-9402-4ee241dd55c3"), 2.8f, 3f, new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), new Guid("cec2f685-c9e2-43db-87f2-8524a41c80a2") },
                    { new Guid("f6fb919f-7245-41a4-9bc7-ae05dbc14b71"), 2f, 2.5f, new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), new Guid("2e5da47a-5de2-4772-bb5d-d57b07b7f205") }
                });

            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "Id", "Description", "Duration", "Name", "ScheduleDateTime", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("2ed83f87-9aa2-4f7b-8b7f-96772dbc56ab"), "A full-body workout to start the day.", 60, "Morning Strength", new DateTime(2024, 11, 16, 21, 36, 32, 643, DateTimeKind.Local).AddTicks(2316), new Guid("2e5da47a-5de2-4772-bb5d-d57b07b7f205") },
                    { new Guid("598ca47c-f5b7-4448-9915-64a9551a57bf"), "High-intensity cardio for fat burn.", 45, "Evening Cardio", new DateTime(2024, 11, 16, 23, 36, 32, 643, DateTimeKind.Local).AddTicks(3335), new Guid("cec2f685-c9e2-43db-87f2-8524a41c80a2") }
                });

            migrationBuilder.InsertData(
                table: "WorkoutExercises",
                columns: new[] { "ExerciseId", "WorkoutId", "Reps", "Sets" },
                values: new object[,]
                {
                    { new Guid("0fb3b860-232e-4258-b15d-a210955cbafd"), new Guid("2ed83f87-9aa2-4f7b-8b7f-96772dbc56ab"), 10, 3 },
                    { new Guid("ded77619-c2d5-4358-adf8-d1b0b12c5b02"), new Guid("598ca47c-f5b7-4448-9915-64a9551a57bf"), 15, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("43879187-035d-4559-aad8-6e110290dcb9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e2b0b923-cd70-4c78-aeef-75ddcf4fa362"));

            migrationBuilder.DeleteData(
                table: "BMICalculations",
                keyColumn: "Id",
                keyValue: new Guid("763fb6f9-bd86-4edf-82a5-b79e27110ead"));

            migrationBuilder.DeleteData(
                table: "BMICalculations",
                keyColumn: "Id",
                keyValue: new Guid("cd09fd52-4fd7-43ea-a7e3-d3805ca621fd"));

            migrationBuilder.DeleteData(
                table: "NutritionPlans",
                keyColumn: "Id",
                keyValue: new Guid("8e83560e-36f3-481f-b07d-f996e03a1ab8"));

            migrationBuilder.DeleteData(
                table: "NutritionPlans",
                keyColumn: "Id",
                keyValue: new Guid("ec8b3060-d1bb-4e1f-b2ed-c65072b4b9ee"));

            migrationBuilder.DeleteData(
                table: "ProgressLogs",
                keyColumn: "Id",
                keyValue: new Guid("5261e559-90f8-4dd3-a629-40b261f4ec49"));

            migrationBuilder.DeleteData(
                table: "ProgressLogs",
                keyColumn: "Id",
                keyValue: new Guid("aa39bc5f-6aed-4e00-b287-50c7adb26c66"));

            migrationBuilder.DeleteData(
                table: "WaterIntakes",
                keyColumn: "Id",
                keyValue: new Guid("66d8abd7-976e-45cf-9402-4ee241dd55c3"));

            migrationBuilder.DeleteData(
                table: "WaterIntakes",
                keyColumn: "Id",
                keyValue: new Guid("f6fb919f-7245-41a4-9bc7-ae05dbc14b71"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumns: new[] { "ExerciseId", "WorkoutId" },
                keyValues: new object[] { new Guid("0fb3b860-232e-4258-b15d-a210955cbafd"), new Guid("2ed83f87-9aa2-4f7b-8b7f-96772dbc56ab") });

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumns: new[] { "ExerciseId", "WorkoutId" },
                keyValues: new object[] { new Guid("ded77619-c2d5-4358-adf8-d1b0b12c5b02"), new Guid("598ca47c-f5b7-4448-9915-64a9551a57bf") });

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0fb3b860-232e-4258-b15d-a210955cbafd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ded77619-c2d5-4358-adf8-d1b0b12c5b02"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("2ed83f87-9aa2-4f7b-8b7f-96772dbc56ab"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("598ca47c-f5b7-4448-9915-64a9551a57bf"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("2e5da47a-5de2-4772-bb5d-d57b07b7f205"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("cec2f685-c9e2-43db-87f2-8524a41c80a2"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("723e7be4-bfc6-4570-aa3e-78aceccbb79f"), 0, "4ad6c632-70d9-4e0e-8822-e8c977678402", "user2@example.com", false, false, null, null, null, "AQAAAAIAAYagAAAAECTl9PnSau1gS1QAuuq4sJzMfJgwgWSuoyx1+svCeGxNMLEugqxPsCVs1qVTzLIT+A==", null, false, null, false, "User2" },
                    { new Guid("b39823d7-cc6d-4f8a-a060-3bdb72c2d70b"), 0, "122c025f-a005-4564-a7b3-4cb92d0a4894", "user1@example.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEAIxmVvdLd2zQZw3ASi6EJW6Ae66ozLjP3px5fjFzI5QLYtiXGS/bCzzpUCetYI0ig==", null, false, null, false, "User1" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Duration", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("542e80cf-567d-4ac4-bc62-f56f506da909"), "A lower body exercise for strength and endurance.", 40, "https://weighttraining.guide/wp-content/uploads/2016/10/barbell-squat-resized-FIXED-2.png", "Squat" },
                    { new Guid("6b6d177d-55fb-4337-a668-6cc4bb3aa4cc"), "A bodyweight exercise for upper body strength.", 30, "https://anabolicaliens.com/cdn/shop/articles/199990_400x.png?v=1645089103", "Push-Up" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Age", "CreatedOn", "FirstName", "Gender", "Goals", "Height", "LastName", "Weight" },
                values: new object[,]
                {
                    { new Guid("0afcd5a0-79cb-4103-9aaa-91d793320d6b"), 30, new DateTime(2024, 11, 16, 19, 51, 42, 340, DateTimeKind.Local).AddTicks(1165), "John", 1, "Lose weight", 180m, "Doe", 80m },
                    { new Guid("37f40018-98bb-4883-970e-e8d3436d503f"), 25, new DateTime(2024, 11, 16, 19, 51, 42, 344, DateTimeKind.Local).AddTicks(9694), "Jane", 2, "Gain muscle", 165m, "Smith", 60m }
                });

            migrationBuilder.InsertData(
                table: "BMICalculations",
                columns: new[] { "Id", "BMI", "Category", "Date", "Height", "UserProfileId", "Weight" },
                values: new object[,]
                {
                    { new Guid("5400854c-3e39-4602-9e47-f70cc434c226"), 24.7m, "Normal weight", new DateTime(2024, 11, 16, 19, 51, 42, 345, DateTimeKind.Local).AddTicks(8621), 180m, new Guid("0afcd5a0-79cb-4103-9aaa-91d793320d6b"), 80m },
                    { new Guid("91f188f3-3a6a-451a-8b4c-5dce1d5f25e3"), 22m, "Normal weight", new DateTime(2024, 11, 16, 19, 51, 42, 346, DateTimeKind.Local).AddTicks(2312), 165m, new Guid("37f40018-98bb-4883-970e-e8d3436d503f"), 60.6m }
                });

            migrationBuilder.InsertData(
                table: "NutritionPlans",
                columns: new[] { "Id", "Calories", "Carbohydrates", "Fats", "Goal", "Protein", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("92456ba8-1840-4b6f-b67e-8dd503a98102"), 2000, 100, 50, "Lose weight", 150, new Guid("0afcd5a0-79cb-4103-9aaa-91d793320d6b") },
                    { new Guid("93a06393-d017-4fbc-aaab-071355d2a10f"), 2500, 200, 60, "Gain muscle", 200, new Guid("37f40018-98bb-4883-970e-e8d3436d503f") }
                });

            migrationBuilder.InsertData(
                table: "ProgressLogs",
                columns: new[] { "Id", "Chest", "Date", "Hips", "UserProfileId", "Waist", "Weight" },
                values: new object[,]
                {
                    { new Guid("c92607ff-eb5f-4190-9147-ace721e5670a"), null, new DateTime(2024, 11, 16, 19, 51, 42, 347, DateTimeKind.Local).AddTicks(8202), 95m, new Guid("37f40018-98bb-4883-970e-e8d3436d503f"), null, 60.5m },
                    { new Guid("cce69394-6a7e-4327-bd9f-14d6a579e1ea"), 100m, new DateTime(2024, 11, 16, 19, 51, 42, 347, DateTimeKind.Local).AddTicks(5213), null, new Guid("0afcd5a0-79cb-4103-9aaa-91d793320d6b"), 90m, 79.5m }
                });

            migrationBuilder.InsertData(
                table: "WaterIntakes",
                columns: new[] { "Id", "Consumed", "DailyGoal", "Date", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("90691960-ddd2-415c-9544-5ac8a14619f6"), 2f, 2.5f, new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0afcd5a0-79cb-4103-9aaa-91d793320d6b") },
                    { new Guid("d8193c79-e8a7-4e4c-a4fd-3a168691eb2f"), 2.8f, 3f, new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), new Guid("37f40018-98bb-4883-970e-e8d3436d503f") }
                });

            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "Id", "Description", "Duration", "Name", "ScheduleDateTime", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("3f25b785-3a91-4ffc-9c03-3abf58d69a95"), "High-intensity cardio for fat burn.", 45, "Evening Cardio", new DateTime(2024, 11, 16, 22, 51, 42, 349, DateTimeKind.Local).AddTicks(6637), new Guid("37f40018-98bb-4883-970e-e8d3436d503f") },
                    { new Guid("bc78ee23-8506-4a5b-9889-e2339fc00556"), "A full-body workout to start the day.", 60, "Morning Strength", new DateTime(2024, 11, 16, 20, 51, 42, 349, DateTimeKind.Local).AddTicks(5157), new Guid("0afcd5a0-79cb-4103-9aaa-91d793320d6b") }
                });

            migrationBuilder.InsertData(
                table: "WorkoutExercises",
                columns: new[] { "ExerciseId", "WorkoutId", "Reps", "Sets" },
                values: new object[,]
                {
                    { new Guid("542e80cf-567d-4ac4-bc62-f56f506da909"), new Guid("3f25b785-3a91-4ffc-9c03-3abf58d69a95"), 15, 4 },
                    { new Guid("6b6d177d-55fb-4337-a668-6cc4bb3aa4cc"), new Guid("bc78ee23-8506-4a5b-9889-e2339fc00556"), 10, 3 }
                });
        }
    }
}
