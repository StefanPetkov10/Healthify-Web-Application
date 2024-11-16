using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthifyApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutExercises_Exercises_ExerciseId",
                table: "WorkoutExercises");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutExercises_Workouts_WorkoutId",
                table: "WorkoutExercises");

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

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutExercises_Exercises_ExerciseId",
                table: "WorkoutExercises",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutExercises_Workouts_WorkoutId",
                table: "WorkoutExercises",
                column: "WorkoutId",
                principalTable: "Workouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutExercises_Exercises_ExerciseId",
                table: "WorkoutExercises");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutExercises_Workouts_WorkoutId",
                table: "WorkoutExercises");

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

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutExercises_Exercises_ExerciseId",
                table: "WorkoutExercises",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutExercises_Workouts_WorkoutId",
                table: "WorkoutExercises",
                column: "WorkoutId",
                principalTable: "Workouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
