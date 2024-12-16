using System.Linq.Expressions;
using HealthifyApp.Data.Models;
using HealthifyApp.Data.Repository.Interfaces;
using HealthifyApp.Service.Data;
using HealthifyApp.Web.ViewModels.ProgressLog;
using MockQueryable;
using Moq;

namespace HealthifyApp.Services.Tests
{
    [TestFixture]
    public class ProgressLogServiceTests
    {
        private Mock<IRepository<ProgressLog, Guid>> progressLogRepository;
        private Mock<IRepository<UserProfile, Guid>> userProfileRepository;
        private Mock<IRepository<Goal, Guid>> goalRepository;

        private IList<UserProfile> userProfilesData;
        private IList<ProgressLog> progressLogsData;
        private IList<Goal> goalData;

        [SetUp]
        public void Setup()
        {
            this.progressLogRepository = new Mock<IRepository<ProgressLog, Guid>>();
            this.userProfileRepository = new Mock<IRepository<UserProfile, Guid>>();
            this.goalRepository = new Mock<IRepository<Goal, Guid>>();

            this.userProfilesData = new List<UserProfile>
            {
                new UserProfile
                {
                    Id = Guid.NewGuid(),
                    FirstName = "John",
                    LastName = "Doe",
                    IsActiveProfile = true
                }
            };

            this.goalData = new List<Goal>
            {
                new Goal
                {
                    Id = Guid.NewGuid(),
                    UserProfileId = userProfilesData[0].Id,
                    GoalWeight = 70.0f
                }
            };

            this.progressLogsData = new List<ProgressLog>
            {
                new ProgressLog
                {
                    Id = Guid.NewGuid(),
                    UserProfileId = userProfilesData[0].Id,
                    Date = DateTime.Now.AddDays(-1),
                    CurrentWeight = 80.0f
                }
            };
        }

        [Test]
        public async Task IndexGetProgressLogAsync_ReturnsProgressLogsForActiveUser()
        {
            // Arrange
            var userId = userProfilesData[0].Id;
            var goal = goalData[0];
            var mockProgressLogs = progressLogsData.AsQueryable().BuildMock();

            this.userProfileRepository.Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<UserProfile, bool>>>()))
                .ReturnsAsync(userProfilesData[0]);

            this.goalRepository.Setup(r => r.GetAllAttached())
                .Returns(goalData.AsQueryable().BuildMock());

            this.progressLogRepository.Setup(r => r.GetAllAttached())
                .Returns(mockProgressLogs);

            var service = new ProgressLogService(progressLogRepository.Object, userProfileRepository.Object, goalRepository.Object);

            // Act
            var result = await service.IndexGetProgressLogAsync(userId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ProgressLogs.Count());
        }

        [Test]
        public async Task IndexGetProgressLogAsync_ReturnsNullForInactiveUser()
        {
            // Arrange
            var userId = userProfilesData[0].Id;
            userProfilesData[0].IsActiveProfile = false;

            this.userProfileRepository.Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<UserProfile, bool>>>()))
                .ReturnsAsync(userProfilesData[0]);

            var service = new ProgressLogService(progressLogRepository.Object, userProfileRepository.Object, goalRepository.Object);

            // Act
            var result = await service.IndexGetProgressLogAsync(userId);

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public async Task AddProgressLogAsync_ReturnsFormModelWhenNoLogExistsForToday()
        {
            // Arrange
            var mockLogs = progressLogsData.AsQueryable().BuildMock();

            this.progressLogRepository.Setup(r => r.GetAllAttached())
                .Returns(mockLogs);

            var service = new ProgressLogService(progressLogRepository.Object, userProfileRepository.Object, goalRepository.Object);

            // Act
            var result = await service.AddProgressLogAsync();

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task AddProgressLogAsync_ReturnsNullWhenLogExistsForToday()
        {
            // Arrange
            var userId = userProfilesData[0].Id;
            var today = DateTime.UtcNow;
            this.progressLogRepository.Setup(r => r.GetAllAsync())
                .ReturnsAsync(new List<ProgressLog>
                {
                    new ProgressLog { Date = today }
                });

            var service = new ProgressLogService(progressLogRepository.Object, userProfileRepository.Object, goalRepository.Object);

            // Act
            var result = await service.AddProgressLogAsync();

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public async Task AddProgressLogAsync_AddsLogSuccessfully()
        {
            // Arrange
            var inputModel = new AddProgressLogFormModel
            {
                Date = DateTime.UtcNow.ToString("dd-MM-yyyy"),
                CurrentWeight = 75.0f
            };
            var userId = userProfilesData[0].Id;

            this.userProfileRepository.Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<UserProfile, bool>>>()))
                .ReturnsAsync(userProfilesData[0]);

            this.progressLogRepository.Setup(r => r.AddAsync(It.IsAny<ProgressLog>()))
                .Returns(Task.CompletedTask);

            var service = new ProgressLogService(progressLogRepository.Object, userProfileRepository.Object, goalRepository.Object);

            // Act
            var result = await service.AddProgressLogAsync(inputModel, userId);

            // Assert
            Assert.IsTrue(result);
            this.progressLogRepository.Verify(r => r.AddAsync(It.IsAny<ProgressLog>()), Times.Once);
        }
    }
}