using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthifyApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedGoalIdAndAppUserProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("657e3783-58d0-44a2-a99c-dbd1e6fd54a1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cdfb71a0-f252-4f64-acc2-3d476a17e460"));

            migrationBuilder.DeleteData(
                table: "BMICalculations",
                keyColumn: "Id",
                keyValue: new Guid("bb43d38d-1193-46c0-abda-4541df2923d1"));

            migrationBuilder.DeleteData(
                table: "BMICalculations",
                keyColumn: "Id",
                keyValue: new Guid("c01d1dd1-5140-4278-8dea-21a32f47f8e8"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("2a4a22a7-6eb3-451b-8903-42d693a6504e"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("b8137ebe-2911-43b4-823c-5082c85696a7"));

            migrationBuilder.DeleteData(
                table: "NutritionIntake",
                keyColumn: "Id",
                keyValue: new Guid("706f97b3-4b54-47e2-9dd0-ab3f3eda5be4"));

            migrationBuilder.DeleteData(
                table: "NutritionIntake",
                keyColumn: "Id",
                keyValue: new Guid("fb207434-670b-44de-9125-81a1310085a0"));

            migrationBuilder.DeleteData(
                table: "ProgressLogs",
                keyColumn: "Id",
                keyValue: new Guid("54e7fe86-4b0a-4e44-94f3-8ea4f621b93c"));

            migrationBuilder.DeleteData(
                table: "ProgressLogs",
                keyColumn: "Id",
                keyValue: new Guid("af1f7a9b-8c6e-4e4d-a0df-73045edbfa98"));

            migrationBuilder.DeleteData(
                table: "TargetNutritional",
                keyColumn: "Id",
                keyValue: new Guid("bb551cdf-3cb4-40fd-823b-a9396914987e"));

            migrationBuilder.DeleteData(
                table: "TargetNutritional",
                keyColumn: "Id",
                keyValue: new Guid("d8536f53-5f12-4dec-9727-a0540531f88c"));

            migrationBuilder.DeleteData(
                table: "WaterIntakes",
                keyColumn: "Id",
                keyValue: new Guid("04783557-a686-48cd-82ab-63a8780e13c0"));

            migrationBuilder.DeleteData(
                table: "WaterIntakes",
                keyColumn: "Id",
                keyValue: new Guid("c635853e-30b0-4c8e-8cf2-3ffa9c2d8ad1"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumns: new[] { "ExerciseId", "WorkoutId" },
                keyValues: new object[] { new Guid("733c92ea-f43c-467f-a35c-d14f849efefa"), new Guid("46f11e13-a190-4cbd-afd3-bd4c9f8cfed3") });

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumns: new[] { "ExerciseId", "WorkoutId" },
                keyValues: new object[] { new Guid("730fb7ce-adb1-4570-a818-4f96be3522f8"), new Guid("8b98786a-766f-4afa-a99c-7e82e18df2a9") });

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("730fb7ce-adb1-4570-a818-4f96be3522f8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("733c92ea-f43c-467f-a35c-d14f849efefa"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("46f11e13-a190-4cbd-afd3-bd4c9f8cfed3"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("8b98786a-766f-4afa-a99c-7e82e18df2a9"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("1b4d438a-2db6-4214-8f78-5e532f1907be"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("9ebd1101-f550-4c12-bdb5-7e1c76271d2b"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0f2617b1-561e-4334-a60b-93180029696a"), 0, "930642d0-6cf9-4c98-88a4-6e4c4459d94e", "user1@example.com", true, false, null, "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEJ+88wZsRLoh6PnApJ5SStbQsIRs9lUyKBz1Vt8VYdYAjlts7M39RvRaiBH/s8485A==", null, false, "68711986-3004-436f-8694-4c2f2c0ec89a", false, "User1" },
                    { new Guid("f9cde5dc-32d6-4e50-bee3-53e789d7eab8"), 0, "7507be9e-952e-4356-a271-275e87262c17", "user2@example.com", true, false, null, "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEFutjqv/FgcU/hI17WkKCPAgGMKv9L7u/ibgI7aTBJ81Q8DBJlhXCwSyvcBSN5dbOA==", null, false, "3e774fc7-3ec3-4ded-b60d-0c61cab4ea86", false, "User2" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Duration", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("098b4b05-056a-4cef-acd0-ef8e4bb823e9"), "A bodyweight exercise for upper body strength.", 30, "https://anabolicaliens.com/cdn/shop/articles/199990_400x.png?v=1645089103", "Push-Up" },
                    { new Guid("fdddfcd6-21c0-421e-a276-519f0368110b"), "A lower body exercise for strength and endurance.", 40, "https://weighttraining.guide/wp-content/uploads/2016/10/barbell-squat-resized-FIXED-2.png", "Squat" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Age", "CreatedOn", "FirstName", "Gender", "Height", "LastName", "StartingWeight" },
                values: new object[,]
                {
                    { new Guid("1639e91a-60b1-4308-88c7-e6203eba4404"), 30, new DateTime(2024, 12, 3, 23, 43, 41, 81, DateTimeKind.Local).AddTicks(1703), "John", 1, 180m, "Doe", 80m },
                    { new Guid("a6d9f08f-bd55-4b2c-8561-bfc4178266a3"), 25, new DateTime(2024, 12, 3, 23, 43, 41, 84, DateTimeKind.Local).AddTicks(4790), "Jane", 2, 165m, "Smith", 60m }
                });

            migrationBuilder.InsertData(
                table: "ApplicationUserProfiles",
                columns: new[] { "ApplicationUserId", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("0f2617b1-561e-4334-a60b-93180029696a"), new Guid("1639e91a-60b1-4308-88c7-e6203eba4404") },
                    { new Guid("f9cde5dc-32d6-4e50-bee3-53e789d7eab8"), new Guid("a6d9f08f-bd55-4b2c-8561-bfc4178266a3") }
                });

            migrationBuilder.InsertData(
                table: "BMICalculations",
                columns: new[] { "Id", "BMI", "Category", "Date", "Height", "UserProfileId", "Weight" },
                values: new object[,]
                {
                    { new Guid("7e326d45-8270-4cbd-af83-201209ab804a"), 24.7m, 2, new DateTime(2024, 12, 3, 23, 43, 41, 86, DateTimeKind.Local).AddTicks(1540), 180m, new Guid("1639e91a-60b1-4308-88c7-e6203eba4404"), 80m },
                    { new Guid("9fbdf6af-2727-43c8-ad64-3792233f608e"), 22m, 2, new DateTime(2024, 12, 3, 23, 43, 41, 86, DateTimeKind.Local).AddTicks(6193), 165m, new Guid("a6d9f08f-bd55-4b2c-8561-bfc4178266a3"), 60.6m }
                });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "Activity", "GoalChest", "GoalHips", "GoalType", "GoalWaist", "GoalWeight", "StartDate", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("a9752608-0b7b-4215-acd3-2c98a83cfba0"), 4, null, 97f, 2, null, 67m, new DateTime(2024, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a6d9f08f-bd55-4b2c-8561-bfc4178266a3") },
                    { new Guid("fd2256e1-d47e-48f4-a6ee-ea2d1ee39c34"), 3, 95f, null, 1, 85f, 75m, new DateTime(2024, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1639e91a-60b1-4308-88c7-e6203eba4404") }
                });

            migrationBuilder.InsertData(
                table: "NutritionIntake",
                columns: new[] { "Id", "Calories", "Carbohydrates", "Date", "Fats", "Protein", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("1dfd129e-1c1c-41ec-bf42-1cbcf656f012"), 1800, 90, new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 45, 140, new Guid("1639e91a-60b1-4308-88c7-e6203eba4404") },
                    { new Guid("60c3c090-ddd7-432c-9c8d-0286d208e658"), 2600, 220, new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 63, 210, new Guid("a6d9f08f-bd55-4b2c-8561-bfc4178266a3") }
                });

            migrationBuilder.InsertData(
                table: "ProgressLogs",
                columns: new[] { "Id", "Chest", "CurrentWeight", "Date", "Hips", "UserProfileId", "Waist" },
                values: new object[,]
                {
                    { new Guid("3f47ce38-8366-4813-bab6-c5fcd2034b6a"), null, 60.5m, new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 95m, new Guid("a6d9f08f-bd55-4b2c-8561-bfc4178266a3"), null },
                    { new Guid("b3a86c4e-970b-4c28-8bd1-872ec3955f96"), 100m, 79.5m, new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), null, new Guid("1639e91a-60b1-4308-88c7-e6203eba4404"), 90m }
                });

            migrationBuilder.InsertData(
                table: "TargetNutritional",
                columns: new[] { "Id", "GoalId", "GoalName", "StartDate", "TargetCalories", "TargetCarbohydrates", "TargetFats", "TargetProtein", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("0979eb07-667c-44ae-bac4-f7d0ae8733b0"), new Guid("00000000-0000-0000-0000-000000000000"), "Lose weight", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2000, 100, 50, 150, new Guid("1639e91a-60b1-4308-88c7-e6203eba4404") },
                    { new Guid("642ead46-a237-4070-a6ef-126fd4f04093"), new Guid("00000000-0000-0000-0000-000000000000"), "Gain muscle", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2500, 200, 60, 200, new Guid("a6d9f08f-bd55-4b2c-8561-bfc4178266a3") }
                });

            migrationBuilder.InsertData(
                table: "WaterIntakes",
                columns: new[] { "Id", "Consumed", "DailyGoal", "Date", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("0e5876ca-ac1a-434d-9f3b-ec32ed501803"), 2.8f, 3f, new DateTime(2024, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a6d9f08f-bd55-4b2c-8561-bfc4178266a3") },
                    { new Guid("2db471e2-a0e4-4aac-94ed-4e5064201bf7"), 2f, 2.5f, new DateTime(2024, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1639e91a-60b1-4308-88c7-e6203eba4404") }
                });

            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "Id", "Description", "Duration", "Name", "ScheduleDateTime", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("e78e4913-4dc7-4463-9d92-0bd3eacb7cbd"), "High-intensity cardio for fat burn.", 45, "Evening Cardio", new DateTime(2024, 12, 4, 2, 43, 41, 89, DateTimeKind.Local).AddTicks(9708), new Guid("1639e91a-60b1-4308-88c7-e6203eba4404") },
                    { new Guid("e86d3c82-6e9c-4d43-94f4-f2c00a737a71"), "A full-body workout to start the day.", 60, "Morning Strength", new DateTime(2024, 12, 4, 0, 43, 41, 90, DateTimeKind.Local).AddTicks(696), new Guid("a6d9f08f-bd55-4b2c-8561-bfc4178266a3") }
                });

            migrationBuilder.InsertData(
                table: "WorkoutExercises",
                columns: new[] { "ExerciseId", "WorkoutId", "Reps", "Sets" },
                values: new object[,]
                {
                    { new Guid("fdddfcd6-21c0-421e-a276-519f0368110b"), new Guid("e78e4913-4dc7-4463-9d92-0bd3eacb7cbd"), 15, 4 },
                    { new Guid("098b4b05-056a-4cef-acd0-ef8e4bb823e9"), new Guid("e86d3c82-6e9c-4d43-94f4-f2c00a737a71"), 10, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationUserProfiles",
                keyColumns: new[] { "ApplicationUserId", "UserProfileId" },
                keyValues: new object[] { new Guid("0f2617b1-561e-4334-a60b-93180029696a"), new Guid("1639e91a-60b1-4308-88c7-e6203eba4404") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserProfiles",
                keyColumns: new[] { "ApplicationUserId", "UserProfileId" },
                keyValues: new object[] { new Guid("f9cde5dc-32d6-4e50-bee3-53e789d7eab8"), new Guid("a6d9f08f-bd55-4b2c-8561-bfc4178266a3") });

            migrationBuilder.DeleteData(
                table: "BMICalculations",
                keyColumn: "Id",
                keyValue: new Guid("7e326d45-8270-4cbd-af83-201209ab804a"));

            migrationBuilder.DeleteData(
                table: "BMICalculations",
                keyColumn: "Id",
                keyValue: new Guid("9fbdf6af-2727-43c8-ad64-3792233f608e"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("a9752608-0b7b-4215-acd3-2c98a83cfba0"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("fd2256e1-d47e-48f4-a6ee-ea2d1ee39c34"));

            migrationBuilder.DeleteData(
                table: "NutritionIntake",
                keyColumn: "Id",
                keyValue: new Guid("1dfd129e-1c1c-41ec-bf42-1cbcf656f012"));

            migrationBuilder.DeleteData(
                table: "NutritionIntake",
                keyColumn: "Id",
                keyValue: new Guid("60c3c090-ddd7-432c-9c8d-0286d208e658"));

            migrationBuilder.DeleteData(
                table: "ProgressLogs",
                keyColumn: "Id",
                keyValue: new Guid("3f47ce38-8366-4813-bab6-c5fcd2034b6a"));

            migrationBuilder.DeleteData(
                table: "ProgressLogs",
                keyColumn: "Id",
                keyValue: new Guid("b3a86c4e-970b-4c28-8bd1-872ec3955f96"));

            migrationBuilder.DeleteData(
                table: "TargetNutritional",
                keyColumn: "Id",
                keyValue: new Guid("0979eb07-667c-44ae-bac4-f7d0ae8733b0"));

            migrationBuilder.DeleteData(
                table: "TargetNutritional",
                keyColumn: "Id",
                keyValue: new Guid("642ead46-a237-4070-a6ef-126fd4f04093"));

            migrationBuilder.DeleteData(
                table: "WaterIntakes",
                keyColumn: "Id",
                keyValue: new Guid("0e5876ca-ac1a-434d-9f3b-ec32ed501803"));

            migrationBuilder.DeleteData(
                table: "WaterIntakes",
                keyColumn: "Id",
                keyValue: new Guid("2db471e2-a0e4-4aac-94ed-4e5064201bf7"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumns: new[] { "ExerciseId", "WorkoutId" },
                keyValues: new object[] { new Guid("fdddfcd6-21c0-421e-a276-519f0368110b"), new Guid("e78e4913-4dc7-4463-9d92-0bd3eacb7cbd") });

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumns: new[] { "ExerciseId", "WorkoutId" },
                keyValues: new object[] { new Guid("098b4b05-056a-4cef-acd0-ef8e4bb823e9"), new Guid("e86d3c82-6e9c-4d43-94f4-f2c00a737a71") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0f2617b1-561e-4334-a60b-93180029696a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f9cde5dc-32d6-4e50-bee3-53e789d7eab8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("098b4b05-056a-4cef-acd0-ef8e4bb823e9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fdddfcd6-21c0-421e-a276-519f0368110b"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("e78e4913-4dc7-4463-9d92-0bd3eacb7cbd"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("e86d3c82-6e9c-4d43-94f4-f2c00a737a71"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("1639e91a-60b1-4308-88c7-e6203eba4404"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("a6d9f08f-bd55-4b2c-8561-bfc4178266a3"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("657e3783-58d0-44a2-a99c-dbd1e6fd54a1"), 0, "8b891dab-c575-43e7-a2d4-37e16bb9c5fd", "user1@example.com", true, false, null, "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEJNuJ2KTeSefYzo2WtgoBzxh83hU1wBgRnwEQNY8gJlC+elhCG6HM12imlLtc/z2VQ==", null, false, "66b6d378-cddb-4406-bb30-6a506c77f8c4", false, "User1" },
                    { new Guid("cdfb71a0-f252-4f64-acc2-3d476a17e460"), 0, "eead023d-18a0-4861-8975-08845c389d91", "user2@example.com", true, false, null, "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEImTWP3nO2WJH8cMBehKDVF5loT9qmt//0pgyNHOfigDsf0ypiPy6T0LGe2Nmf/cvA==", null, false, "030fcf3c-eacd-4986-8f02-31ec05404beb", false, "User2" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Duration", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("730fb7ce-adb1-4570-a818-4f96be3522f8"), "A bodyweight exercise for upper body strength.", 30, "https://anabolicaliens.com/cdn/shop/articles/199990_400x.png?v=1645089103", "Push-Up" },
                    { new Guid("733c92ea-f43c-467f-a35c-d14f849efefa"), "A lower body exercise for strength and endurance.", 40, "https://weighttraining.guide/wp-content/uploads/2016/10/barbell-squat-resized-FIXED-2.png", "Squat" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Age", "CreatedOn", "FirstName", "Gender", "Height", "LastName", "StartingWeight" },
                values: new object[,]
                {
                    { new Guid("1b4d438a-2db6-4214-8f78-5e532f1907be"), 25, new DateTime(2024, 12, 3, 23, 36, 22, 719, DateTimeKind.Local).AddTicks(9826), "Jane", 2, 165m, "Smith", 60m },
                    { new Guid("9ebd1101-f550-4c12-bdb5-7e1c76271d2b"), 30, new DateTime(2024, 12, 3, 23, 36, 22, 714, DateTimeKind.Local).AddTicks(5609), "John", 1, 180m, "Doe", 80m }
                });

            migrationBuilder.InsertData(
                table: "BMICalculations",
                columns: new[] { "Id", "BMI", "Category", "Date", "Height", "UserProfileId", "Weight" },
                values: new object[,]
                {
                    { new Guid("bb43d38d-1193-46c0-abda-4541df2923d1"), 24.7m, 2, new DateTime(2024, 12, 3, 23, 36, 22, 720, DateTimeKind.Local).AddTicks(7462), 180m, new Guid("9ebd1101-f550-4c12-bdb5-7e1c76271d2b"), 80m },
                    { new Guid("c01d1dd1-5140-4278-8dea-21a32f47f8e8"), 22m, 2, new DateTime(2024, 12, 3, 23, 36, 22, 721, DateTimeKind.Local).AddTicks(54), 165m, new Guid("1b4d438a-2db6-4214-8f78-5e532f1907be"), 60.6m }
                });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "Activity", "GoalChest", "GoalHips", "GoalType", "GoalWaist", "GoalWeight", "StartDate", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("2a4a22a7-6eb3-451b-8903-42d693a6504e"), 3, 95f, null, 1, 85f, 75m, new DateTime(2024, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9ebd1101-f550-4c12-bdb5-7e1c76271d2b") },
                    { new Guid("b8137ebe-2911-43b4-823c-5082c85696a7"), 4, null, 97f, 2, null, 67m, new DateTime(2024, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1b4d438a-2db6-4214-8f78-5e532f1907be") }
                });

            migrationBuilder.InsertData(
                table: "NutritionIntake",
                columns: new[] { "Id", "Calories", "Carbohydrates", "Date", "Fats", "Protein", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("706f97b3-4b54-47e2-9dd0-ab3f3eda5be4"), 1800, 90, new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 45, 140, new Guid("9ebd1101-f550-4c12-bdb5-7e1c76271d2b") },
                    { new Guid("fb207434-670b-44de-9125-81a1310085a0"), 2600, 220, new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 63, 210, new Guid("1b4d438a-2db6-4214-8f78-5e532f1907be") }
                });

            migrationBuilder.InsertData(
                table: "ProgressLogs",
                columns: new[] { "Id", "Chest", "CurrentWeight", "Date", "Hips", "UserProfileId", "Waist" },
                values: new object[,]
                {
                    { new Guid("54e7fe86-4b0a-4e44-94f3-8ea4f621b93c"), 100m, 79.5m, new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), null, new Guid("9ebd1101-f550-4c12-bdb5-7e1c76271d2b"), 90m },
                    { new Guid("af1f7a9b-8c6e-4e4d-a0df-73045edbfa98"), null, 60.5m, new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 95m, new Guid("1b4d438a-2db6-4214-8f78-5e532f1907be"), null }
                });

            migrationBuilder.InsertData(
                table: "TargetNutritional",
                columns: new[] { "Id", "GoalId", "GoalName", "StartDate", "TargetCalories", "TargetCarbohydrates", "TargetFats", "TargetProtein", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("bb551cdf-3cb4-40fd-823b-a9396914987e"), new Guid("00000000-0000-0000-0000-000000000000"), "Gain muscle", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2500, 200, 60, 200, new Guid("1b4d438a-2db6-4214-8f78-5e532f1907be") },
                    { new Guid("d8536f53-5f12-4dec-9727-a0540531f88c"), new Guid("00000000-0000-0000-0000-000000000000"), "Lose weight", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2000, 100, 50, 150, new Guid("9ebd1101-f550-4c12-bdb5-7e1c76271d2b") }
                });

            migrationBuilder.InsertData(
                table: "WaterIntakes",
                columns: new[] { "Id", "Consumed", "DailyGoal", "Date", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("04783557-a686-48cd-82ab-63a8780e13c0"), 2.8f, 3f, new DateTime(2024, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1b4d438a-2db6-4214-8f78-5e532f1907be") },
                    { new Guid("c635853e-30b0-4c8e-8cf2-3ffa9c2d8ad1"), 2f, 2.5f, new DateTime(2024, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9ebd1101-f550-4c12-bdb5-7e1c76271d2b") }
                });

            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "Id", "Description", "Duration", "Name", "ScheduleDateTime", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("46f11e13-a190-4cbd-afd3-bd4c9f8cfed3"), "High-intensity cardio for fat burn.", 45, "Evening Cardio", new DateTime(2024, 12, 4, 2, 36, 22, 725, DateTimeKind.Local).AddTicks(1421), new Guid("9ebd1101-f550-4c12-bdb5-7e1c76271d2b") },
                    { new Guid("8b98786a-766f-4afa-a99c-7e82e18df2a9"), "A full-body workout to start the day.", 60, "Morning Strength", new DateTime(2024, 12, 4, 0, 36, 22, 725, DateTimeKind.Local).AddTicks(2412), new Guid("1b4d438a-2db6-4214-8f78-5e532f1907be") }
                });

            migrationBuilder.InsertData(
                table: "WorkoutExercises",
                columns: new[] { "ExerciseId", "WorkoutId", "Reps", "Sets" },
                values: new object[,]
                {
                    { new Guid("733c92ea-f43c-467f-a35c-d14f849efefa"), new Guid("46f11e13-a190-4cbd-afd3-bd4c9f8cfed3"), 15, 4 },
                    { new Guid("730fb7ce-adb1-4570-a818-4f96be3522f8"), new Guid("8b98786a-766f-4afa-a99c-7e82e18df2a9"), 10, 3 }
                });
        }
    }
}
