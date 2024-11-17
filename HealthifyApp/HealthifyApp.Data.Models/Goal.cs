using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HealthifyApp.Data.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace HealthifyApp.Data.Models
{
    public class Goal
    {
        public Goal()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        [Comment("Primary key for the goal.")]
        public Guid Id { get; set; }

        [Required]
        [Comment("The user profile ID.")]
        public Guid UserProfileId { get; set; }
        [ForeignKey(nameof(UserProfileId))]
        public virtual UserProfile UserProfile { get; set; } = null!;

        [Required]
        [Comment("The date of the goal start.")]
        public DateTime StartDate { get; set; }

        [Required]
        [Comment("The goal chois")]
        public Goals GoalType { get; set; }

        [Required]
        [Comment("The activity of the user.")]
        public Activity Activity { get; set; }

        [Required]
        [Comment("The user's goal weight.")]
        [Column(TypeName = "decimal(18,2)")]
        public float GoalWeight { get; set; }

        public float? GoalWaist { get; set; }

        public float? GoalHips { get; set; }

        public float? GoalChest { get; set; }
    }
}
