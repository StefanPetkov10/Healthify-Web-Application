using System.ComponentModel.DataAnnotations;

using static HealthifyApp.Common.EntityValidationConstants.UserProfile;

namespace HealthifyApp.Data.Models
{
    public class UserProfile
    {
        public UserProfile()
        {
            this.Id = Guid.NewGuid();
            this.ApplicationUserProfiles = new HashSet<ApplicationUserProfile>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        [Required]
        [Range(AgeMinValue, AgeMaxValue)]
        public int Age { get; set; }

        [Required]
        [Range((double)HeightMinValue, (double)HeightMaxValue)]
        public float Height { get; set; }

        [Required]
        [Range(WeightMinValue, WeightMaxValue)]
        public float Weight { get; set; }

        [Required]
        public string Gender { get; set; } = null!;

        [Required]
        [MaxLength(GoalsMaxLength)]
        public string Goals { get; set; } = null!;

        public virtual ICollection<ApplicationUserProfile> ApplicationUserProfiles { get; set; }
    }
}
