using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HealthifyApp.Data.Models
{
    public class ProgressLog
    {
        public ProgressLog()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        [Comment("Primary key for the progress log.")]
        public Guid Id { get; set; }

        [Required]
        [Comment("The user profile ID.")]
        public Guid UserProfileId { get; set; }
        [ForeignKey(nameof(UserProfileId))]
        public virtual UserProfile UserProfile { get; set; } = null!;

        [Required]
        [Comment("The date of the progress log.")]
        public DateTime Date { get; set; }

        [Comment("The weight of the user.")]
        [Column(TypeName = "decimal(18,2)")]
        public float Weight { get; set; }

        [Comment("The waist of the user.")]
        [Column(TypeName = "decimal(18,2)")]
        public float? Waist { get; set; }

        [Comment("The hips of the user.")]
        [Column(TypeName = "decimal(18,2)")]
        public float? Hips { get; set; }

        [Comment("The chest of the user.")]
        [Column(TypeName = "decimal(18,2)")]
        public float? Chest { get; set; }
    }
}
