using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthifyApp.Data.Models
{
    public class ProgressLog
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid UserProfileId { get; set; }
        public virtual UserProfile UserProfile { get; set; } = null!;

        [Required]
        public DateTime Date { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public float Weight { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public float? Waist { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public float? Hips { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public float? Chest { get; set; }
    }
}
