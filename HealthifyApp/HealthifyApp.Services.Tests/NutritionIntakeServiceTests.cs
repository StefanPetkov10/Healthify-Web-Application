using System.Linq.Expressions;
using HealthifyApp.Data.Models;
using HealthifyApp.Data.Repository.Interfaces;
using HealthifyApp.Service.Data;
using HealthifyApp.Services.Mapping;
using HealthifyApp.Web.ViewModels.Goal;
using HealthifyApp.Web.ViewModels.NutritionIntake;
using MockQueryable;
using Moq;

namespace HealthifyApp.Services.Tests
{
    [TestFixture]
    public class NutritionIntakeServiceTests
    {
        private Mock<IRepository<NutritionIntake, Guid>> nutritionIntakeRepository;
        private Mock<IRepository<TargetNutrition, Guid>> targetNutritionRepository;
        private Mock<IRepository<UserProfile, Guid>> userProfileRepository;
        private IList<NutritionIntake> nutritionIntakeData;
        private IList<TargetNutrition> targetNutritionData;
        private IList<UserProfile> userProfilesData;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            AutoMapperConfig.RegisterMappings(typeof(GoalListViewModel).Assembly);
        }

        [SetUp]
        public void Setup()
        {
            nutritionIntakeRepository = new Mock<IRepository<NutritionIntake, Guid>>();
            targetNutritionRepository = new Mock<IRepository<TargetNutrition, Guid>>();
            userProfileRepository = new Mock<IRepository<UserProfile, Guid>>();

            var userId = Guid.NewGuid();
            userProfilesData = new List<UserProfile>
            {
                new UserProfile { Id = userId, IsActiveProfile = true, ApplicationUserProfiles = new List<ApplicationUserProfile>
                    {
                         new ApplicationUserProfile
                         {
                            ApplicationUserId = Guid.NewGuid()
                         }
                    } }
            };

            targetNutritionData = new List<TargetNutrition>
            {
                new TargetNutrition
                {
                    Id = Guid.NewGuid(),
                    UserProfileId = userId,
                    TargetCalories = 2000,
                    TargetProtein = 150,
                    TargetCarbohydrates = 250,
                    TargetFats = 70
                }
            };

            nutritionIntakeData = new List<NutritionIntake>
            {
                new NutritionIntake
                {
                    Id = Guid.NewGuid(),
                    UserProfileId = userId,
                    Date = DateTime.UtcNow.Date,
                    Calories = 1500,
                    Protein = 120,
                    Carbohydrates = 200,
                    Fats = 50 }
            };
        }

        [Test]
        public async Task GetNutritionIntakeIndexAsync_ReturnsCorrectData()
        {
            // Arrange
            var userId = userProfilesData[0].ApplicationUserProfiles.First().ApplicationUserId;

            var targetNutritionMockQueryable = targetNutritionData.AsQueryable().BuildMock();
            var nutritionIntakeMockQueryable = nutritionIntakeData.AsQueryable().BuildMock();

            userProfileRepository.Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<UserProfile, bool>>>()))
                .ReturnsAsync(userProfilesData[0]);

            targetNutritionRepository.Setup(r => r.GetAllAttached())
                .Returns(targetNutritionMockQueryable);

            nutritionIntakeRepository.Setup(r => r.GetAllAttached())
                .Returns(nutritionIntakeMockQueryable);

            var service = new NutritionIntakeService(nutritionIntakeRepository.Object, targetNutritionRepository.Object, userProfileRepository.Object);

            // Act
            var result = await service.GetNutritionIntakeIndexAsync(userId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2000, result.TargetCalories);
            Assert.AreEqual(150, result.TargetProtein);
            Assert.AreEqual(250, result.TargetCarbohydrates);
            Assert.AreEqual(70, result.TargetFats);
            Assert.AreEqual(1500, result.CurrentCalories);
            Assert.AreEqual(120, result.CurrentProtein);
            Assert.AreEqual(200, result.CurrentCarbohydrates);
            Assert.AreEqual(50, result.CurrentFats);
        }

        [Test]
        public async Task GetNutritionIntakeIndexAsync_ReturnsNull_WhenProfileIsInactive()
        {
            // Arrange
            var userId = userProfilesData[0].ApplicationUserProfiles.First().ApplicationUserId;
            userProfileRepository.Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<UserProfile, bool>>>()))
                .ReturnsAsync(new UserProfile { IsActiveProfile = false });

            var service = new NutritionIntakeService(nutritionIntakeRepository.Object, targetNutritionRepository.Object, userProfileRepository.Object);

            // Act
            var result = await service.GetNutritionIntakeIndexAsync(userId);

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public async Task AddNutritionIntakeAsync_ReturnsTrue_WhenAddedSuccessfully()
        {
            // Arrange
            var userId = userProfilesData[0].ApplicationUserProfiles.First().ApplicationUserId;
            var inputModel = new AddTodayNutritionIntakeFormModel
            {
                Date = DateTime.UtcNow.Date.ToString("dd-MM-yyyy"),
                Calories = 1600,
                Protein = 130,
                Carbohydrates = 220,
                Fats = 60
            };

            userProfileRepository.Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<UserProfile, bool>>>()))
                .ReturnsAsync(userProfilesData[0]);
            nutritionIntakeRepository.Setup(r => r.AddAsync(It.IsAny<NutritionIntake>())).Verifiable();

            var service = new NutritionIntakeService(nutritionIntakeRepository.Object, targetNutritionRepository.Object, userProfileRepository.Object);

            // Act
            var result = await service.AddNutritionIntakeAsync(inputModel, userId);

            // Assert
            Assert.IsTrue(result);
            nutritionIntakeRepository.Verify(r => r.AddAsync(It.IsAny<NutritionIntake>()), Times.Once);
        }

        [Test]
        public async Task AddNutritionIntakeAsync_ReturnsFalse_WhenProfileIsInactive()
        {
            // Arrange
            var userId = userProfilesData[0].ApplicationUserProfiles.First().ApplicationUserId;
            var inputModel = new AddTodayNutritionIntakeFormModel
            {
                Date = DateTime.UtcNow.Date.ToString("dd-MM-yyyy"),
                Calories = 1600,
                Protein = 130,
                Carbohydrates = 220,
                Fats = 60
            };

            userProfileRepository.Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<UserProfile, bool>>>()))
                .ReturnsAsync(new UserProfile { IsActiveProfile = false });

            var service = new NutritionIntakeService(nutritionIntakeRepository.Object, targetNutritionRepository.Object, userProfileRepository.Object);

            // Act
            var result = await service.AddNutritionIntakeAsync(inputModel, userId);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public async Task AddMoreNutritionIntakeAsync_ReturnsTrue_WhenUpdatedSuccessfully()
        {
            // Arrange
            var userId = userProfilesData[0].ApplicationUserProfiles.First().ApplicationUserId;
            var inputModel = new AddTodayNutritionIntakeFormModel
            {
                Calories = 200,
                Protein = 20,
                Carbohydrates = 30,
                Fats = 10
            };

            var nutritionIntakeMockQueryable = nutritionIntakeData.AsQueryable().BuildMock();

            userProfileRepository.Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<UserProfile, bool>>>()))
                .ReturnsAsync(userProfilesData[0]);
            nutritionIntakeRepository.Setup(r => r.GetAllAttached())
                .Returns(nutritionIntakeMockQueryable);

            nutritionIntakeRepository.Setup(r => r.UpdateAsync(It.IsAny<NutritionIntake>())).Verifiable();

            var service = new NutritionIntakeService(nutritionIntakeRepository.Object, targetNutritionRepository.Object, userProfileRepository.Object);

            // Act
            var result = await service.AddMoreNutritionIntakeAsync(inputModel, userId);

            // Assert
            Assert.IsTrue(result);
            nutritionIntakeRepository.Verify(r => r.UpdateAsync(It.IsAny<NutritionIntake>()), Times.Once);
        }

        [Test]
        public async Task AddMoreNutritionIntakeAsync_ReturnsFalse_WhenNoExistingIntake()
        {
            // Arrange
            var userId = userProfilesData[0].ApplicationUserProfiles.First().ApplicationUserId;
            var inputModel = new AddTodayNutritionIntakeFormModel
            {
                Calories = 200,
                Protein = 20,
                Carbohydrates = 30,
                Fats = 10
            };

            var nutritionIntakeMockQueryable = new List<NutritionIntake>().AsQueryable().BuildMock();
            userProfileRepository.Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<UserProfile, bool>>>()))
                .ReturnsAsync(userProfilesData[0]);

            nutritionIntakeRepository.Setup(r => r.GetAllAttached())
                .Returns(nutritionIntakeMockQueryable);

            var service = new NutritionIntakeService(nutritionIntakeRepository.Object, targetNutritionRepository.Object, userProfileRepository.Object);

            // Act
            var result = await service.AddMoreNutritionIntakeAsync(inputModel, userId);

            // Assert
            Assert.IsFalse(result);
        }
    }
}

