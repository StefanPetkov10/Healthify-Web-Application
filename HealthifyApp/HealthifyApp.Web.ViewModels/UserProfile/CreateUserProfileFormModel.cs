namespace HealthifyApp.Web.ViewModels.UserProfile
{
    public class CreateUserProfileFormModel
    {
        public string FirstName { get; set; } = null!;


        public string LastName { get; set; } = null!;


        public int Age { get; set; }


        public float Height { get; set; }


        public float StartingWeight { get; set; }


        public string Gender { get; set; } = null!;
    }
}
