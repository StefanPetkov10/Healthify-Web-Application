using System.Linq.Expressions;
using Healthify.Service.Data;
using HealthifyApp.Data.Models;
using HealthifyApp.Data.Models.Enums;
using HealthifyApp.Data.Repository.Interfaces;
using HealthifyApp.Services.Mapping;
using HealthifyApp.Web.ViewModels.Goal;
using MockQueryable;
using Moq;

namespace HealthifyApp.Services.Tests
{
    [TestFixture]
    public class GoalServiceTests
    {
        private Mock<IRepository<Goal, Guid>> goalRepository;
        private Mock<IRepository<UserProfile, Guid>> userProfileRepository;
        private Mock<IRepository<TargetNutrition, Guid>> targetNutritionRepository;

        private IList<Goal> goalData;
        private IList<UserProfile> userProfilesData;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            AutoMapperConfig.RegisterMappings(typeof(GoalListViewModel).Assembly);
        }

        [SetUp]
        public void Setup()
        {
            this.goalRepository = new Mock<IRepository<Goal, Guid>>();
            this.userProfileRepository = new Mock<IRepository<UserProfile, Guid>>();
            this.targetNutritionRepository = new Mock<IRepository<TargetNutrition, Guid>>();


            this.userProfilesData = new List<UserProfile>
            {
                new UserProfile
                {
                    Id = Guid.NewGuid(),
                    FirstName = "John",
                    LastName = "Doe",
                    Age = 30,
                    Height = 175.5f,
                    StartingWeight = 80.2f,
                    Gender = Gender.Male,
                    IsActiveProfile = true,
                    ApplicationUserProfiles = new List<ApplicationUserProfile>
                    {
                         new ApplicationUserProfile
                         {
                            ApplicationUserId = Guid.NewGuid()
                         }
                    }
                }
            };

            this.goalData = new List<Goal>
            {
                new Goal
                {
                    Id = Guid.NewGuid(),
                    UserProfileId = userProfilesData[0].Id,
                    StartDate = DateTime.UtcNow.AddDays(-2),
                    GoalType = Goals.LoseWeight,
                    Activity = Activity.ModeratelyActive,
                    GoalWeight = 70.0f
                },
                new Goal
                {
                    Id = Guid.NewGuid(),
                    UserProfileId = userProfilesData[0].Id,
                    StartDate = DateTime.UtcNow.AddDays(-2),
                    GoalType = Goals.GainWeight,
                    Activity = Activity.Sedentary,
                    GoalWeight = 80.0f
                }
            };
        }

        [Test]
        public async Task CreateGoalAsync_CreatesGoalSuccessfully()
        {
            // Arrange
            var formModel = new CreateGoalFormModel
            {
                StartDate = DateTime.UtcNow.AddDays(-2).ToString("dd-MM-yyyy"),
                GoalWeight = 70.0f,
                GoalType = "LoseWeight",
                Activity = "ModeratelyActive"
            };

            var userId = new Guid();

            this.userProfileRepository.Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<UserProfile, bool>>>()))
                .ReturnsAsync(this.userProfilesData.First());

            this.goalRepository.Setup(r => r.AddAsync(It.IsAny<Goal>()))
                .Returns(Task.CompletedTask);

            var goalService = new GoalService(goalRepository.Object, targetNutritionRepository.Object, userProfileRepository.Object);

            // Act
            var result = await goalService.CreateGoalAsync(formModel, userId);

            // Assert
            Assert.IsTrue(result);
            this.goalRepository.Verify(r => r.AddAsync(It.IsAny<Goal>()), Times.Once);
        }

        [Test]
        public async Task IndexGetGoalAsync_ReturnsCorrectGoalsForUser()
        {
            // Arrange
            var userId = userProfilesData[0].ApplicationUserProfiles.First().ApplicationUserId;

            var mockData = this.goalData.BuildMock();

            // Ensure the mock setup for the user profile is correct
            this.userProfileRepository.Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<UserProfile, bool>>>()))
                .ReturnsAsync(this.userProfilesData.FirstOrDefault(up =>
                    up.IsActiveProfile == true &&
                    up.ApplicationUserProfiles.Any(a => a.ApplicationUserId == userId)));

            this.goalRepository.Setup(r => r.GetAllAttached())
                .Returns(mockData);

            var goalService = new GoalService(goalRepository.Object, targetNutritionRepository.Object, userProfileRepository.Object);

            // Act
            var result = await goalService.IndexGetGoalAsync(userId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
        }

        [Test]
        public async Task IndexGetGoalAsync_ReturnsNullWhenUserProfileIsInactive()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var mockData = this.goalData.BuildMock();

            this.userProfileRepository.Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<UserProfile, bool>>>()))
                .ReturnsAsync(new UserProfile { Id = userId, IsActiveProfile = false });

            this.goalRepository.Setup(r => r.GetAllAttached())
                .Returns(mockData);

            var goalService = new GoalService(goalRepository.Object, targetNutritionRepository.Object, userProfileRepository.Object);

            // Act
            var result = await goalService.IndexGetGoalAsync(userId);

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public async Task DeleteGoalAsync_ReturnsGoalToDelete()
        {
            // Arrange
            var goalId = this.goalData[0].Id;

            this.goalRepository.Setup(r => r.GetAllAttached())
                .Returns(this.goalData.AsQueryable().BuildMock());

            var goalService = new GoalService(goalRepository.Object, targetNutritionRepository.Object, userProfileRepository.Object);

            // Act
            var result = await goalService.DeleteGoalAsync(goalId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(goalId.ToString(), result.Id);
        }

        [Test]
        public async Task DeletePermanentlyGoalAsync_DeletesGoalAndTargetNutrition()
        {
            // Arrange
            var goalId = this.goalData[0].Id;
            var goal = this.goalData[0];
            var targetNutrition = new TargetNutrition { GoalId = goalId };

            this.goalRepository.Setup(r => r.GetByIdAsync(It.IsAny<Guid>()))
                .ReturnsAsync(goal);

            this.targetNutritionRepository.Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<TargetNutrition, bool>>>()))
                .ReturnsAsync(targetNutrition);

            this.goalRepository.Setup(r => r.Delete(It.IsAny<Goal>()))
                .Verifiable();

            this.targetNutritionRepository.Setup(r => r.Delete(It.IsAny<TargetNutrition>()))
                .Verifiable();

            var goalService = new GoalService(goalRepository.Object, targetNutritionRepository.Object, userProfileRepository.Object);

            // Act
            var result = await goalService.DeletePermanentlyGoalAsync(goalId);

            // Assert
            Assert.IsTrue(result);
            this.goalRepository.Verify(r => r.Delete(It.IsAny<Goal>()), Times.Once);
            this.targetNutritionRepository.Verify(r => r.Delete(It.IsAny<TargetNutrition>()), Times.Once);
        }

        [Test]
        public async Task DeletePermanentlyGoalAsync_FailsWhenGoalNotFound()
        {
            // Arrange
            var goalId = Guid.NewGuid();

            this.goalRepository.Setup(r => r.GetByIdAsync(It.IsAny<Guid>()))
                .ReturnsAsync((Goal)null);

            var goalService = new GoalService(goalRepository.Object, targetNutritionRepository.Object, userProfileRepository.Object);

            // Act
            var result = await goalService.DeletePermanentlyGoalAsync(goalId);

            // Assert
            Assert.IsFalse(result);
            this.goalRepository.Verify(r => r.Delete(It.IsAny<Goal>()), Times.Never);
        }
    }
}

