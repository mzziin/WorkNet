using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorkNet.Areas.Employer.ViewModels
{
    public class EmployerRegisterVM
    {
        [Required(ErrorMessage = "Please enter your company name")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Please enter your contact person")]
        public string ContactPerson { get; set; }

        [Required(ErrorMessage = "Please enter your your company email")]
        [EmailAddress]
        public string ContactEmail { get; set; }

        [Required(ErrorMessage = "Please enter your company address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter the industry your company in")]
        public string Industry { get; set; }

        [Required(ErrorMessage = "Please enter your company username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter your company password")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Password \"{0}\" must have {2} characters", MinimumLength = 8)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$", ErrorMessage = "Password must contain: Minimum 8 characters, at least 1 UpperCase Alphabet, 1 LowerCase Alphabet and 1 Number")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Confirm Password")]
        [Display(Name = "Confirm password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}