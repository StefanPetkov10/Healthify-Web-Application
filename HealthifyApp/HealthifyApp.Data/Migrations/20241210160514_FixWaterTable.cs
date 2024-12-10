using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthifyApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixWaterTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Consumed",
                table: "WaterIntakes");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "WaterIntakes");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("6f4a58f0-3dfe-405f-a1b5-fc7970b4d6ac"), 0, "959d6643-c4d4-4b6e-b38c-a949623d23c8", "user2@example.com", true, false, null, "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEAyyaHSQ/p4uQH3ZCPHqIiMAGoohkXt5FkYCv7DIsJkSwy2d5K+h8FsOzX201n3mrA==", null, false, "e033aa7d-6c71-462a-b14d-195279dfbb94", false, "User2" },
                    { new Guid("fee060ea-585b-4f6d-936c-c2a16864d550"), 0, "af59cb6d-c4a5-4ab9-a981-3d8b31080e0d", "user1@example.com", true, false, null, "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEPA44XnlXoowIMCk12UhQPu9MeqkA/psAYbnPWqMfM/fhTAwKWIfok5TbM3L3fKwTw==", null, false, "7f5c92ca-1710-420f-979e-4e9bde03287d", false, "User1" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Duration", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("b4092117-d761-4c9c-8cee-210e8ae30ab2"), "A lower body exercise for strength and endurance.", 40, "https://weighttraining.guide/wp-content/uploads/2016/10/barbell-squat-resized-FIXED-2.png", "Squat" },
                    { new Guid("de3eca93-36b4-4ac4-a9cf-28d42c3b76bd"), "A bodyweight exercise for upper body strength.", 30, "https://anabolicaliens.com/cdn/shop/articles/199990_400x.png?v=1645089103", "Push-Up" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Age", "CreatedOn", "FirstName", "Gender", "Height", "IsActiveProfile", "LastName", "StartingWeight" },
                values: new object[,]
                {
                    { new Guid("8b718d81-de0f-4836-977d-2bb1fb760765"), 25, new DateTime(2024, 12, 10, 18, 5, 11, 610, DateTimeKind.Local).AddTicks(3333), "Jane", 2, 165m, true, "Smith", 60m },
                    { new Guid("fe6c9d13-b776-490a-af4d-89de75866877"), 30, new DateTime(2024, 12, 10, 18, 5, 11, 608, DateTimeKind.Local).AddTicks(5588), "John", 1, 180m, true, "Doe", 80m }
                });

            migrationBuilder.InsertData(
                table: "ApplicationUserProfiles",
                columns: new[] { "ApplicationUserId", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("6f4a58f0-3dfe-405f-a1b5-fc7970b4d6ac"), new Guid("8b718d81-de0f-4836-977d-2bb1fb760765") },
                    { new Guid("fee060ea-585b-4f6d-936c-c2a16864d550"), new Guid("fe6c9d13-b776-490a-af4d-89de75866877") }
                });

            migrationBuilder.InsertData(
                table: "BMICalculations",
                columns: new[] { "Id", "BMI", "Category", "Date", "Height", "UserProfileId", "Weight" },
                values: new object[,]
                {
                    { new Guid("252c08d3-661d-4b54-b80a-f66f46fa45df"), 22m, 2, new DateTime(2024, 12, 10, 18, 5, 11, 611, DateTimeKind.Local).AddTicks(2265), 165m, new Guid("8b718d81-de0f-4836-977d-2bb1fb760765"), 60.6m },
                    { new Guid("75ff4ade-9eca-4ab9-9b38-ebdb08c238e5"), 24.7m, 2, new DateTime(2024, 12, 10, 18, 5, 11, 611, DateTimeKind.Local).AddTicks(1190), 180m, new Guid("fe6c9d13-b776-490a-af4d-89de75866877"), 80m }
                });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "Activity", "GoalChest", "GoalHips", "GoalType", "GoalWaist", "GoalWeight", "StartDate", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("8a899892-7f81-4fdb-b7b7-51c9cc4f2a14"), 4, null, 97f, 2, null, 67m, new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8b718d81-de0f-4836-977d-2bb1fb760765") },
                    { new Guid("d93028d2-790c-46f7-9e56-5ed7a17cf8c7"), 3, 95f, null, 1, 85f, 75m, new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fe6c9d13-b776-490a-af4d-89de75866877") }
                });

            migrationBuilder.InsertData(
                table: "NutritionIntake",
                columns: new[] { "Id", "Calories", "Carbohydrates", "Date", "Fats", "Protein", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("84a69615-231f-4898-b5b5-51c260b55926"), 2600, 220, new DateTime(2024, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), 63, 210, new Guid("8b718d81-de0f-4836-977d-2bb1fb760765") },
                    { new Guid("d51146c2-0377-4eb3-a274-83e750c16a90"), 1800, 90, new DateTime(2024, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), 45, 140, new Guid("fe6c9d13-b776-490a-af4d-89de75866877") }
                });

            migrationBuilder.InsertData(
                table: "ProgressLogs",
                columns: new[] { "Id", "Chest", "CurrentWeight", "Date", "Hips", "UserProfileId", "Waist" },
                values: new object[,]
                {
                    { new Guid("36cfd717-eb95-4bc2-96b0-6c43115bd093"), 100m, 79.5m, new DateTime(2024, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), null, new Guid("fe6c9d13-b776-490a-af4d-89de75866877"), 90m },
                    { new Guid("8ef92cc7-73c2-42f5-b20f-8f5ae99d736e"), null, 60.5m, new DateTime(2024, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), 95m, new Guid("8b718d81-de0f-4836-977d-2bb1fb760765"), null }
                });

            migrationBuilder.InsertData(
                table: "TargetNutritional",
                columns: new[] { "Id", "GoalId", "GoalName", "StartDate", "TargetCalories", "TargetCarbohydrates", "TargetFats", "TargetProtein", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("00e2a268-5604-4172-ac0d-0d2409124676"), new Guid("00000000-0000-0000-0000-000000000000"), "Gain muscle", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2500, 200, 60, 200, new Guid("8b718d81-de0f-4836-977d-2bb1fb760765") },
                    { new Guid("5e644660-8046-4b62-9706-fe556cd6888c"), new Guid("00000000-0000-0000-0000-000000000000"), "Lose weight", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2000, 100, 50, 150, new Guid("fe6c9d13-b776-490a-af4d-89de75866877") }
                });

            migrationBuilder.InsertData(
                table: "WaterIntakes",
                columns: new[] { "Id", "DailyGoal", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("49f20023-71f0-4c4d-9b82-51b6f8e9db4d"), 3f, new Guid("8b718d81-de0f-4836-977d-2bb1fb760765") },
                    { new Guid("57327f74-48ae-412d-8f98-90c0c7830a1d"), 2.5f, new Guid("fe6c9d13-b776-490a-af4d-89de75866877") }
                });

            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "Id", "Description", "Duration", "Name", "ScheduleDateTime", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("a201966b-ba34-4787-84cf-12d339df5ee6"), "High-intensity cardio for fat burn.", 45, "Evening Cardio", new DateTime(2024, 12, 10, 21, 5, 11, 612, DateTimeKind.Local).AddTicks(6064), new Guid("fe6c9d13-b776-490a-af4d-89de75866877") },
                    { new Guid("b6a272b8-884e-4dfd-bd9b-e90b3627ce5d"), "A full-body workout to start the day.", 60, "Morning Strength", new DateTime(2024, 12, 10, 19, 5, 11, 612, DateTimeKind.Local).AddTicks(6526), new Guid("8b718d81-de0f-4836-977d-2bb1fb760765") }
                });

            migrationBuilder.InsertData(
                table: "WorkoutExercises",
                columns: new[] { "ExerciseId", "WorkoutId", "Reps", "Sets" },
                values: new object[,]
                {
                    { new Guid("b4092117-d761-4c9c-8cee-210e8ae30ab2"), new Guid("a201966b-ba34-4787-84cf-12d339df5ee6"), 15, 4 },
                    { new Guid("de3eca93-36b4-4ac4-a9cf-28d42c3b76bd"), new Guid("b6a272b8-884e-4dfd-bd9b-e90b3627ce5d"), 10, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationUserProfiles",
                keyColumns: new[] { "ApplicationUserId", "UserProfileId" },
                keyValues: new object[] { new Guid("6f4a58f0-3dfe-405f-a1b5-fc7970b4d6ac"), new Guid("8b718d81-de0f-4836-977d-2bb1fb760765") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserProfiles",
                keyColumns: new[] { "ApplicationUserId", "UserProfileId" },
                keyValues: new object[] { new Guid("fee060ea-585b-4f6d-936c-c2a16864d550"), new Guid("fe6c9d13-b776-490a-af4d-89de75866877") });

            migrationBuilder.DeleteData(
                table: "BMICalculations",
                keyColumn: "Id",
                keyValue: new Guid("252c08d3-661d-4b54-b80a-f66f46fa45df"));

            migrationBuilder.DeleteData(
                table: "BMICalculations",
                keyColumn: "Id",
                keyValue: new Guid("75ff4ade-9eca-4ab9-9b38-ebdb08c238e5"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("8a899892-7f81-4fdb-b7b7-51c9cc4f2a14"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("d93028d2-790c-46f7-9e56-5ed7a17cf8c7"));

            migrationBuilder.DeleteData(
                table: "NutritionIntake",
                keyColumn: "Id",
                keyValue: new Guid("84a69615-231f-4898-b5b5-51c260b55926"));

            migrationBuilder.DeleteData(
                table: "NutritionIntake",
                keyColumn: "Id",
                keyValue: new Guid("d51146c2-0377-4eb3-a274-83e750c16a90"));

            migrationBuilder.DeleteData(
                table: "ProgressLogs",
                keyColumn: "Id",
                keyValue: new Guid("36cfd717-eb95-4bc2-96b0-6c43115bd093"));

            migrationBuilder.DeleteData(
                table: "ProgressLogs",
                keyColumn: "Id",
                keyValue: new Guid("8ef92cc7-73c2-42f5-b20f-8f5ae99d736e"));

            migrationBuilder.DeleteData(
                table: "TargetNutritional",
                keyColumn: "Id",
                keyValue: new Guid("00e2a268-5604-4172-ac0d-0d2409124676"));

            migrationBuilder.DeleteData(
                table: "TargetNutritional",
                keyColumn: "Id",
                keyValue: new Guid("5e644660-8046-4b62-9706-fe556cd6888c"));

            migrationBuilder.DeleteData(
                table: "WaterIntakes",
                keyColumn: "Id",
                keyValue: new Guid("49f20023-71f0-4c4d-9b82-51b6f8e9db4d"));

            migrationBuilder.DeleteData(
                table: "WaterIntakes",
                keyColumn: "Id",
                keyValue: new Guid("57327f74-48ae-412d-8f98-90c0c7830a1d"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumns: new[] { "ExerciseId", "WorkoutId" },
                keyValues: new object[] { new Guid("b4092117-d761-4c9c-8cee-210e8ae30ab2"), new Guid("a201966b-ba34-4787-84cf-12d339df5ee6") });

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumns: new[] { "ExerciseId", "WorkoutId" },
                keyValues: new object[] { new Guid("de3eca93-36b4-4ac4-a9cf-28d42c3b76bd"), new Guid("b6a272b8-884e-4dfd-bd9b-e90b3627ce5d") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6f4a58f0-3dfe-405f-a1b5-fc7970b4d6ac"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fee060ea-585b-4f6d-936c-c2a16864d550"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b4092117-d761-4c9c-8cee-210e8ae30ab2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("de3eca93-36b4-4ac4-a9cf-28d42c3b76bd"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("a201966b-ba34-4787-84cf-12d339df5ee6"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("b6a272b8-884e-4dfd-bd9b-e90b3627ce5d"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("8b718d81-de0f-4836-977d-2bb1fb760765"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("fe6c9d13-b776-490a-af4d-89de75866877"));

            migrationBuilder.AddColumn<float>(
                name: "Consumed",
                table: "WaterIntakes",
                type: "real",
                nullable: true,
                comment: "The consumed water of the user.");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "WaterIntakes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "The date of the water intake.");

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
    }
}
