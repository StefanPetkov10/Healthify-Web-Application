using System.Linq.Expressions;
using Healthify.Service.Data;
using HealthifyApp.Data.Models;
using HealthifyApp.Data.Repository.Interfaces;
using HealthifyApp.Services.Mapping;
using HealthifyApp.Web.ViewModels.TargetNutrition;
using MockQueryable;
using Moq;

namespace HealthifyApp.Services.Tests
{
    [TestFixture]
    public class TargetNutritionServiceTests
    {
        private Mock<IRepository<Goal, Guid>> goalRepository;
        private Mock<IRepository<TargetNutrition, Guid>> targetNutritionRepository;
        private Mock<IRepository<UserProfile, Guid>> userProfileRepository;
        private IList<Goal> goalData;
        private IList<TargetNutrition> targetNutritionData;
        private IList<UserProfile> userProfilesData;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            AutoMapperConfig.RegisterMappings(typeof(TargetNutritionListViewModel).Assembly);
        }

        [SetUp]
        public void Setup()
        {
            goalRepository = new Mock<IRepository<Goal, Guid>>();
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
                    }}
            };

            goalData = new List<Goal>
            {
                new Goal { Id = Guid.NewGuid(), UserProfileId = userId }
            };

            targetNutritionData = new List<TargetNutrition>
            {
                new TargetNutrition { Id = Guid.NewGuid(), GoalId = goalData[0].Id, UserProfileId = userId }
            };
        }

        [Test]
        public async Task IndexGetTargetNutritionAsync_ReturnsCorrectData()
        {
            // Arrange
            var userId = userProfilesData[0].ApplicationUserProfiles.First().ApplicationUserId;
            userProfileRepository.Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<UserProfile, bool>>>()))
                .ReturnsAsync(userProfilesData[0]);

            targetNutritionRepository.Setup(r => r.GetAllAttached())
                .Returns(targetNutritionData.AsQueryable().BuildMock());

            var service = new TargetNutritionService(goalRepository.Object, targetNutritionRepository.Object, userProfileRepository.Object);

            // Act
            var result = await service.IndexGetTargetNutritionAsync(userId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count());
        }

        [Test]
        public async Task IndexGetTargetNutritionAsync_ReturnsNullForInactiveProfile()
        {
            // Arrange
            var userId = userProfilesData[0].ApplicationUserProfiles.First().ApplicationUserId;
            userProfileRepository.Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<UserProfile, bool>>>()))
                .ReturnsAsync(new UserProfile { IsActiveProfile = false });

            var service = new TargetNutritionService(goalRepository.Object, targetNutritionRepository.Object, userProfileRepository.Object);

            // Act
            var result = await service.IndexGetTargetNutritionAsync(userId);

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public async Task CreateTargetNutritionAsync_ReturnsNull_WhenNutritionExists()
        {
            // Arrange
            var goalId = goalData[0].Id;
            targetNutritionRepository.Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<TargetNutrition, bool>>>()))
                .ReturnsAsync(targetNutritionData[0]);

            var service = new TargetNutritionService(goalRepository.Object, targetNutritionRepository.Object, userProfileRepository.Object);

            // Act
            var result = await service.CreateTargetNutritionAsync(new TargetNutrition(), goalId);

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public async Task CreateTargetNutritionAsync_CreatesSuccessfully()
        {
            // Arrange
            var userId = userProfilesData[0].Id;
            var inputModel = new CreateTargetNutritionFormModel
            {
                StartDate = DateTime.Now.ToString("dd-MM-yyyy"),
                TargetCalories = 2000,
                TargetProtein = 150,
                TargetCarbohydrates = 250,
                TargetFats = 70
            };

            userProfileRepository.Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<UserProfile, bool>>>()))
                .ReturnsAsync(userProfilesData[0]);
            targetNutritionRepository.Setup(r => r.AddAsync(It.IsAny<TargetNutrition>())).Verifiable();

            var service = new TargetNutritionService(goalRepository.Object, targetNutritionRepository.Object, userProfileRepository.Object);

            // Act
            var result = await service.CreateTargetNutritionAsync(inputModel, userId);

            // Assert
            Assert.IsTrue(result);
            targetNutritionRepository.Verify(r => r.AddAsync(It.IsAny<TargetNutrition>()), Times.Once);
        }

        [Test]
        public async Task DeletePermanentlyTargetNutritionAsync_DeletesNutritionAndGoal()
        {
            // Arrange
            var targetNutrition = targetNutritionData[0];

            targetNutritionRepository.Setup(r => r.GetByIdAsync(targetNutrition.Id)).ReturnsAsync(targetNutrition);

            targetNutritionRepository.Setup(r => r.Delete(It.IsAny<TargetNutrition>())).Verifiable();

            var service = new TargetNutritionService(goalRepository.Object, targetNutritionRepository.Object, userProfileRepository.Object);

            // Act
            var result = await service.DeletePermanentlyTargetNutritionAsync(targetNutrition.Id);

            // Assert
            Assert.IsTrue(result);
            targetNutritionRepository.Verify(r => r.Delete(It.IsAny<TargetNutrition>()), Times.Once);
        }
    }
}


