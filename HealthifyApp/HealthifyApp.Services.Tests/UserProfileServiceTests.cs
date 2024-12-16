using System.Linq.Expressions;
using Healthify.Service.Data;
using HealthifyApp.Data.Models;
using HealthifyApp.Data.Models.Enums;
using HealthifyApp.Data.Repository.Interfaces;
using HealthifyApp.Services.Mapping;
using HealthifyApp.Web.ViewModels.UserProfile;
using MockQueryable;
using Moq;

namespace HealthifyApp.Services.Tests
{
    [TestFixture]
    public class UserProfileServiceTests
    {
        private Mock<IRepository<UserProfile, Guid>> userProfileRepository;
        private Mock<IRepository<ApplicationUserProfile, object>> applicationUserProfileRepository;

        private IList<UserProfile> userProfilesData;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            AutoMapperConfig.RegisterMappings(typeof(UserProfileViewModel).Assembly);
        }

        [SetUp]
        public void Setup()
        {
            this.userProfileRepository = new Mock<IRepository<UserProfile, Guid>>();
            this.applicationUserProfileRepository = new Mock<IRepository<ApplicationUserProfile, object>>();

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
                    CreatedOn = DateTime.UtcNow,
                    IsActiveProfile = true,
                    ApplicationUserProfiles = new List<ApplicationUserProfile>
                    {
                         new ApplicationUserProfile
                         {
                            ApplicationUserId = Guid.NewGuid()
                         }
                    }
                },
                new UserProfile
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Jane",
                    LastName = "Smith",
                    Age = 28,
                    Height = 165.3f,
                    StartingWeight = 65.7f,
                    Gender = Gender.Female,
                    CreatedOn = DateTime.UtcNow,
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
        }


        [Test]
        public async Task CreateUserProfileAsync_CreatesProfileSuccessfully()
        {
            // Arrange
            var formModel = new CreateUserProfileFormModel
            {
                FirstName = "Michael",
                LastName = "Jordan",
                Age = 40,
                Height = 198.5f,
                StartingWeight = 95.0f,
                Gender = "Male"
            };
            var userId = Guid.NewGuid();

            this.userProfileRepository
                .Setup(r => r.AddAsync(It.IsAny<UserProfile>()))
                .Returns(Task.CompletedTask);

            this.applicationUserProfileRepository
                .Setup(r => r.AddAsync(It.IsAny<ApplicationUserProfile>()))
                .Returns(Task.CompletedTask);

            var userProfileService = new UserProfileService(userProfileRepository.Object, applicationUserProfileRepository.Object);

            // Act
            var result = await userProfileService.CreateUserProfileAsync(formModel, userId);

            // Assert
            Assert.IsTrue(result);
            this.userProfileRepository.Verify(r => r.AddAsync(It.IsAny<UserProfile>()), Times.Once);
            this.applicationUserProfileRepository.Verify(r => r.AddAsync(It.IsAny<ApplicationUserProfile>()), Times.Once);
        }

        [Test]
        public async Task IndexGetUserProfileAsync_ReturnsCorrectUserProfile()
        {
            // Arrange
            var userId = userProfilesData[0].ApplicationUserProfiles.First().ApplicationUserId;
            var testProfile = userProfilesData[0];

            var mockData = userProfilesData.BuildMock();

            this.userProfileRepository
                .Setup(r => r.GetAllAttached())
                .Returns(mockData);

            this.userProfileRepository
                .Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<UserProfile, bool>>>()))
                .ReturnsAsync(testProfile);

            var userProfileService = new UserProfileService(userProfileRepository.Object, applicationUserProfileRepository.Object);

            // Act
            var result = await userProfileService.IndexGetUserProfileAsync(userId);

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result!.FirstName, Is.EqualTo(testProfile.FirstName));
            Assert.That(result.LastName, Is.EqualTo(testProfile.LastName));
        }

        [Test]
        public async Task IndexGetUserProfileAsync_ReturnsNull_WhenProfileNotFound()
        {
            // Arrange
            var invalidUserId = Guid.NewGuid();
            var mockData = userProfilesData.AsQueryable().BuildMock();

            this.userProfileRepository
                .Setup(r => r.GetAllAttached())
                .Returns(mockData);

            var userProfileService = new UserProfileService(userProfileRepository.Object, applicationUserProfileRepository.Object);

            // Act
            var result = await userProfileService.IndexGetUserProfileAsync(invalidUserId);

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public async Task SoftDeleteUserProfileAsync_SoftDeletesProfile()
        {
            // Arrange
            var userId = userProfilesData[0].Id;

            this.userProfileRepository
                .Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<UserProfile, bool>>>()))
                .ReturnsAsync(userProfilesData[0]);

            this.userProfileRepository
                .Setup(r => r.UpdateAsync(It.IsAny<UserProfile>()))
                .ReturnsAsync(true);

            var userProfileService = new UserProfileService(userProfileRepository.Object, applicationUserProfileRepository.Object);

            // Act
            var result = await userProfileService.SoftDeleteUserProfileAsync(userId);

            // Assert
            Assert.IsTrue(result);
            Assert.IsFalse(userProfilesData[0].IsActiveProfile);
            this.userProfileRepository.Verify(r => r.UpdateAsync(It.IsAny<UserProfile>()), Times.Once);
        }

        [Test]
        public async Task SoftDeleteUserProfileAsync_ReturnsFalse_WhenProfileNotFound()
        {
            // Arrange
            var invalidUserId = Guid.NewGuid();

            this.userProfileRepository
                .Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<UserProfile, bool>>>()))
                .ReturnsAsync((UserProfile)null);

            var userProfileService = new UserProfileService(userProfileRepository.Object, applicationUserProfileRepository.Object);

            // Act
            var result = await userProfileService.SoftDeleteUserProfileAsync(invalidUserId);

            // Assert
            Assert.IsFalse(result);
            this.userProfileRepository.Verify(r => r.UpdateAsync(It.IsAny<UserProfile>()), Times.Never);
        }
    }
}