using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthifyApp.Data.Models
{
    public class WaterIntake
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
        public float DailyGoal { get; set; }

        public float? Consumed { get; set; }
    }
}
