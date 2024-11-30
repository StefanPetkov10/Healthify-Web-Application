using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthifyApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddIsActiveProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsActiveProfile",
                table: "UserProfiles",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "indicates whether the profile is active");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("280462df-4b36-4a92-b402-f48fb9e814e9"), 0, "a3409e34-9010-4940-ac48-d93bcc65e365", "user2@example.com", true, false, null, "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEK4DdN12lGgi0NwAL25M+5C0pEP+5/lKPwS9IiVFC1LbwNIe2OllBKRWHP7OBZ/QPA==", null, false, "b7671368-2284-4ccf-9aad-9a1f065fc8ae", false, "User2" },
                    { new Guid("c4963ef5-f66f-4e1b-9c9a-4069ed739808"), 0, "c0eb33ea-bd47-4bf1-acf1-03bcf89d9300", "user1@example.com", true, false, null, "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEFckZaDyEuRCgHXomgNjxPV+8135F5I1yocPxKRNq4D7hKvGFkuXT9rcXBOly7UWIQ==", null, false, "3d9bb4f8-341a-428e-b20a-16f143705ed1", false, "User1" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Duration", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("196a4184-c6fc-4494-bcac-2e17919b2c4c"), "A bodyweight exercise for upper body strength.", 30, "https://anabolicaliens.com/cdn/shop/articles/199990_400x.png?v=1645089103", "Push-Up" },
                    { new Guid("974e9458-5ad3-41b7-8f8a-ede542e60351"), "A lower body exercise for strength and endurance.", 40, "https://weighttraining.guide/wp-content/uploads/2016/10/barbell-squat-resized-FIXED-2.png", "Squat" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Age", "CreatedOn", "FirstName", "Gender", "Height", "LastName", "StartingWeight" },
                values: new object[,]
                {
                    { new Guid("589717fc-f83e-4508-8285-cd4fc122e643"), 30, new DateTime(2024, 11, 30, 15, 27, 8, 173, DateTimeKind.Local).AddTicks(7082), "John", 1, 180m, "Doe", 80m },
                    { new Guid("d6cc94ec-0d61-4270-9675-db69747f668a"), 25, new DateTime(2024, 11, 30, 15, 27, 8, 175, DateTimeKind.Local).AddTicks(3170), "Jane", 2, 165m, "Smith", 60m }
                });

            migrationBuilder.InsertData(
                table: "BMICalculations",
                columns: new[] { "Id", "BMI", "Category", "Date", "Height", "UserProfileId", "Weight" },
                values: new object[,]
                {
                    { new Guid("1187cead-9ab2-4548-a6f3-2a2899c745c5"), 22m, 2, new DateTime(2024, 11, 30, 15, 27, 8, 175, DateTimeKind.Local).AddTicks(6640), 165m, new Guid("d6cc94ec-0d61-4270-9675-db69747f668a"), 60.6m },
                    { new Guid("30f417cd-df6c-4d97-b9c9-22b6e1182aad"), 24.7m, 2, new DateTime(2024, 11, 30, 15, 27, 8, 175, DateTimeKind.Local).AddTicks(5571), 180m, new Guid("589717fc-f83e-4508-8285-cd4fc122e643"), 80m }
                });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "Activity", "GoalChest", "GoalHips", "GoalType", "GoalWaist", "GoalWeight", "StartDate", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("e500bc8d-2a67-4489-a75e-6df676349783"), 3, 95f, null, 1, 85f, 75m, new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("589717fc-f83e-4508-8285-cd4fc122e643") },
                    { new Guid("f0338082-3da6-4e8f-923c-f6ccd58a2dbc"), 4, null, 97f, 2, null, 67m, new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d6cc94ec-0d61-4270-9675-db69747f668a") }
                });

            migrationBuilder.InsertData(
                table: "NutritionIntake",
                columns: new[] { "Id", "Calories", "Carbohydrates", "Date", "Fats", "Protein", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("6e55713b-6ddf-4203-9f59-8eff6b6bcb13"), 2600, 220, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), 63, 210, new Guid("d6cc94ec-0d61-4270-9675-db69747f668a") },
                    { new Guid("73094126-8b68-43e2-aba8-a6cf2de0b8c8"), 1800, 90, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), 45, 140, new Guid("589717fc-f83e-4508-8285-cd4fc122e643") }
                });

            migrationBuilder.InsertData(
                table: "ProgressLogs",
                columns: new[] { "Id", "Chest", "CurrentWeight", "Date", "Hips", "UserProfileId", "Waist" },
                values: new object[,]
                {
                    { new Guid("32ae715a-6997-417c-b8e4-7e128ff69ea0"), 100m, 79.5m, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), null, new Guid("589717fc-f83e-4508-8285-cd4fc122e643"), 90m },
                    { new Guid("421cde2b-86d5-4fea-8e03-5d957d0c1723"), null, 60.5m, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), 95m, new Guid("d6cc94ec-0d61-4270-9675-db69747f668a"), null }
                });

            migrationBuilder.InsertData(
                table: "TargetNutritional",
                columns: new[] { "Id", "GoalName", "StartDate", "TargetCalories", "TargetCarbohydrates", "TargetFats", "TargetProtein", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("a1a11c85-181e-41cb-ad87-c67df73370ae"), "Gain muscle", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2500, 200, 60, 200, new Guid("d6cc94ec-0d61-4270-9675-db69747f668a") },
                    { new Guid("fb16baf6-fcda-4258-a7b0-74b137c951d8"), "Lose weight", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2000, 100, 50, 150, new Guid("589717fc-f83e-4508-8285-cd4fc122e643") }
                });

            migrationBuilder.InsertData(
                table: "WaterIntakes",
                columns: new[] { "Id", "Consumed", "DailyGoal", "Date", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("143beb73-da35-4863-b00f-dabc4575e749"), 2.8f, 3f, new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d6cc94ec-0d61-4270-9675-db69747f668a") },
                    { new Guid("70bc9bd8-6b26-42aa-8f67-a90737fe5048"), 2f, 2.5f, new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("589717fc-f83e-4508-8285-cd4fc122e643") }
                });

            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "Id", "Description", "Duration", "Name", "ScheduleDateTime", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("9564d316-1063-4349-a017-8e47976b4c3e"), "High-intensity cardio for fat burn.", 45, "Evening Cardio", new DateTime(2024, 11, 30, 18, 27, 8, 177, DateTimeKind.Local).AddTicks(4452), new Guid("589717fc-f83e-4508-8285-cd4fc122e643") },
                    { new Guid("be3a2fc8-6cc3-42e6-b697-80acd206d659"), "A full-body workout to start the day.", 60, "Morning Strength", new DateTime(2024, 11, 30, 16, 27, 8, 177, DateTimeKind.Local).AddTicks(4917), new Guid("d6cc94ec-0d61-4270-9675-db69747f668a") }
                });

            migrationBuilder.InsertData(
                table: "WorkoutExercises",
                columns: new[] { "ExerciseId", "WorkoutId", "Reps", "Sets" },
                values: new object[,]
                {
                    { new Guid("974e9458-5ad3-41b7-8f8a-ede542e60351"), new Guid("9564d316-1063-4349-a017-8e47976b4c3e"), 15, 4 },
                    { new Guid("196a4184-c6fc-4494-bcac-2e17919b2c4c"), new Guid("be3a2fc8-6cc3-42e6-b697-80acd206d659"), 10, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("280462df-4b36-4a92-b402-f48fb9e814e9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c4963ef5-f66f-4e1b-9c9a-4069ed739808"));

            migrationBuilder.DeleteData(
                table: "BMICalculations",
                keyColumn: "Id",
                keyValue: new Guid("1187cead-9ab2-4548-a6f3-2a2899c745c5"));

            migrationBuilder.DeleteData(
                table: "BMICalculations",
                keyColumn: "Id",
                keyValue: new Guid("30f417cd-df6c-4d97-b9c9-22b6e1182aad"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("e500bc8d-2a67-4489-a75e-6df676349783"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("f0338082-3da6-4e8f-923c-f6ccd58a2dbc"));

            migrationBuilder.DeleteData(
                table: "NutritionIntake",
                keyColumn: "Id",
                keyValue: new Guid("6e55713b-6ddf-4203-9f59-8eff6b6bcb13"));

            migrationBuilder.DeleteData(
                table: "NutritionIntake",
                keyColumn: "Id",
                keyValue: new Guid("73094126-8b68-43e2-aba8-a6cf2de0b8c8"));

            migrationBuilder.DeleteData(
                table: "ProgressLogs",
                keyColumn: "Id",
                keyValue: new Guid("32ae715a-6997-417c-b8e4-7e128ff69ea0"));

            migrationBuilder.DeleteData(
                table: "ProgressLogs",
                keyColumn: "Id",
                keyValue: new Guid("421cde2b-86d5-4fea-8e03-5d957d0c1723"));

            migrationBuilder.DeleteData(
                table: "TargetNutritional",
                keyColumn: "Id",
                keyValue: new Guid("a1a11c85-181e-41cb-ad87-c67df73370ae"));

            migrationBuilder.DeleteData(
                table: "TargetNutritional",
                keyColumn: "Id",
                keyValue: new Guid("fb16baf6-fcda-4258-a7b0-74b137c951d8"));

            migrationBuilder.DeleteData(
                table: "WaterIntakes",
                keyColumn: "Id",
                keyValue: new Guid("143beb73-da35-4863-b00f-dabc4575e749"));

            migrationBuilder.DeleteData(
                table: "WaterIntakes",
                keyColumn: "Id",
                keyValue: new Guid("70bc9bd8-6b26-42aa-8f67-a90737fe5048"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumns: new[] { "ExerciseId", "WorkoutId" },
                keyValues: new object[] { new Guid("974e9458-5ad3-41b7-8f8a-ede542e60351"), new Guid("9564d316-1063-4349-a017-8e47976b4c3e") });

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumns: new[] { "ExerciseId", "WorkoutId" },
                keyValues: new object[] { new Guid("196a4184-c6fc-4494-bcac-2e17919b2c4c"), new Guid("be3a2fc8-6cc3-42e6-b697-80acd206d659") });

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("196a4184-c6fc-4494-bcac-2e17919b2c4c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("974e9458-5ad3-41b7-8f8a-ede542e60351"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("9564d316-1063-4349-a017-8e47976b4c3e"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("be3a2fc8-6cc3-42e6-b697-80acd206d659"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("589717fc-f83e-4508-8285-cd4fc122e643"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("d6cc94ec-0d61-4270-9675-db69747f668a"));

            migrationBuilder.DropColumn(
                name: "IsActiveProfile",
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
    }
}
