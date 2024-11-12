using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthifyApp.Data.Models
{
    public class NutritionPlan
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid UserProfileId { get; set; }
        [ForeignKey(nameof(UserProfileId))]
        public virtual UserProfile UserProfile { get; set; } = null!;

        [Required]
        public string Goal { get; set; } = null!;

        [Required]
        public int Calories { get; set; }

        [Required]
        public int Protein { get; set; }

        [Required]
        public int Carbohydrates { get; set; }

        [Required]
        public int Fats { get; set; }
    }
}
