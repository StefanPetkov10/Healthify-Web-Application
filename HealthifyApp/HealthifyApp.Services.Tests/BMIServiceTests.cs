using System.Linq.Expressions;
using HealthifyApp.Data.Models;
using HealthifyApp.Data.Models.Enums;
using HealthifyApp.Data.Repository.Interfaces;
using HealthifyApp.Service.Data;
using Moq;

namespace HealthifyApp.Services.Tests
{
    [TestFixture]
    public class BMIServiceTests
    {
        private Mock<IRepository<BMICalculation, Guid>> bmiCalculationRepositoryMock;
        private Mock<IRepository<UserProfile, Guid>> userProfileRepositoryMock;
        private BMIService bmiService;

        private Guid userProfileId;
        private UserProfile userProfilesData;

        [SetUp]
        public void Setup()
        {
            bmiCalculationRepositoryMock = new Mock<IRepository<BMICalculation, Guid>>();
            userProfileRepositoryMock = new Mock<IRepository<UserProfile, Guid>>();

            bmiService = new BMIService(bmiCalculationRepositoryMock.Object, userProfileRepositoryMock.Object);

            userProfileId = Guid.NewGuid();
            userProfilesData = new UserProfile
            {
                Id = userProfileId,
                IsActiveProfile = true,
                ApplicationUserProfiles = new List<ApplicationUserProfile>
                {
                     new ApplicationUserProfile
                     {
                        ApplicationUserId = Guid.NewGuid()
                     }
                }
            };
        }

        [Test]
        public async Task CreateOrUpdateBMIAsync_ReturnsTrue_WhenNewBMICalculationIsAdded()
        {
            // Arrange
            var userId = userProfilesData.ApplicationUserProfiles.First().ApplicationUserId;
            var bmi = 22.5f;
            var category = BMICategory.NormalWeight;

            userProfileRepositoryMock.Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<UserProfile, bool>>>()))
                .ReturnsAsync(userProfilesData);

            bmiCalculationRepositoryMock.Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<BMICalculation, bool>>>()))
                .ReturnsAsync((BMICalculation)null);

            bmiCalculationRepositoryMock.Setup(r => r.AddAsync(It.IsAny<BMICalculation>())).Verifiable();

            // Act
            var result = await bmiService.CreateOrUpdateBMIAsync(userId, bmi, category);

            // Assert
            Assert.IsTrue(result);
            bmiCalculationRepositoryMock.Verify(r => r.AddAsync(It.IsAny<BMICalculation>()), Times.Once);
        }

        [Test]
        public async Task CreateOrUpdateBMIAsync_ReturnsTrue_WhenExistingBMICalculationIsUpdated()
        {
            // Arrange
            var userId = userProfilesData.ApplicationUserProfiles.First().ApplicationUserId;
            var bmi = 25.0f;
            var category = BMICategory.OverWeight;

            var existingBMICalculation = new BMICalculation
            {
                Id = Guid.NewGuid(),
                UserProfileId = userProfileId,
                BMI = 22.5f,
                Category = BMICategory.NormalWeight
            };

            userProfileRepositoryMock.Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<UserProfile, bool>>>()))
                .ReturnsAsync(userProfilesData);

            bmiCalculationRepositoryMock.Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<BMICalculation, bool>>>()))
                .ReturnsAsync(existingBMICalculation);

            bmiCalculationRepositoryMock.Setup(r => r.UpdateAsync(It.IsAny<BMICalculation>())).Verifiable();

            // Act
            var result = await bmiService.CreateOrUpdateBMIAsync(userId, bmi, category);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(bmi, existingBMICalculation.BMI);
            Assert.AreEqual(category, existingBMICalculation.Category);
            bmiCalculationRepositoryMock.Verify(r => r.UpdateAsync(It.IsAny<BMICalculation>()), Times.Once);
        }

        [Test]
        public async Task CreateOrUpdateBMIAsync_ReturnsFalse_WhenUserProfileIsInactive()
        {
            // Arrange
            var userId = userProfilesData.ApplicationUserProfiles.First().ApplicationUserId;
            var bmi = 20.0f;
            var category = BMICategory.NormalWeight;

            var inactiveUserProfile = new UserProfile
            {
                Id = userProfileId,
                IsActiveProfile = false
            };

            userProfileRepositoryMock.Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<UserProfile, bool>>>()))
                .ReturnsAsync(inactiveUserProfile);

            // Act
            var result = await bmiService.CreateOrUpdateBMIAsync(userId, bmi, category);

            // Assert
            Assert.IsFalse(result);
            bmiCalculationRepositoryMock.Verify(r => r.AddAsync(It.IsAny<BMICalculation>()), Times.Never);
            bmiCalculationRepositoryMock.Verify(r => r.UpdateAsync(It.IsAny<BMICalculation>()), Times.Never);
        }

        [Test]
        public void DetermineBMICategory_ReturnsCorrectCategory()
        {
            // Arrange & Act
            var underweight = bmiService.DetermineBMICategory(17.0f);
            var normalWeight = bmiService.DetermineBMICategory(22.0f);
            var overweight = bmiService.DetermineBMICategory(27.0f);
            var obese = bmiService.DetermineBMICategory(32.0f);

            // Assert
            Assert.AreEqual(BMICategory.UnderWeight, underweight);
            Assert.AreEqual(BMICategory.NormalWeight, normalWeight);
            Assert.AreEqual(BMICategory.OverWeight, overweight);
            Assert.AreEqual(BMICategory.Obese, obese);
        }

        [Test]
        public void CalculateBMI_ReturnsCorrectValue()
        {
            // Arrange
            var weight = 70.0f; // kg
            var height = 1.75f; // meters

            // Act
            var bmi = bmiService.CalculateBMI(weight, height);

            // Assert
            Assert.AreEqual(22.86f, (float)Math.Round(bmi, 2));
        }

        [Test]
        public async Task GetBMIAsync_ReturnsCorrectViewModel()
        {
            // Arrange
            var bmi = 23.456f;

            // Act
            var result = await bmiService.GetBMIAsync(bmi);

            // Assert
            Assert.AreEqual(23.46f, result.BMI);
            Assert.AreEqual("NormalWeight", result.Category);
            Assert.AreEqual("Your BMI has been calculated successfully!", result.Message);
        }
    }
}

