using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthifyApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddGoalIdInTargetNutrition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "GoalId",
                table: "TargetNutritional",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                comment: "The goal ID.");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "GoalId",
                table: "TargetNutritional");

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
    }
}
