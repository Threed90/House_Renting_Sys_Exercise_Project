using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseRent.Data.DataModels
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string? FirstName { get; set; } = null!;
        public string? LastName { get; set; } = null!;
        public string? MidName { get; set; }


    }
}
