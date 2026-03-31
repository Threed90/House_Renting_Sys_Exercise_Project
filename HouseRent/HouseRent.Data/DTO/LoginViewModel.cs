using HouseRent.Globals;
using System.ComponentModel.DataAnnotations;

namespace HouseRent.Data.DTO
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = ErrorMessages.RequiredErrorMessage)]
        public string UserNameOrEmail { get; set; }

        [Required(ErrorMessage = ErrorMessages.RequiredErrorMessage)]
        public string Password { get; set; }
    }
}
