using HouseRent.Globals;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HouseRent.Data.DataModels
{
    public class Agent
    {
        [Key]
        public Guid Id { get; init; }

        [Required]
        [MaxLength(Constants.Agent.PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        public Guid UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }
    }
}