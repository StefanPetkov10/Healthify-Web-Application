using HealthifyApp.Services.Mapping;

namespace HealthifyApp.Web.ViewModels.UserProfile
{
    using HealthifyApp.Data.Models;
    public class UserProfileViewModel : IMapFrom<UserProfile>
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public int Age { get; set; }

        public float Height { get; set; }

        public float StartingWeight { get; set; }

        public string Gender { get; set; } = null!;

        public bool IsActiveProfile { get; set; }

    }
}
