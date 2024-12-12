using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthifyApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixBMITable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Date",
                table: "BMICalculations");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "BMICalculations");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "BMICalculations");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "BMICalculations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "The date of the BMI calculation.");

            migrationBuilder.AddColumn<decimal>(
                name: "Height",
                table: "BMICalculations",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                comment: "The height of the user.");

            migrationBuilder.AddColumn<decimal>(
                name: "Weight",
                table: "BMICalculations",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                comment: "The weight of the user.");

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
    }
}
