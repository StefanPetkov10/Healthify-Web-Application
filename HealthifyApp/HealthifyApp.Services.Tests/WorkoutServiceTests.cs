using System.Linq.Expressions;
using HealthifyApp.Data.Models;
using HealthifyApp.Data.Repository.Interfaces;
using HealthifyApp.Service.Data;
using HealthifyApp.Web.ViewModels.Workout;
using MockQueryable;
using Moq;

namespace HealthifyApp.Services.Tests
{
    [TestFixture]
    public class WorkoutServiceTests
    {
        private Mock<IRepository<Workout, Guid>> workoutRepository;
        private Mock<IRepository<UserProfile, Guid>> userProfileRepository;
        private IList<Workout> workoutData;
        private IList<UserProfile> userProfilesData;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            // Register AutoMapper configurations here, if needed
        }

        [SetUp]
        public void Setup()
        {
            workoutRepository = new Mock<IRepository<Workout, Guid>>();
            userProfileRepository = new Mock<IRepository<UserProfile, Guid>>();

            var userId = Guid.NewGuid();
            userProfilesData = new List<UserProfile>
            {
                new UserProfile
                {
                    Id = userId,
                    IsActiveProfile = true,
                    ApplicationUserProfiles = new List<ApplicationUserProfile>
                    {
                        new ApplicationUserProfile { ApplicationUserId = Guid.NewGuid() }
                    }
                }
            };

            workoutData = new List<Workout>
            {
                new Workout
                {
                    Id = Guid.NewGuid(),
                    UserProfileId = userId,
                    ScheduleDateTime = DateTime.UtcNow,
                    Name = "Morning Run",
                    Description = "Cardio workout"
                }
            };
        }

        [Test]
        public async Task IndexGetWorkoutAsync_ReturnsCorrectData()
        {
            // Arrange
            var userId = userProfilesData[0].ApplicationUserProfiles.First().ApplicationUserId;
            var workoutMockQueryable = workoutData.AsQueryable().BuildMock();

            userProfileRepository.Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<UserProfile, bool>>>()))
                .ReturnsAsync(userProfilesData[0]);
            workoutRepository.Setup(r => r.GetAllAttached())
                .Returns(workoutMockQueryable);

            var service = new WorkoutService(workoutRepository.Object, userProfileRepository.Object);

            // Act
            var result = await service.IndexGetWorkoutAsync(userId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count());
            Assert.AreEqual("Morning Run", result.First().Name);
        }

        [Test]
        public async Task IndexGetWorkoutAsync_ReturnsNull_WhenProfileIsInactive()
        {
            // Arrange
            var userId = userProfilesData[0].ApplicationUserProfiles.First().ApplicationUserId;
            userProfileRepository.Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<UserProfile, bool>>>()))
                .ReturnsAsync(new UserProfile { IsActiveProfile = false });

            var service = new WorkoutService(workoutRepository.Object, userProfileRepository.Object);

            // Act
            var result = await service.IndexGetWorkoutAsync(userId);

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public async Task CreateWorkoutAsync_ReturnsTrue_WhenCreatedSuccessfully()
        {
            // Arrange
            var userId = userProfilesData[0].ApplicationUserProfiles.First().ApplicationUserId;
            var inputModel = new CreateWorkoutFormModel
            {
                Name = "Evening Stretch",
                Description = "Yoga session",
                ScheduleDateTime = DateTime.UtcNow.AddHours(2).ToString("yyyy-MM-ddTHH:mm")
            };

            userProfileRepository.Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<UserProfile, bool>>>()))
                .ReturnsAsync(userProfilesData[0]);
            workoutRepository.Setup(r => r.AddAsync(It.IsAny<Workout>())).Verifiable();

            var service = new WorkoutService(workoutRepository.Object, userProfileRepository.Object);

            // Act
            var result = await service.CreateWorkoutAsync(inputModel, userId);

            // Assert
            Assert.IsTrue(result);
            workoutRepository.Verify(r => r.AddAsync(It.IsAny<Workout>()), Times.Once);
        }

        [Test]
        public async Task CreateWorkoutAsync_ReturnsFalse_WhenProfileIsInactive()
        {
            // Arrange
            var userId = userProfilesData[0].ApplicationUserProfiles.First().ApplicationUserId;
            var inputModel = new CreateWorkoutFormModel
            {
                Name = "Evening Stretch",
                Description = "Yoga session",
                ScheduleDateTime = DateTime.UtcNow.AddHours(2).ToString("yyyy-MM-ddTHH:mm")
            };

            userProfileRepository.Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<UserProfile, bool>>>()))
                .ReturnsAsync(new UserProfile { IsActiveProfile = false });

            var service = new WorkoutService(workoutRepository.Object, userProfileRepository.Object);

            // Act
            var result = await service.CreateWorkoutAsync(inputModel, userId);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public async Task UpdateWorkoutAsync_ReturnsTrue_WhenUpdatedSuccessfully()
        {
            // Arrange
            var userId = userProfilesData[0].ApplicationUserProfiles.First().ApplicationUserId;
            var workoutId = workoutData[0].Id;
            var inputModel = new UpdateWorkoutFormModel
            {
                Id = workoutId.ToString(),
                Name = "Morning Run - Updated",
                Description = "Updated cardio workout",
                ScheduleDateTime = DateTime.UtcNow.AddHours(1).ToString("yyyy-MM-ddTHH:mm")
            };

            var workoutMockQueryable = workoutData.AsQueryable().BuildMock();

            userProfileRepository.Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<UserProfile, bool>>>()))
                .ReturnsAsync(userProfilesData[0]);
            workoutRepository.Setup(repo => repo.GetByIdAsync(workoutId))
                .ReturnsAsync(workoutData[0]);
            workoutRepository.Setup(r => r.GetAllAttached())
                .Returns(workoutMockQueryable);
            workoutRepository.Setup(r => r.UpdateAsync(It.IsAny<Workout>())).Verifiable();

            var service = new WorkoutService(workoutRepository.Object, userProfileRepository.Object);

            // Act
            var result = await service.UpdateWorkoutAsync(inputModel, userId);

            // Assert
            Assert.IsTrue(result);
            workoutRepository.Verify(r => r.UpdateAsync(It.IsAny<Workout>()), Times.Once);
        }

        [Test]
        public async Task DeleteWorkoutAsync_ReturnsTrue_WhenDeletedSuccessfully()
        {
            // Arrange
            var workoutId = workoutData[0].Id;
            workoutRepository.Setup(r => r.GetByIdAsync(workoutId))
                .ReturnsAsync(workoutData[0]);
            workoutRepository.Setup(r => r.Delete(It.IsAny<Workout>())).Verifiable();

            var service = new WorkoutService(workoutRepository.Object, userProfileRepository.Object);

            // Act
            var result = await service.DeleteWorkoutAsync(workoutId);

            // Assert
            Assert.IsTrue(result);
            workoutRepository.Verify(r => r.Delete(It.IsAny<Workout>()), Times.Once);
        }

        [Test]
        public async Task DeleteWorkoutAsync_ReturnsFalse_WhenWorkoutNotFound()
        {
            // Arrange
            var workoutId = Guid.NewGuid();
            workoutRepository.Setup(r => r.GetByIdAsync(workoutId))
                .ReturnsAsync((Workout)null);

            var service = new WorkoutService(workoutRepository.Object, userProfileRepository.Object);

            // Act
            var result = await service.DeleteWorkoutAsync(workoutId);

            // Assert
            Assert.IsFalse(result);
        }
    }
}

