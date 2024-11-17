using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HealthifyApp.Data.Models
{
    public class NutritionIntake
    {
        public NutritionIntake()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        [Comment("Primary key for the nutrition intake.")]
        public Guid Id { get; set; }

        [Required]
        [Comment("The user profile ID.")]
        public Guid UserProfileId { get; set; }
        [ForeignKey(nameof(UserProfileId))]
        public virtual UserProfile UserProfile { get; set; } = null!;

        [Required]
        [Comment("The date of the intake.")]
        public DateTime Date { get; set; }

        [Required]
        [Comment("The calories intake by user.")]
        public int Calories { get; set; }

        [Required]
        [Comment("The protein intake by user.")]
        public int Protein { get; set; }

        [Required]
        [Comment("The carbohydrates intake by user.")]
        public int Carbohydrates { get; set; }

        [Required]
        [Comment("The fats intake by user.")]
        public int Fats { get; set; }
    }

}
