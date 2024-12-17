using Healthify.Service.Data;
using HealthifyApp.Data.Models;
using HealthifyApp.Data.Models.Enums;

namespace HealthifyApp.Services.Tests
{
    [TestFixture]
    public class NutritionCalculatorServiceTests
    {
        private NutritionCalculatorService nutritionCalculatorService;

        [SetUp]
        public void Setup()
        {
            nutritionCalculatorService = new NutritionCalculatorService();
        }

        [Test]
        [TestCase(Activity.Sedentary, Goals.LoseWeight, 1900, 95, 63, 237)]
        [TestCase(Activity.LightlyActive, Goals.LoseWeight, 2250, 112, 75, 281)]
        [TestCase(Activity.ModeratelyActive, Goals.MaintainWeight, 3100, 155, 103, 387)]
        [TestCase(Activity.VeryActive, Goals.GainWeight, 3950, 197, 131, 493)]
        [TestCase(Activity.ExtraActive, Goals.GainWeight, 4300, 215, 143, 537)]
        public void CalculateTargetNutrition_ReturnsCorrectValues(
            Activity activity,
            Goals goalType,
            int expectedCalories,
            int expectedProtein,
            int expectedFats,
            int expectedCarbs)
        {
            // Arrange
            var userProfileId = Guid.NewGuid();
            var goal = new Goal
            {
                Id = Guid.NewGuid(),
                UserProfileId = userProfileId,
                Activity = activity,
                GoalType = goalType,
                StartDate = DateTime.UtcNow
            };

            // Act
            var result = nutritionCalculatorService.CalculateTargetNutrition(goal);

            // Assert
            Assert.AreEqual(userProfileId, result.UserProfileId);
            Assert.AreEqual(goal.Id, result.GoalId);
            Assert.AreEqual(goalType.ToString(), result.GoalName);
            Assert.AreEqual(expectedCalories, result.TargetCalories);
            Assert.AreEqual(expectedProtein, result.TargetProtein);
            Assert.AreEqual(expectedFats, result.TargetFats);
            Assert.AreEqual(expectedCarbs, result.TargetCarbohydrates);
        }

        [Test]
        public void CalculateTargetNutrition_ThrowsException_WhenActivityIsInvalid()
        {
            // Arrange
            var goal = new Goal
            {
                Id = Guid.NewGuid(),
                Activity = (Activity)999, // Invalid activity
                GoalType = Goals.MaintainWeight
            };

            // Act & Assert
            Assert.Throws<KeyNotFoundException>(() => nutritionCalculatorService.CalculateTargetNutrition(goal));
        }
    }
}


