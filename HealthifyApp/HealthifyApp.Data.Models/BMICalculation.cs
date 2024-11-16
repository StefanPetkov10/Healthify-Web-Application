using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HealthifyApp.Data.Models
{
    public class BMICalculation
    {
        public BMICalculation()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        [Comment("Primary key for the BMI calculation.")]
        public Guid Id { get; set; }

        [Required]
        [Comment("The user profile ID.")]
        public Guid UserProfileId { get; set; }
        [ForeignKey(nameof(UserProfileId))]
        public virtual UserProfile UserProfile { get; set; } = null!;

        [Required]
        [Comment("The date of the BMI calculation.")]
        public DateTime Date { get; set; }

        [Required]
        [Comment("The height of the user.")]
        [Column(TypeName = "decimal(18,2)")]
        public float Height { get; set; }

        [Required]
        [Comment("The weight of the user.")]
        [Column(TypeName = "decimal(18,2)")]
        public float Weight { get; set; }

        [Required]
        [Comment("The BMI of the user.")]
        [Column(TypeName = "decimal(18,2)")]
        public float BMI { get; set; }

        [Required]
        [Comment("The category of the BMI.")]
        public string Category { get; set; } = null!;
    }
}
