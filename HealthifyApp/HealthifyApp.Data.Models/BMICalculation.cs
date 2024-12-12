using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HealthifyApp.Data.Models.Enums;
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
        [Comment("The BMI of the user.")]
        [Column(TypeName = "decimal(18,2)")]
        public float BMI { get; set; }

        [Required]
        [Comment("The category of the BMI.")]
        public BMICategory Category { get; set; }
    }
}
