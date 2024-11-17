using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthifyApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixGoals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cbc6eb6e-b088-4ace-8998-89f20f2e63e0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f8e3d6ef-b845-4f68-809f-903b4eebe17c"));

            migrationBuilder.DeleteData(
                table: "BMICalculations",
                keyColumn: "Id",
                keyValue: new Guid("701a3e82-ab99-410a-bd73-108f14aa71fc"));

            migrationBuilder.DeleteData(
                table: "BMICalculations",
                keyColumn: "Id",
                keyValue: new Guid("ac8f57ad-e5d5-44d7-924f-0d4dfafeee24"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("4e120da0-b13a-475a-a4e9-a2a7355a955d"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("e2c89690-cced-45d6-a37c-5ea88904f4bd"));

            migrationBuilder.DeleteData(
                table: "NutritionIntake",
                keyColumn: "Id",
                keyValue: new Guid("0eb579c0-1f8e-4144-af7f-2b35b733e834"));

            migrationBuilder.DeleteData(
                table: "NutritionIntake",
                keyColumn: "Id",
                keyValue: new Guid("4f880f3f-a7d5-49a4-8eed-8cc2efe88f96"));

            migrationBuilder.DeleteData(
                table: "ProgressLogs",
                keyColumn: "Id",
                keyValue: new Guid("b8c71914-5801-4817-b1a3-342d83410140"));

            migrationBuilder.DeleteData(
                table: "ProgressLogs",
                keyColumn: "Id",
                keyValue: new Guid("f2f4aaf4-fed7-4613-8967-15764699343d"));

            migrationBuilder.DeleteData(
                table: "TargetNutritional",
                keyColumn: "Id",
                keyValue: new Guid("1c28b388-6b9d-4b78-ac96-6c75edaf0194"));

            migrationBuilder.DeleteData(
                table: "TargetNutritional",
                keyColumn: "Id",
                keyValue: new Guid("3a0d672b-bc49-4059-a92a-7f28919c815a"));

            migrationBuilder.DeleteData(
                table: "WaterIntakes",
                keyColumn: "Id",
                keyValue: new Guid("dbb27d17-7228-4ffe-8046-b7dd2c0b744e"));

            migrationBuilder.DeleteData(
                table: "WaterIntakes",
                keyColumn: "Id",
                keyValue: new Guid("f16b6fe6-335d-4d15-bbeb-25a056ed17c8"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumns: new[] { "ExerciseId", "WorkoutId" },
                keyValues: new object[] { new Guid("9508b525-23cb-4207-9bee-a6bd9f47b436"), new Guid("2a13a883-62f6-47ed-a9ef-1cc05229e0a8") });

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumns: new[] { "ExerciseId", "WorkoutId" },
                keyValues: new object[] { new Guid("9ebe6c6a-cba0-4ee9-9fc6-2ea99127b87f"), new Guid("baa6fa48-d77e-4718-850d-ffaf3c93a020") });

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9508b525-23cb-4207-9bee-a6bd9f47b436"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9ebe6c6a-cba0-4ee9-9fc6-2ea99127b87f"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("2a13a883-62f6-47ed-a9ef-1cc05229e0a8"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("baa6fa48-d77e-4718-850d-ffaf3c93a020"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("c37fb5fb-08af-49ec-ab62-b582e33f34a0"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("ca43940e-b816-47db-a7c6-5663e0886763"));

            migrationBuilder.DropColumn(
                name: "Goals",
                table: "UserProfiles");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("a64551f7-e959-4e9a-b47e-b53ae4942e48"), 0, "86e10789-3b01-4dcf-a5a4-2327ffdb8ca1", "user1@example.com", true, false, null, "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEPec4Gfx1uB+4+xwkyiy4yLCRbJmJxUTjChYp3BXCfuLnjX4ZY+K1vIDV70KNC4ESA==", null, false, "00dc2d4d-62de-49a6-be08-e6f0676b1b5a", false, "User1" },
                    { new Guid("ea3d4530-1fb8-4637-8ad8-f73823c3da65"), 0, "7f828c90-efbe-4fd8-b564-d25170d7e559", "user2@example.com", true, false, null, "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEDdTAK4ZT330sUJuJrT1tEiZ2Pg7Ptc5Pz8KAtQhUI94irEuCMMi8AiMkrJxQ+rnvw==", null, false, "dab005c9-9775-46fc-a466-3a26e1e8e46f", false, "User2" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Duration", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("67f57b02-70e3-4842-8436-5a03f51af1fd"), "A bodyweight exercise for upper body strength.", 30, "https://anabolicaliens.com/cdn/shop/articles/199990_400x.png?v=1645089103", "Push-Up" },
                    { new Guid("e40cf45d-dc92-4d3c-a930-1718715c78e5"), "A lower body exercise for strength and endurance.", 40, "https://weighttraining.guide/wp-content/uploads/2016/10/barbell-squat-resized-FIXED-2.png", "Squat" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Age", "CreatedOn", "FirstName", "Gender", "Height", "LastName", "StartingWeight" },
                values: new object[,]
                {
                    { new Guid("11333d17-07a8-4f4b-bbb1-084156ccf28a"), 30, new DateTime(2024, 11, 17, 17, 59, 43, 320, DateTimeKind.Local).AddTicks(1534), "John", 1, 180m, "Doe", 80m },
                    { new Guid("216ba503-b49c-4a19-b6e7-6519097f52b3"), 25, new DateTime(2024, 11, 17, 17, 59, 43, 322, DateTimeKind.Local).AddTicks(410), "Jane", 2, 165m, "Smith", 60m }
                });

            migrationBuilder.InsertData(
                table: "BMICalculations",
                columns: new[] { "Id", "BMI", "Category", "Date", "Height", "UserProfileId", "Weight" },
                values: new object[,]
                {
                    { new Guid("1cf90b0d-017a-4fb1-958a-a8d2beea5887"), 22m, 2, new DateTime(2024, 11, 17, 17, 59, 43, 322, DateTimeKind.Local).AddTicks(4733), 165m, new Guid("216ba503-b49c-4a19-b6e7-6519097f52b3"), 60.6m },
                    { new Guid("4f4e12c7-fc4f-4791-bbd3-55814398283a"), 24.7m, 2, new DateTime(2024, 11, 17, 17, 59, 43, 322, DateTimeKind.Local).AddTicks(3333), 180m, new Guid("11333d17-07a8-4f4b-bbb1-084156ccf28a"), 80m }
                });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "Activity", "GoalChest", "GoalHips", "GoalType", "GoalWaist", "GoalWeight", "StartDate", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("2377782a-71bc-4d3f-a107-a94000c4d8ee"), 3, 95f, null, 1, 85f, 75m, new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("11333d17-07a8-4f4b-bbb1-084156ccf28a") },
                    { new Guid("9c577d63-6fb3-441a-a144-3d1d83628c33"), 4, null, 97f, 2, null, 67m, new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("216ba503-b49c-4a19-b6e7-6519097f52b3") }
                });

            migrationBuilder.InsertData(
                table: "NutritionIntake",
                columns: new[] { "Id", "Calories", "Carbohydrates", "Date", "Fats", "Protein", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("17545fb8-057d-4bee-a7d6-0e878dfc4843"), 1800, 90, new DateTime(2024, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), 45, 140, new Guid("11333d17-07a8-4f4b-bbb1-084156ccf28a") },
                    { new Guid("d4569749-0cd4-4cf5-a0c5-64164596ff74"), 2600, 220, new DateTime(2024, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), 63, 210, new Guid("216ba503-b49c-4a19-b6e7-6519097f52b3") }
                });

            migrationBuilder.InsertData(
                table: "ProgressLogs",
                columns: new[] { "Id", "Chest", "CurrentWeight", "Date", "Hips", "UserProfileId", "Waist" },
                values: new object[,]
                {
                    { new Guid("315a3fde-63b2-458a-a8d3-5fa2203c3841"), 100m, 79.5m, new DateTime(2024, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), null, new Guid("11333d17-07a8-4f4b-bbb1-084156ccf28a"), 90m },
                    { new Guid("85c2bd47-1f95-4110-8577-0a908b85840b"), null, 60.5m, new DateTime(2024, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), 95m, new Guid("216ba503-b49c-4a19-b6e7-6519097f52b3"), null }
                });

            migrationBuilder.InsertData(
                table: "TargetNutritional",
                columns: new[] { "Id", "GoalName", "StartDate", "TargetCalories", "TargetCarbohydrates", "TargetFats", "TargetProtein", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("171036f9-b33e-4639-9de8-2042c252b32c"), "Lose weight", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2000, 100, 50, 150, new Guid("11333d17-07a8-4f4b-bbb1-084156ccf28a") },
                    { new Guid("b1404078-44e9-4b18-a495-68fd0c2bfa3f"), "Gain muscle", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2500, 200, 60, 200, new Guid("216ba503-b49c-4a19-b6e7-6519097f52b3") }
                });

            migrationBuilder.InsertData(
                table: "WaterIntakes",
                columns: new[] { "Id", "Consumed", "DailyGoal", "Date", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("1ab5d703-d3a2-4ea3-890e-e787f09e4042"), 2.8f, 3f, new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("216ba503-b49c-4a19-b6e7-6519097f52b3") },
                    { new Guid("81a47d19-e344-424e-a2f4-e1884f6512aa"), 2f, 2.5f, new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("11333d17-07a8-4f4b-bbb1-084156ccf28a") }
                });

            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "Id", "Description", "Duration", "Name", "ScheduleDateTime", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("2c8e98eb-5cfe-410e-ac34-7fda72c3a9b6"), "High-intensity cardio for fat burn.", 45, "Evening Cardio", new DateTime(2024, 11, 17, 20, 59, 43, 324, DateTimeKind.Local).AddTicks(6115), new Guid("11333d17-07a8-4f4b-bbb1-084156ccf28a") },
                    { new Guid("b420e1d8-33d1-4b55-981c-83801cc59cdd"), "A full-body workout to start the day.", 60, "Morning Strength", new DateTime(2024, 11, 17, 18, 59, 43, 324, DateTimeKind.Local).AddTicks(7193), new Guid("216ba503-b49c-4a19-b6e7-6519097f52b3") }
                });

            migrationBuilder.InsertData(
                table: "WorkoutExercises",
                columns: new[] { "ExerciseId", "WorkoutId", "Reps", "Sets" },
                values: new object[,]
                {
                    { new Guid("e40cf45d-dc92-4d3c-a930-1718715c78e5"), new Guid("2c8e98eb-5cfe-410e-ac34-7fda72c3a9b6"), 15, 4 },
                    { new Guid("67f57b02-70e3-4842-8436-5a03f51af1fd"), new Guid("b420e1d8-33d1-4b55-981c-83801cc59cdd"), 10, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a64551f7-e959-4e9a-b47e-b53ae4942e48"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea3d4530-1fb8-4637-8ad8-f73823c3da65"));

            migrationBuilder.DeleteData(
                table: "BMICalculations",
                keyColumn: "Id",
                keyValue: new Guid("1cf90b0d-017a-4fb1-958a-a8d2beea5887"));

            migrationBuilder.DeleteData(
                table: "BMICalculations",
                keyColumn: "Id",
                keyValue: new Guid("4f4e12c7-fc4f-4791-bbd3-55814398283a"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("2377782a-71bc-4d3f-a107-a94000c4d8ee"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("9c577d63-6fb3-441a-a144-3d1d83628c33"));

            migrationBuilder.DeleteData(
                table: "NutritionIntake",
                keyColumn: "Id",
                keyValue: new Guid("17545fb8-057d-4bee-a7d6-0e878dfc4843"));

            migrationBuilder.DeleteData(
                table: "NutritionIntake",
                keyColumn: "Id",
                keyValue: new Guid("d4569749-0cd4-4cf5-a0c5-64164596ff74"));

            migrationBuilder.DeleteData(
                table: "ProgressLogs",
                keyColumn: "Id",
                keyValue: new Guid("315a3fde-63b2-458a-a8d3-5fa2203c3841"));

            migrationBuilder.DeleteData(
                table: "ProgressLogs",
                keyColumn: "Id",
                keyValue: new Guid("85c2bd47-1f95-4110-8577-0a908b85840b"));

            migrationBuilder.DeleteData(
                table: "TargetNutritional",
                keyColumn: "Id",
                keyValue: new Guid("171036f9-b33e-4639-9de8-2042c252b32c"));

            migrationBuilder.DeleteData(
                table: "TargetNutritional",
                keyColumn: "Id",
                keyValue: new Guid("b1404078-44e9-4b18-a495-68fd0c2bfa3f"));

            migrationBuilder.DeleteData(
                table: "WaterIntakes",
                keyColumn: "Id",
                keyValue: new Guid("1ab5d703-d3a2-4ea3-890e-e787f09e4042"));

            migrationBuilder.DeleteData(
                table: "WaterIntakes",
                keyColumn: "Id",
                keyValue: new Guid("81a47d19-e344-424e-a2f4-e1884f6512aa"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumns: new[] { "ExerciseId", "WorkoutId" },
                keyValues: new object[] { new Guid("e40cf45d-dc92-4d3c-a930-1718715c78e5"), new Guid("2c8e98eb-5cfe-410e-ac34-7fda72c3a9b6") });

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumns: new[] { "ExerciseId", "WorkoutId" },
                keyValues: new object[] { new Guid("67f57b02-70e3-4842-8436-5a03f51af1fd"), new Guid("b420e1d8-33d1-4b55-981c-83801cc59cdd") });

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("67f57b02-70e3-4842-8436-5a03f51af1fd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e40cf45d-dc92-4d3c-a930-1718715c78e5"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("2c8e98eb-5cfe-410e-ac34-7fda72c3a9b6"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("b420e1d8-33d1-4b55-981c-83801cc59cdd"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("11333d17-07a8-4f4b-bbb1-084156ccf28a"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("216ba503-b49c-4a19-b6e7-6519097f52b3"));

            migrationBuilder.AddColumn<string>(
                name: "Goals",
                table: "UserProfiles",
                type: "nvarchar(254)",
                maxLength: 254,
                nullable: false,
                defaultValue: "",
                comment: "The goals of the user.");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("cbc6eb6e-b088-4ace-8998-89f20f2e63e0"), 0, "4a3380b9-6908-4d72-9922-0fa0c78e8aac", "user2@example.com", true, false, null, "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEHosNTDjW2b12hVhRuqiAfDZC4YfBJl4F0EK/xIHxZkgnTa0SYBJxHC1L7ks7ga89Q==", null, false, "80c7e4f0-5070-41cc-adbe-9c4238570eaa", false, "User2" },
                    { new Guid("f8e3d6ef-b845-4f68-809f-903b4eebe17c"), 0, "2cf616aa-f920-49b3-8837-bcc071c977c4", "user1@example.com", true, false, null, "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEDpgltPNfZEotOWOcILJpWU4sVhH9uIeYuZYWUCekjbxBc8SrlI3ZK5RLd6k56jtBA==", null, false, "40b8d40d-44c4-46a7-9800-32820f792a3a", false, "User1" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Duration", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("9508b525-23cb-4207-9bee-a6bd9f47b436"), "A bodyweight exercise for upper body strength.", 30, "https://anabolicaliens.com/cdn/shop/articles/199990_400x.png?v=1645089103", "Push-Up" },
                    { new Guid("9ebe6c6a-cba0-4ee9-9fc6-2ea99127b87f"), "A lower body exercise for strength and endurance.", 40, "https://weighttraining.guide/wp-content/uploads/2016/10/barbell-squat-resized-FIXED-2.png", "Squat" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Age", "CreatedOn", "FirstName", "Gender", "Goals", "Height", "LastName", "StartingWeight" },
                values: new object[,]
                {
                    { new Guid("c37fb5fb-08af-49ec-ab62-b582e33f34a0"), 30, new DateTime(2024, 11, 17, 17, 49, 54, 370, DateTimeKind.Local).AddTicks(4911), "John", 1, "Lose weight", 180m, "Doe", 80m },
                    { new Guid("ca43940e-b816-47db-a7c6-5663e0886763"), 25, new DateTime(2024, 11, 17, 17, 49, 54, 382, DateTimeKind.Local).AddTicks(5128), "Jane", 2, "Gain muscle", 165m, "Smith", 60m }
                });

            migrationBuilder.InsertData(
                table: "BMICalculations",
                columns: new[] { "Id", "BMI", "Category", "Date", "Height", "UserProfileId", "Weight" },
                values: new object[,]
                {
                    { new Guid("701a3e82-ab99-410a-bd73-108f14aa71fc"), 22m, 2, new DateTime(2024, 11, 17, 17, 49, 54, 382, DateTimeKind.Local).AddTicks(8756), 165m, new Guid("ca43940e-b816-47db-a7c6-5663e0886763"), 60.6m },
                    { new Guid("ac8f57ad-e5d5-44d7-924f-0d4dfafeee24"), 24.7m, 2, new DateTime(2024, 11, 17, 17, 49, 54, 382, DateTimeKind.Local).AddTicks(7739), 180m, new Guid("c37fb5fb-08af-49ec-ab62-b582e33f34a0"), 80m }
                });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "Activity", "GoalChest", "GoalHips", "GoalType", "GoalWaist", "GoalWeight", "StartDate", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("4e120da0-b13a-475a-a4e9-a2a7355a955d"), 3, 95f, null, 1, 85f, 75m, new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c37fb5fb-08af-49ec-ab62-b582e33f34a0") },
                    { new Guid("e2c89690-cced-45d6-a37c-5ea88904f4bd"), 4, null, 97f, 2, null, 67m, new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ca43940e-b816-47db-a7c6-5663e0886763") }
                });

            migrationBuilder.InsertData(
                table: "NutritionIntake",
                columns: new[] { "Id", "Calories", "Carbohydrates", "Date", "Fats", "Protein", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("0eb579c0-1f8e-4144-af7f-2b35b733e834"), 2600, 220, new DateTime(2024, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), 63, 210, new Guid("ca43940e-b816-47db-a7c6-5663e0886763") },
                    { new Guid("4f880f3f-a7d5-49a4-8eed-8cc2efe88f96"), 1800, 90, new DateTime(2024, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), 45, 140, new Guid("c37fb5fb-08af-49ec-ab62-b582e33f34a0") }
                });

            migrationBuilder.InsertData(
                table: "ProgressLogs",
                columns: new[] { "Id", "Chest", "CurrentWeight", "Date", "Hips", "UserProfileId", "Waist" },
                values: new object[,]
                {
                    { new Guid("b8c71914-5801-4817-b1a3-342d83410140"), 100m, 79.5m, new DateTime(2024, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), null, new Guid("c37fb5fb-08af-49ec-ab62-b582e33f34a0"), 90m },
                    { new Guid("f2f4aaf4-fed7-4613-8967-15764699343d"), null, 60.5m, new DateTime(2024, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), 95m, new Guid("ca43940e-b816-47db-a7c6-5663e0886763"), null }
                });

            migrationBuilder.InsertData(
                table: "TargetNutritional",
                columns: new[] { "Id", "GoalName", "StartDate", "TargetCalories", "TargetCarbohydrates", "TargetFats", "TargetProtein", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("1c28b388-6b9d-4b78-ac96-6c75edaf0194"), "Lose weight", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2000, 100, 50, 150, new Guid("c37fb5fb-08af-49ec-ab62-b582e33f34a0") },
                    { new Guid("3a0d672b-bc49-4059-a92a-7f28919c815a"), "Gain muscle", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2500, 200, 60, 200, new Guid("ca43940e-b816-47db-a7c6-5663e0886763") }
                });

            migrationBuilder.InsertData(
                table: "WaterIntakes",
                columns: new[] { "Id", "Consumed", "DailyGoal", "Date", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("dbb27d17-7228-4ffe-8046-b7dd2c0b744e"), 2f, 2.5f, new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c37fb5fb-08af-49ec-ab62-b582e33f34a0") },
                    { new Guid("f16b6fe6-335d-4d15-bbeb-25a056ed17c8"), 2.8f, 3f, new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ca43940e-b816-47db-a7c6-5663e0886763") }
                });

            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "Id", "Description", "Duration", "Name", "ScheduleDateTime", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("2a13a883-62f6-47ed-a9ef-1cc05229e0a8"), "A full-body workout to start the day.", 60, "Morning Strength", new DateTime(2024, 11, 17, 18, 49, 54, 384, DateTimeKind.Local).AddTicks(6504), new Guid("ca43940e-b816-47db-a7c6-5663e0886763") },
                    { new Guid("baa6fa48-d77e-4718-850d-ffaf3c93a020"), "High-intensity cardio for fat burn.", 45, "Evening Cardio", new DateTime(2024, 11, 17, 20, 49, 54, 384, DateTimeKind.Local).AddTicks(6040), new Guid("c37fb5fb-08af-49ec-ab62-b582e33f34a0") }
                });

            migrationBuilder.InsertData(
                table: "WorkoutExercises",
                columns: new[] { "ExerciseId", "WorkoutId", "Reps", "Sets" },
                values: new object[,]
                {
                    { new Guid("9508b525-23cb-4207-9bee-a6bd9f47b436"), new Guid("2a13a883-62f6-47ed-a9ef-1cc05229e0a8"), 10, 3 },
                    { new Guid("9ebe6c6a-cba0-4ee9-9fc6-2ea99127b87f"), new Guid("baa6fa48-d77e-4718-850d-ffaf3c93a020"), 15, 4 }
                });
        }
    }
}
