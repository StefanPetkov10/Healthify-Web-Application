using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthifyApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("322c9f8a-ce94-4da8-8173-75a3ab472794"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bef10087-293c-4514-b812-c2a8ba0e295c"));

            migrationBuilder.DeleteData(
                table: "BMICalculations",
                keyColumn: "Id",
                keyValue: new Guid("9db48087-b8ea-453d-b903-891980da2588"));

            migrationBuilder.DeleteData(
                table: "BMICalculations",
                keyColumn: "Id",
                keyValue: new Guid("bc9826c6-f1d3-49cd-ab92-46a482b37ed7"));

            migrationBuilder.DeleteData(
                table: "NutritionPlans",
                keyColumn: "Id",
                keyValue: new Guid("8f62b3c6-6144-403a-b807-4eeba4d9ced4"));

            migrationBuilder.DeleteData(
                table: "NutritionPlans",
                keyColumn: "Id",
                keyValue: new Guid("df397e30-138d-4c13-93a2-804b363151d4"));

            migrationBuilder.DeleteData(
                table: "ProgressLogs",
                keyColumn: "Id",
                keyValue: new Guid("65516199-bc6d-499c-a890-f847f77b9a4e"));

            migrationBuilder.DeleteData(
                table: "ProgressLogs",
                keyColumn: "Id",
                keyValue: new Guid("88a269a4-04ec-4261-bce1-180c38e4b7c8"));

            migrationBuilder.DeleteData(
                table: "WaterIntakes",
                keyColumn: "Id",
                keyValue: new Guid("74342518-006c-4481-b0f4-a364d7bab704"));

            migrationBuilder.DeleteData(
                table: "WaterIntakes",
                keyColumn: "Id",
                keyValue: new Guid("eecd95b8-4eba-4b1c-ae97-12ae631ed1cf"));

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumns: new[] { "ExerciseId", "WorkoutId" },
                keyValues: new object[] { new Guid("8cb8d357-ed1d-42d1-8364-1c3fabac0e7a"), new Guid("091c601f-d440-4d86-9320-400ffc1eaf4d") });

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumns: new[] { "ExerciseId", "WorkoutId" },
                keyValues: new object[] { new Guid("9be33907-1925-4439-b4a0-9c692005d109"), new Guid("4330d8b8-7239-4d8e-9e9e-b9a142cb0a2f") });

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8cb8d357-ed1d-42d1-8364-1c3fabac0e7a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9be33907-1925-4439-b4a0-9c692005d109"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("091c601f-d440-4d86-9320-400ffc1eaf4d"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("4330d8b8-7239-4d8e-9e9e-b9a142cb0a2f"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("2acde129-f04a-4664-8b9e-8465025f4490"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("3f375560-c39f-4475-8f6d-56ad46b112fc"));

            migrationBuilder.AlterColumn<Guid>(
                name: "UserProfileId",
                table: "Workouts",
                type: "uniqueidentifier",
                nullable: false,
                comment: "The user profile ID.",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ScheduleDateTime",
                table: "Workouts",
                type: "datetime2",
                nullable: false,
                comment: "The schedule date and time of the workout.",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Workouts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Name of the workout.",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "Duration",
                table: "Workouts",
                type: "int",
                nullable: true,
                comment: "Duration of the workout in minutes.",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Workouts",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                comment: "Description of the workout.",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Workouts",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Primary key for the workout.",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserProfileId",
                table: "WaterIntakes",
                type: "uniqueidentifier",
                nullable: false,
                comment: "The user profile ID.",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "WaterIntakes",
                type: "datetime2",
                nullable: false,
                comment: "The date of the water intake.",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<float>(
                name: "DailyGoal",
                table: "WaterIntakes",
                type: "real",
                nullable: false,
                comment: "The daily goal of the water intake.",
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<float>(
                name: "Consumed",
                table: "WaterIntakes",
                type: "real",
                nullable: true,
                comment: "The consumed water of the user.",
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "WaterIntakes",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Primary key for the water intake.",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<decimal>(
                name: "Weight",
                table: "UserProfiles",
                type: "decimal(18,2)",
                nullable: false,
                comment: "The weight of the user.",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "UserProfiles",
                type: "nvarchar(57)",
                maxLength: 57,
                nullable: false,
                comment: "The last name of the user.",
                oldClrType: typeof(string),
                oldType: "nvarchar(57)",
                oldMaxLength: 57);

            migrationBuilder.AlterColumn<decimal>(
                name: "Height",
                table: "UserProfiles",
                type: "decimal(18,2)",
                nullable: false,
                comment: "The height of the user.",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Goals",
                table: "UserProfiles",
                type: "nvarchar(254)",
                maxLength: 254,
                nullable: false,
                comment: "The goals of the user.",
                oldClrType: typeof(string),
                oldType: "nvarchar(254)",
                oldMaxLength: 254);

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "UserProfiles",
                type: "int",
                nullable: false,
                comment: "The gender of the user",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "UserProfiles",
                type: "nvarchar(57)",
                maxLength: 57,
                nullable: false,
                comment: "The first name of the user.",
                oldClrType: typeof(string),
                oldType: "nvarchar(57)",
                oldMaxLength: 57);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "UserProfiles",
                type: "datetime2",
                nullable: false,
                comment: "The creation of the user account.",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "UserProfiles",
                type: "int",
                nullable: false,
                comment: "The age of the user.",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "UserProfiles",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Primary key for the user profile.",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<decimal>(
                name: "Weight",
                table: "ProgressLogs",
                type: "decimal(18,2)",
                nullable: false,
                comment: "The weight of the user.",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Waist",
                table: "ProgressLogs",
                type: "decimal(18,2)",
                nullable: true,
                comment: "The waist of the user.",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserProfileId",
                table: "ProgressLogs",
                type: "uniqueidentifier",
                nullable: false,
                comment: "The user profile ID.",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<decimal>(
                name: "Hips",
                table: "ProgressLogs",
                type: "decimal(18,2)",
                nullable: true,
                comment: "The hips of the user.",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "ProgressLogs",
                type: "datetime2",
                nullable: false,
                comment: "The date of the progress log.",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<decimal>(
                name: "Chest",
                table: "ProgressLogs",
                type: "decimal(18,2)",
                nullable: true,
                comment: "The chest of the user.",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "ProgressLogs",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Primary key for the progress log.",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserProfileId",
                table: "NutritionPlans",
                type: "uniqueidentifier",
                nullable: false,
                comment: "The user profile ID.",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "Protein",
                table: "NutritionPlans",
                type: "int",
                nullable: false,
                comment: "The protein should intake user.",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Goal",
                table: "NutritionPlans",
                type: "nvarchar(max)",
                nullable: false,
                comment: "The goal of the nutrition plan.",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Fats",
                table: "NutritionPlans",
                type: "int",
                nullable: false,
                comment: "The fats should intake user.",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Carbohydrates",
                table: "NutritionPlans",
                type: "int",
                nullable: false,
                comment: "The carbohydrates should intake user.",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Calories",
                table: "NutritionPlans",
                type: "int",
                nullable: false,
                comment: "The calories should intake user.",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "NutritionPlans",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Primary key for the nutrition plan.",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Exercises",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Name of the exercise.",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: true,
                comment: "URL of the image of the exercise.",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Duration",
                table: "Exercises",
                type: "int",
                maxLength: 240,
                nullable: true,
                comment: "Duration of the exercise in minutes.",
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 240,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Exercises",
                type: "nvarchar(254)",
                maxLength: 254,
                nullable: false,
                comment: "Description of the exercise.",
                oldClrType: typeof(string),
                oldType: "nvarchar(254)",
                oldMaxLength: 254);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Exercises",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Primary key for the exercise.",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<decimal>(
                name: "Weight",
                table: "BMICalculations",
                type: "decimal(18,2)",
                nullable: false,
                comment: "The weight of the user.",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserProfileId",
                table: "BMICalculations",
                type: "uniqueidentifier",
                nullable: false,
                comment: "The user profile ID.",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<decimal>(
                name: "Height",
                table: "BMICalculations",
                type: "decimal(18,2)",
                nullable: false,
                comment: "The height of the user.",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "BMICalculations",
                type: "datetime2",
                nullable: false,
                comment: "The date of the BMI calculation.",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "BMICalculations",
                type: "nvarchar(max)",
                nullable: false,
                comment: "The category of the BMI.",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "BMI",
                table: "BMICalculations",
                type: "decimal(18,2)",
                nullable: false,
                comment: "The BMI of the user.",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "BMICalculations",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Primary key for the BMI calculation.",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<Guid>(
                name: "UserProfileId",
                table: "Workouts",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "The user profile ID.");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ScheduleDateTime",
                table: "Workouts",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "The schedule date and time of the workout.");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Workouts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Name of the workout.");

            migrationBuilder.AlterColumn<int>(
                name: "Duration",
                table: "Workouts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Duration of the workout in minutes.");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Workouts",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldComment: "Description of the workout.");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Workouts",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Primary key for the workout.");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserProfileId",
                table: "WaterIntakes",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "The user profile ID.");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "WaterIntakes",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "The date of the water intake.");

            migrationBuilder.AlterColumn<float>(
                name: "DailyGoal",
                table: "WaterIntakes",
                type: "real",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real",
                oldComment: "The daily goal of the water intake.");

            migrationBuilder.AlterColumn<float>(
                name: "Consumed",
                table: "WaterIntakes",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true,
                oldComment: "The consumed water of the user.");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "WaterIntakes",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Primary key for the water intake.");

            migrationBuilder.AlterColumn<decimal>(
                name: "Weight",
                table: "UserProfiles",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldComment: "The weight of the user.");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "UserProfiles",
                type: "nvarchar(57)",
                maxLength: 57,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(57)",
                oldMaxLength: 57,
                oldComment: "The last name of the user.");

            migrationBuilder.AlterColumn<decimal>(
                name: "Height",
                table: "UserProfiles",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldComment: "The height of the user.");

            migrationBuilder.AlterColumn<string>(
                name: "Goals",
                table: "UserProfiles",
                type: "nvarchar(254)",
                maxLength: 254,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(254)",
                oldMaxLength: 254,
                oldComment: "The goals of the user.");

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "UserProfiles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "The gender of the user");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "UserProfiles",
                type: "nvarchar(57)",
                maxLength: 57,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(57)",
                oldMaxLength: 57,
                oldComment: "The first name of the user.");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "UserProfiles",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "The creation of the user account.");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "UserProfiles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "The age of the user.");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "UserProfiles",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Primary key for the user profile.");

            migrationBuilder.AlterColumn<decimal>(
                name: "Weight",
                table: "ProgressLogs",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldComment: "The weight of the user.");

            migrationBuilder.AlterColumn<decimal>(
                name: "Waist",
                table: "ProgressLogs",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true,
                oldComment: "The waist of the user.");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserProfileId",
                table: "ProgressLogs",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "The user profile ID.");

            migrationBuilder.AlterColumn<decimal>(
                name: "Hips",
                table: "ProgressLogs",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true,
                oldComment: "The hips of the user.");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "ProgressLogs",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "The date of the progress log.");

            migrationBuilder.AlterColumn<decimal>(
                name: "Chest",
                table: "ProgressLogs",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true,
                oldComment: "The chest of the user.");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "ProgressLogs",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Primary key for the progress log.");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserProfileId",
                table: "NutritionPlans",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "The user profile ID.");

            migrationBuilder.AlterColumn<int>(
                name: "Protein",
                table: "NutritionPlans",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "The protein should intake user.");

            migrationBuilder.AlterColumn<string>(
                name: "Goal",
                table: "NutritionPlans",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "The goal of the nutrition plan.");

            migrationBuilder.AlterColumn<int>(
                name: "Fats",
                table: "NutritionPlans",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "The fats should intake user.");

            migrationBuilder.AlterColumn<int>(
                name: "Carbohydrates",
                table: "NutritionPlans",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "The carbohydrates should intake user.");

            migrationBuilder.AlterColumn<int>(
                name: "Calories",
                table: "NutritionPlans",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "The calories should intake user.");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "NutritionPlans",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Primary key for the nutrition plan.");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Exercises",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Name of the exercise.");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "URL of the image of the exercise.");

            migrationBuilder.AlterColumn<int>(
                name: "Duration",
                table: "Exercises",
                type: "int",
                maxLength: 240,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 240,
                oldNullable: true,
                oldComment: "Duration of the exercise in minutes.");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Exercises",
                type: "nvarchar(254)",
                maxLength: 254,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(254)",
                oldMaxLength: 254,
                oldComment: "Description of the exercise.");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Exercises",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Primary key for the exercise.");

            migrationBuilder.AlterColumn<decimal>(
                name: "Weight",
                table: "BMICalculations",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldComment: "The weight of the user.");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserProfileId",
                table: "BMICalculations",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "The user profile ID.");

            migrationBuilder.AlterColumn<decimal>(
                name: "Height",
                table: "BMICalculations",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldComment: "The height of the user.");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "BMICalculations",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "The date of the BMI calculation.");

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "BMICalculations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "The category of the BMI.");

            migrationBuilder.AlterColumn<decimal>(
                name: "BMI",
                table: "BMICalculations",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldComment: "The BMI of the user.");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "BMICalculations",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Primary key for the BMI calculation.");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("322c9f8a-ce94-4da8-8173-75a3ab472794"), 0, "b0cd092b-fe3c-4e6f-b70c-af8caa07980d", "user1@example.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEHKcqEozg598M2hrNJOm98tH+atmqzqjHz1DT2iE5APw7rZUV+RHrljsLfjNLW1baw==", null, false, null, false, "User1" },
                    { new Guid("bef10087-293c-4514-b812-c2a8ba0e295c"), 0, "b89a1a6b-c2f6-4ffb-bd8b-6386bf9bd866", "user2@example.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEMX665ckHYaD0ClBZ8kpfXWoIZUm+f/aNMxu5e7DLSunRFUlGOh0RBlOzCERQjlUGQ==", null, false, null, false, "User2" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Duration", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("8cb8d357-ed1d-42d1-8364-1c3fabac0e7a"), "A bodyweight exercise for upper body strength.", 30, "https://anabolicaliens.com/cdn/shop/articles/199990_400x.png?v=1645089103", "Push-Up" },
                    { new Guid("9be33907-1925-4439-b4a0-9c692005d109"), "A lower body exercise for strength and endurance.", 40, "https://weighttraining.guide/wp-content/uploads/2016/10/barbell-squat-resized-FIXED-2.png", "Squat" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Age", "CreatedOn", "FirstName", "Gender", "Goals", "Height", "LastName", "Weight" },
                values: new object[,]
                {
                    { new Guid("2acde129-f04a-4664-8b9e-8465025f4490"), 25, new DateTime(2024, 11, 16, 19, 28, 56, 333, DateTimeKind.Local).AddTicks(6158), "Jane", 2, "Gain muscle", 165m, "Smith", 60m },
                    { new Guid("3f375560-c39f-4475-8f6d-56ad46b112fc"), 30, new DateTime(2024, 11, 16, 19, 28, 56, 330, DateTimeKind.Local).AddTicks(1256), "John", 1, "Lose weight", 180m, "Doe", 80m }
                });

            migrationBuilder.InsertData(
                table: "BMICalculations",
                columns: new[] { "Id", "BMI", "Category", "Date", "Height", "UserProfileId", "Weight" },
                values: new object[,]
                {
                    { new Guid("9db48087-b8ea-453d-b903-891980da2588"), 22m, "Normal weight", new DateTime(2024, 11, 16, 19, 28, 56, 334, DateTimeKind.Local).AddTicks(3738), 165m, new Guid("2acde129-f04a-4664-8b9e-8465025f4490"), 60.6m },
                    { new Guid("bc9826c6-f1d3-49cd-ab92-46a482b37ed7"), 24.7m, "Normal weight", new DateTime(2024, 11, 16, 19, 28, 56, 334, DateTimeKind.Local).AddTicks(1416), 180m, new Guid("3f375560-c39f-4475-8f6d-56ad46b112fc"), 80m }
                });

            migrationBuilder.InsertData(
                table: "NutritionPlans",
                columns: new[] { "Id", "Calories", "Carbohydrates", "Fats", "Goal", "Protein", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("8f62b3c6-6144-403a-b807-4eeba4d9ced4"), 2000, 100, 50, "Lose weight", 150, new Guid("3f375560-c39f-4475-8f6d-56ad46b112fc") },
                    { new Guid("df397e30-138d-4c13-93a2-804b363151d4"), 2500, 200, 60, "Gain muscle", 200, new Guid("2acde129-f04a-4664-8b9e-8465025f4490") }
                });

            migrationBuilder.InsertData(
                table: "ProgressLogs",
                columns: new[] { "Id", "Chest", "Date", "Hips", "UserProfileId", "Waist", "Weight" },
                values: new object[,]
                {
                    { new Guid("65516199-bc6d-499c-a890-f847f77b9a4e"), null, new DateTime(2024, 11, 16, 19, 28, 56, 335, DateTimeKind.Local).AddTicks(6336), 95m, new Guid("2acde129-f04a-4664-8b9e-8465025f4490"), null, 60.5m },
                    { new Guid("88a269a4-04ec-4261-bce1-180c38e4b7c8"), 100m, new DateTime(2024, 11, 16, 19, 28, 56, 335, DateTimeKind.Local).AddTicks(4008), null, new Guid("3f375560-c39f-4475-8f6d-56ad46b112fc"), 90m, 79.5m }
                });

            migrationBuilder.InsertData(
                table: "WaterIntakes",
                columns: new[] { "Id", "Consumed", "DailyGoal", "Date", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("74342518-006c-4481-b0f4-a364d7bab704"), 2.8f, 3f, new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), new Guid("2acde129-f04a-4664-8b9e-8465025f4490") },
                    { new Guid("eecd95b8-4eba-4b1c-ae97-12ae631ed1cf"), 2f, 2.5f, new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3f375560-c39f-4475-8f6d-56ad46b112fc") }
                });

            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "Id", "Description", "Duration", "Name", "ScheduleDateTime", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("091c601f-d440-4d86-9320-400ffc1eaf4d"), "A full-body workout to start the day.", 60, "Morning Strength", new DateTime(2024, 11, 16, 20, 28, 56, 336, DateTimeKind.Local).AddTicks(9295), new Guid("3f375560-c39f-4475-8f6d-56ad46b112fc") },
                    { new Guid("4330d8b8-7239-4d8e-9e9e-b9a142cb0a2f"), "High-intensity cardio for fat burn.", 45, "Evening Cardio", new DateTime(2024, 11, 16, 22, 28, 56, 337, DateTimeKind.Local).AddTicks(380), new Guid("2acde129-f04a-4664-8b9e-8465025f4490") }
                });

            migrationBuilder.InsertData(
                table: "WorkoutExercises",
                columns: new[] { "ExerciseId", "WorkoutId", "Reps", "Sets" },
                values: new object[,]
                {
                    { new Guid("8cb8d357-ed1d-42d1-8364-1c3fabac0e7a"), new Guid("091c601f-d440-4d86-9320-400ffc1eaf4d"), 10, 3 },
                    { new Guid("9be33907-1925-4439-b4a0-9c692005d109"), new Guid("4330d8b8-7239-4d8e-9e9e-b9a142cb0a2f"), 15, 4 }
                });
        }
    }
}
