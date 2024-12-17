using System.Linq.Expressions;
using HealthifyApp.Data.Models;
using HealthifyApp.Data.Models.Enums;
using HealthifyApp.Data.Repository.Interfaces;
using HealthifyApp.Service.Data;
using Moq;

namespace HealthifyApp.Services.Tests
{
    [TestFixture]
    public class WaterIntakeServiceTests
    {
        private WaterIntakeService waterIntakeService;
        private Mock<IRepository<WaterIntake, Guid>> waterIntakeRepositoryMock;
        private Mock<IRepository<UserProfile, Guid>> userProfileRepositoryMock;

        [SetUp]
        public void SetUp()
        {
            waterIntakeRepositoryMock = new Mock<IRepository<WaterIntake, Guid>>();
            userProfileRepositoryMock = new Mock<IRepository<UserProfile, Guid>>();
            waterIntakeService = new WaterIntakeService(waterIntakeRepositoryMock.Object, userProfileRepositoryMock.Object);
        }

        [Test]
        public async Task CreateOrUpdateWaterIntakeAsync_ReturnsTrue_WhenUserProfileIsActiveAndWaterIntakeDoesNotExist()
        {
            // Arrange
            var userProfile = new UserProfile
            {
                Id = Guid.NewGuid(),
                IsActiveProfile = true,
                ApplicationUserProfiles = new List<ApplicationUserProfile>
                {
                     new ApplicationUserProfile
                     {
                        ApplicationUserId = Guid.NewGuid()
                     }
                }
            };

            var userId = userProfile.ApplicationUserProfiles.First().ApplicationUserId;


            waterIntakeRepositoryMock.Setup(repo => repo.FirstOrDefaultAsync(It.IsAny<Expression<Func<WaterIntake, bool>>>()))
                .ReturnsAsync((WaterIntake)null);
            userProfileRepositoryMock.Setup(repo => repo.FirstOrDefaultAsync(It.IsAny<Expression<Func<UserProfile, bool>>>()))
                .ReturnsAsync(userProfile);

            // Act
            var result = await waterIntakeService.CreateOrUpdateWaterIntakeAsync(userId, 2.5f);

            // Assert
            Assert.IsTrue(result);
            waterIntakeRepositoryMock.Verify(repo => repo.AddAsync(It.IsAny<WaterIntake>()), Times.Once);
        }

        [Test]
        public async Task CreateOrUpdateWaterIntakeAsync_UpdatesWaterIntake_WhenItAlreadyExists()
        {
            // Arrange
            var userProfile = new UserProfile
            {
                Id = Guid.NewGuid(),
                IsActiveProfile = true,
                ApplicationUserProfiles = new List<ApplicationUserProfile>
                {
                     new ApplicationUserProfile
                     {
                        ApplicationUserId = Guid.NewGuid()
                     }
                }
            };

            var userId = userProfile.ApplicationUserProfiles.First().ApplicationUserId;
            var existingWaterIntake = new WaterIntake { UserProfileId = userProfile.Id, DailyGoal = 2.0f };

            waterIntakeRepositoryMock.Setup(repo => repo.FirstOrDefaultAsync(It.IsAny<Expression<Func<WaterIntake, bool>>>()))
                .ReturnsAsync(existingWaterIntake);
            userProfileRepositoryMock.Setup(repo => repo.FirstOrDefaultAsync(It.IsAny<Expression<Func<UserProfile, bool>>>()))
                .ReturnsAsync(userProfile);

            // Act
            var result = await waterIntakeService.CreateOrUpdateWaterIntakeAsync(userId, 3.0f);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(3.0f, existingWaterIntake.DailyGoal);
            waterIntakeRepositoryMock.Verify(repo => repo.UpdateAsync(It.IsAny<WaterIntake>()), Times.Once);
        }

        [Test]
        public async Task CreateOrUpdateWaterIntakeAsync_ReturnsFalse_WhenUserProfileIsInactive()
        {
            // Arrange
            var userProfile = new UserProfile
            {
                Id = Guid.NewGuid(),
                IsActiveProfile = false,
                ApplicationUserProfiles = new List<ApplicationUserProfile>
                {
                     new ApplicationUserProfile
                     {
                        ApplicationUserId = Guid.NewGuid()
                     }
                }
            };

            var userId = userProfile.ApplicationUserProfiles.First().ApplicationUserId;

            userProfileRepositoryMock.Setup(repo => repo.FirstOrDefaultAsync(It.IsAny<Expression<Func<UserProfile, bool>>>()))
                .ReturnsAsync(userProfile);

            // Act
            var result = await waterIntakeService.CreateOrUpdateWaterIntakeAsync(userId, 2.5f);

            // Assert
            Assert.IsFalse(result);
            waterIntakeRepositoryMock.Verify(repo => repo.AddAsync(It.IsAny<WaterIntake>()), Times.Never);
        }

        [Test]
        public void CalculateWaterIntake_ReturnsCorrectValue_ForSedentaryActivity()
        {
            // Arrange
            float weightInKg = 70;
            Activity activityLevel = Activity.Sedentary;

            // Act
            var result = waterIntakeService.CalculateWaterIntake(weightInKg, activityLevel);

            // Assert
            Assert.AreEqual(2.3f, result); // 70 * 30 + 200 = 2300 ml -> 2.3 L
        }

        [Test]
        public void CalculateWaterIntake_ReturnsCorrectValue_ForVeryActiveActivity()
        {
            // Arrange
            float weightInKg = 80;
            Activity activityLevel = Activity.VeryActive;

            // Act
            var result = waterIntakeService.CalculateWaterIntake(weightInKg, activityLevel);

            // Assert
            Assert.AreEqual(3.2f, result); // 80 * 30 + 800 = 3200 ml -> 3.2 L
        }

        [Test]
        public async Task GetWaterIntakeAsync_ReturnsCorrectViewModel()
        {
            // Arrange
            float dailyGoal = 2.5f;

            // Act
            var result = await waterIntakeService.GetWaterIntakeAsync(dailyGoal);

            // Assert
            Assert.AreEqual(2.5f, result.RecommendedWaterIntake);
            Assert.AreEqual("Your daily water intake goal has been updated successfully!", result.Message);
        }
    }
}