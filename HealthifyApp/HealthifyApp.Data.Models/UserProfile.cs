using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HealthifyApp.Data.Models.Enums;
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
            this.NutritionPlans = new HashSet<NutritionPlan>();
            this.BMICalculations = new HashSet<BMICalculation>();
            this.WaterIntakes = new HashSet<WaterIntake>();
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
        public int Age { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public float Height { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public float Weight { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        [MaxLength(GoalsMaxLength)]
        public string Goals { get; set; } = null!;

        [Required]
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<ApplicationUserProfile> ApplicationUserProfiles { get; set; }

        public virtual ICollection<Workout> Workouts { get; set; }
        public virtual ICollection<ProgressLog> ProgressLogs { get; set; }
        public virtual ICollection<NutritionPlan> NutritionPlans { get; set; }
        public virtual ICollection<BMICalculation> BMICalculations { get; set; }
        public virtual ICollection<WaterIntake> WaterIntakes { get; set; }
    }
}
