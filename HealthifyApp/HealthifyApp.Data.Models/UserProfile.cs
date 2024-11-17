using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HealthifyApp.Data.Models.Enums;
using Microsoft.EntityFrameworkCore;
using static HealthifyApp.Common.EntityValidationConstants.UserProfile;

namespace HealthifyApp.Data.Models
{
    public class UserProfile
    {
        public UserProfile()
        {
            this.Id = Guid.NewGuid();
            this.ApplicationUserProfiles = new HashSet<ApplicationUserProfile>();
            this.Workouts = new HashSet<Workout>();
            this.ProgressLogs = new HashSet<ProgressLog>();
            this.NutritionIntake = new HashSet<NutritionIntake>();
            this.Goal = new HashSet<Goal>();
            this.TargetNutritional = new HashSet<TargetNutrition>();
            this.BMICalculations = new HashSet<BMICalculation>();
            this.WaterIntakes = new HashSet<WaterIntake>();
        }

        [Key]
        [Comment("Primary key for the user profile.")]
        public Guid Id { get; set; }

        [Required]
        [Comment("The first name of the user.")]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [Comment("The last name of the user.")]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        [Required]
        [Comment("The age of the user.")]
        public int Age { get; set; }

        [Required]
        [Comment("The height of the user.")]
        [Column(TypeName = "decimal(18,2)")]
        public float Height { get; set; }

        [Required]
        [Comment("The starting weight of the user.")]
        [Column(TypeName = "decimal(18,2)")]
        public float StartingWeight { get; set; }

        [Required]
        [Comment("The gender of the user")]
        public Gender Gender { get; set; }

        [Required]
        [Comment("The goals of the user.")]
        [MaxLength(GoalsMaxLength)]
        public string Goals { get; set; } = null!;

        [Required]
        [Comment("The creation of the user account.")]
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<ApplicationUserProfile> ApplicationUserProfiles { get; set; }

        public virtual ICollection<Workout> Workouts { get; set; }
        public virtual ICollection<ProgressLog> ProgressLogs { get; set; }
        public virtual ICollection<NutritionIntake> NutritionIntake { get; set; }
        public virtual ICollection<Goal> Goal { get; set; }
        public virtual ICollection<TargetNutrition> TargetNutritional { get; set; }
        public virtual ICollection<BMICalculation> BMICalculations { get; set; }
        public virtual ICollection<WaterIntake> WaterIntakes { get; set; }
    }
}
