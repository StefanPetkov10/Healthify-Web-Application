using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthifyApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class RefactoringDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NutritionPlans");

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

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "ProgressLogs");

            migrationBuilder.AddColumn<decimal>(
                name: "StartingWeight",
                table: "UserProfiles",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                comment: "The starting weight of the user.");

            migrationBuilder.AddColumn<decimal>(
                name: "CurrentWeight",
                table: "ProgressLogs",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                comment: "The user's weight as of today.");

            migrationBuilder.AlterColumn<int>(
                name: "Category",
                table: "BMICalculations",
                type: "int",
                nullable: false,
                comment: "The category of the BMI.",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "The category of the BMI.");

            migrationBuilder.CreateTable(
                name: "Goals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Primary key for the goal."),
                    UserProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The user profile ID."),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "The date of the goal start."),
                    GoalType = table.Column<int>(type: "int", nullable: false, comment: "The goal chois"),
                    Activity = table.Column<int>(type: "int", nullable: false, comment: "The activity of the user."),
                    GoalWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "The user's goal weight."),
                    GoalWaist = table.Column<float>(type: "real", nullable: true),
                    GoalHips = table.Column<float>(type: "real", nullable: true),
                    GoalChest = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Goals_UserProfiles_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NutritionIntake",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Primary key for the nutrition intake."),
                    UserProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The user profile ID."),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "The date of the intake."),
                    Calories = table.Column<int>(type: "int", nullable: false, comment: "The calories intake by user."),
                    Protein = table.Column<int>(type: "int", nullable: false, comment: "The protein intake by user."),
                    Carbohydrates = table.Column<int>(type: "int", nullable: false, comment: "The carbohydrates intake by user."),
                    Fats = table.Column<int>(type: "int", nullable: false, comment: "The fats intake by user.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutritionIntake", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NutritionIntake_UserProfiles_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TargetNutritional",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Primary key for the target nutritional."),
                    UserProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The user profile ID."),
                    GoalName = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "The goal name."),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "The date of the target nutritional start."),
                    TargetCalories = table.Column<int>(type: "int", nullable: false, comment: "The calories should intake user."),
                    TargetProtein = table.Column<int>(type: "int", nullable: false, comment: "The protein should intake user."),
                    TargetCarbohydrates = table.Column<int>(type: "int", nullable: false, comment: "The carbohydrates should intake user."),
                    TargetFats = table.Column<int>(type: "int", nullable: false, comment: "The fats should intake user.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TargetNutritional", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TargetNutritional_UserProfiles_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Goals_UserProfileId",
                table: "Goals",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_NutritionIntake_UserProfileId",
                table: "NutritionIntake",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_TargetNutritional_UserProfileId",
                table: "TargetNutritional",
                column: "UserProfileId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Goals");

            migrationBuilder.DropTable(
                name: "NutritionIntake");

            migrationBuilder.DropTable(
                name: "TargetNutritional");

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
                table: "ProgressLogs",
                keyColumn: "Id",
                keyValue: new Guid("b8c71914-5801-4817-b1a3-342d83410140"));

            migrationBuilder.DeleteData(
                table: "ProgressLogs",
                keyColumn: "Id",
                keyValue: new Guid("f2f4aaf4-fed7-4613-8967-15764699343d"));

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
                name: "StartingWeight",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "CurrentWeight",
                table: "ProgressLogs");

            migrationBuilder.AddColumn<decimal>(
                name: "Weight",
                table: "UserProfiles",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                comment: "The weight of the user.");

            migrationBuilder.AddColumn<decimal>(
                name: "Weight",
                table: "ProgressLogs",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                comment: "The weight of the user.");

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "BMICalculations",
                type: "nvarchar(max)",
                nullable: false,
                comment: "The category of the BMI.",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "The category of the BMI.");

            migrationBuilder.CreateTable(
                name: "NutritionPlans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Primary key for the nutrition plan."),
                    UserProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The user profile ID."),
                    Calories = table.Column<int>(type: "int", nullable: false, comment: "The calories should intake user."),
                    Carbohydrates = table.Column<int>(type: "int", nullable: false, comment: "The carbohydrates should intake user."),
                    Fats = table.Column<int>(type: "int", nullable: false, comment: "The fats should intake user."),
                    Goal = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "The goal of the nutrition plan."),
                    Protein = table.Column<int>(type: "int", nullable: false, comment: "The protein should intake user.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutritionPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NutritionPlans_UserProfiles_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_NutritionPlans_UserProfileId",
                table: "NutritionPlans",
                column: "UserProfileId");
        }
    }
}
