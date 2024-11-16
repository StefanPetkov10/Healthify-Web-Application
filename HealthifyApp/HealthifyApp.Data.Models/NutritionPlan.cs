using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HealthifyApp.Data.Models
{
    public class NutritionPlan
    {
        public NutritionPlan()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        [Comment("Primary key for the nutrition plan.")]
        public Guid Id { get; set; }

        [Required]
        [Comment("The user profile ID.")]
        public Guid UserProfileId { get; set; }
        [ForeignKey(nameof(UserProfileId))]
        public virtual UserProfile UserProfile { get; set; } = null!;

        [Required]
        [Comment("The goal of the nutrition plan.")]
        public string Goal { get; set; } = null!;

        [Required]
        [Comment("The calories should intake user.")]
        public int Calories { get; set; }

        [Required]
        [Comment("The protein should intake user.")]
        public int Protein { get; set; }

        [Required]
        [Comment("The carbohydrates should intake user.")]
        public int Carbohydrates { get; set; }

        [Required]
        [Comment("The fats should intake user.")]
        public int Fats { get; set; }
    }
}
