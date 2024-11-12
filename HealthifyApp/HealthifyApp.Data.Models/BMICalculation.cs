using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthifyApp.Data.Models
{
    public class BMICalculation
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid UserProfileId { get; set; }
        [ForeignKey(nameof(UserProfileId))]
        public virtual UserProfile UserProfile { get; set; } = null!;

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public float Height { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public float Weight { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public float BMI { get; set; }

        [Required]
        public string Category { get; set; } = null!;
    }
}
