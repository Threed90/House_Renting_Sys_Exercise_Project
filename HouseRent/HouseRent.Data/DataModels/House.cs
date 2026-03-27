using HouseRent.Globals;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HouseRent.Data.DataModels
{
    public class House
    {
        [Key]
        public Guid Id { get; init; }

        [Required]
        [MaxLength(Constants.House.TitleMaxLength)]
        public string Title { get; set; }

        [Required]
        [MaxLength(Constants.House.AddressMaxLength)]
        public string Address { get; set; }

        [Required]
        [MaxLength(Constants.House.DescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        [Range(Constants.House.MinPricePerMonth, Constants.House.MaxPricePerMonth)]
        public decimal PricePerMonth { get; set; }

        [Required]
        public Guid CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category {  get; set; }

        [Required]
        public Guid AgentId { get; set; }

        [ForeignKey(nameof(AgentId))]
        public Agent Agent { get; set; }

        public Guid? RenterId { get; set; }

    }
}