namespace HealthifyApp.Web.ViewModels.UserProfile
{
    using HealthifyApp.Data.Models;
    using HealthifyApp.Services.Mapping;

    public class DeleteUserProfileViewModel : IMapFrom<UserProfile>
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
    }
}
