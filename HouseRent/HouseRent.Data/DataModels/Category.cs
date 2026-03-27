using HouseRent.Globals;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HouseRent.Data.DataModels
{
    public class Category
    {
        [Key]
        public Guid Id { get; init; }

        [Required]
        [MaxLength(Constants.Category.NameMaxLength)]
        public string Name { get; set; } = null!;

        public IEnumerable<House> Houses { get; init; } = new List<House>();
    }
}
