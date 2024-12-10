using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HealthifyApp.Data.Models
{
    public class WaterIntake
    {
        public WaterIntake()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        [Comment("Primary key for the water intake.")]
        public Guid Id { get; set; }

        [Required]
        [Comment("The user profile ID.")]
        public Guid UserProfileId { get; set; }
        [ForeignKey(nameof(UserProfileId))]
        public virtual UserProfile UserProfile { get; set; } = null!;

        [Required]
        [Comment("The daily goal of the water intake.")]
        public float DailyGoal { get; set; }
    }
}
