using Healthify.Service.Data;
using HealthifyApp.Data;
using HealthifyApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using MockQueryable;
using Moq;

namespace HealthifyApp.Services.Tests
{
    [TestFixture]
    public class HomeServiceTests
    {
        private Mock<DbSet<UserProfile>> mockUserProfiles;
        private Mock<HealthifyDbContext> mockDbContext;
        private HomeService homeService;

        [SetUp]
        public void SetUp()
        {
            // Create sample data
            var userName = "testUser";
            var userProfiles = new List<UserProfile>
            {
                new UserProfile
                {
                    IsActiveProfile = true,
                    ApplicationUserProfiles = new List<ApplicationUserProfile>
                    {
                        new ApplicationUserProfile { ApplicationUser = new ApplicationUser { UserName = userName } }
                    },
                    Workouts = new List<Workout> { new Workout { Name = "Workout1" } },
                    ProgressLogs = new List<ProgressLog> { new ProgressLog { CurrentWeight = 70.5f } },
                    Goals = new List<Goal> { new Goal { GoalWeight = 65 } },
                    WaterIntakes = new List<WaterIntake> { new WaterIntake { DailyGoal = 3 } },
                    NutritionIntake = new List<NutritionIntake> { new NutritionIntake {Date = DateTime.Now, Calories = 2000 } },
                    TargetNutritional = new List<TargetNutrition> { new TargetNutrition { TargetCalories = 2500 } }
                }
            }.AsQueryable().BuildMock();

            // Mock DbSet<UserProfile>
            mockUserProfiles = new Mock<DbSet<UserProfile>>();
            mockUserProfiles.As<IQueryable<UserProfile>>().Setup(m => m.Provider).Returns(userProfiles.Provider);
            mockUserProfiles.As<IQueryable<UserProfile>>().Setup(m => m.Expression).Returns(userProfiles.Expression);
            mockUserProfiles.As<IQueryable<UserProfile>>().Setup(m => m.ElementType).Returns(userProfiles.ElementType);
            mockUserProfiles.As<IQueryable<UserProfile>>().Setup(m => m.GetEnumerator()).Returns(userProfiles.GetEnumerator());

            // Mock DbContext
            mockDbContext = new Mock<HealthifyDbContext>();
            mockDbContext.Setup(db => db.UserProfiles).Returns(mockUserProfiles.Object);

            // Inject mock DbContext into HomeService
            homeService = new HomeService(mockDbContext.Object);
        }

        [Test]
        public async Task GetHomeIndexViewModelAsync_ReturnsViewModel_WhenActiveProfileExists()
        {
            // Arrange
            var userName = "testUser";

            // Act
            var result = await homeService.GetHomeIndexViewModelAsync(userName);

            // Assert
            Assert.IsTrue(result.HasProfile);
            Assert.AreEqual("Workout1", result.LastWorkout);
            Assert.AreEqual("70.50", result.CurrentWeight);
            Assert.AreEqual("65.00", result.GoalWeight);
            Assert.AreEqual("3 liters", result.WaterIntakeStatus);
            Assert.AreEqual("2000 / 2500 kca", result.CalorieStatus);
        }

        [Test]
        public async Task GetHomeIndexViewModelAsync_ReturnsViewModel_WhenNoActiveProfileExists()
        {
            // Arrange
            var userName = "nonExistentUser";

            // Act
            var result = await homeService.GetHomeIndexViewModelAsync(userName);

            // Assert
            Assert.IsFalse(result.HasProfile);
            Assert.AreEqual(userName, result.UserName);
        }
    }
}