using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HealthifyApp.Data.Models
{
    public class TargetNutrition
    {
        public TargetNutrition()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        [Comment("Primary key for the target nutritional.")]
        public Guid Id { get; set; }

        [Required]
        [Comment("The user profile ID.")]
        public Guid UserProfileId { get; set; }
        [ForeignKey(nameof(UserProfileId))]
        public virtual UserProfile UserProfile { get; set; } = null!;

        [Required]
        [Comment("The goal name.")]
        public string GoalName { get; set; } = null!;

        [Required]
        [Comment("The date of the target nutritional start.")]
        public DateTime StartDate { get; set; }

        [Required]
        [Comment("The calories should intake user.")]
        public int TargetCalories { get; set; }

        [Required]
        [Comment("The protein should intake user.")]
        public int TargetProtein { get; set; }

        [Required]
        [Comment("The carbohydrates should intake user.")]
        public int TargetCarbohydrates { get; set; }

        [Required]
        [Comment("The fats should intake user.")]
        public int TargetFats { get; set; }
    }
}
