using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Models {
    public class RegisterModel {
        [Required(ErrorMessage = "Username not specified")]
        [MinLength(4, ErrorMessage = "Username length must be at least 4 characters")]
        [MaxLength(10, ErrorMessage = "Username length cannot exceed 10 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email not specified")]
        [EmailAddress(ErrorMessage = "Incorrect e-mail format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password not specified")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Password length must be at least 6 characters")]
        [MaxLength(12, ErrorMessage = "Password length cannot exceed 12 characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password not specified")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}
