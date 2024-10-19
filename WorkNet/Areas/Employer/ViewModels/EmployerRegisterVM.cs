using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorkNet.Areas.Employer.ViewModels
{
    public class EmployerRegisterVM
    {
        [Required(ErrorMessage = "Please enter CompanyName")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Please enter Contact Person")]
        public string ContactPerson { get; set; }

        [Required(ErrorMessage = "Please enter Email")]
        [EmailAddress]
        public string ContactEmail { get; set; }

        [Required(ErrorMessage = "Please enter Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter Industry")]
        public string Industry { get; set; }

        [Required(ErrorMessage = "Please enter Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter Password")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Password \"{0}\" must have {2} characters", MinimumLength = 8)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$", ErrorMessage = "Password must contain: Minimum 8 characters, at least 1 UpperCase Alphabet, 1 LowerCase Alphabet and 1 Number")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter Confirm Password")]
        [Display(Name = "Confirm password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}