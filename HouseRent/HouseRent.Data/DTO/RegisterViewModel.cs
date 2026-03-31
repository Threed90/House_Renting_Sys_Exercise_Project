using HouseRent.Globals;
using System.ComponentModel.DataAnnotations;

namespace HouseRent.Data.DTO
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = ErrorMessages.RequiredErrorMessage)]
        [MinLength(Constants.User.UserNameMinLength, ErrorMessage = ErrorMessages.User.MinLengthError)]
        [MaxLength(Constants.User.UserNameMaxLength, ErrorMessage = ErrorMessages.User.MaxLengthError)]
        public string Username { get; set; }

        [Required(ErrorMessage = ErrorMessages.RequiredErrorMessage)]
        [MinLength(Constants.User.PasswordMinLength, ErrorMessage = ErrorMessages.User.MinLengthError)]
        [MaxLength(Constants.User.PasswordMaxLength, ErrorMessage = ErrorMessages.User.MaxLengthError)]
        public string Password { get; set; }

        [Required(ErrorMessage = ErrorMessages.RequiredErrorMessage)]
        [Compare(nameof(Password), ErrorMessage = ErrorMessages.User.PasswordsDoNotMatch)]
        public string RePass { get; set; }

        [Required(ErrorMessage = ErrorMessages.RequiredErrorMessage)]
        [EmailAddress]
        public string Email { get; set; }
    }
}
