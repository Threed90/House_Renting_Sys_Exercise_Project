using HouseRent.Globals;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HouseRent.Data.DTO
{
    public class UserInfoViewModel
    {
        [MaxLength(Constants.User.FirstNameMaxLength, ErrorMessage = ErrorMessages.User.MaxLengthError)]
        public string FirstName { get; set; }

        [MaxLength(Constants.User.MidNameMaxLength, ErrorMessage = ErrorMessages.User.MaxLengthError)]
        public string MidName { get; set; }

        [MaxLength(Constants.User.LastNameMaxLength, ErrorMessage = ErrorMessages.User.MaxLengthError)]
        public string LastName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = ErrorMessages.RequiredErrorMessage)]
        public string Email { get; set; }

        [Required(ErrorMessage = ErrorMessages.RequiredErrorMessage)]
        [MinLength(Constants.User.UserNameMinLength, ErrorMessage = ErrorMessages.User.MinLengthError)]
        [MaxLength(Constants.User.UserNameMaxLength, ErrorMessage = ErrorMessages.User.MaxLengthError)]
        public string UserName { get; set; }
    }
}
