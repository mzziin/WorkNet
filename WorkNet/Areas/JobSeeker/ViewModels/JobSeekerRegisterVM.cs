﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorkNet.Areas.JobSeeker.ViewModels
{
    public class JobSeekerRegisterVM
    {
        [Required(ErrorMessage = "Please enter your fullname")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Please enter your contact number")]
        [Phone]
        public string ContactNumber { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        public string Address { get; set; }

        public string Skills { get; set; }

        public Nullable<int> Experience { get; set; }

        public string ResumePath { get; set; }

        [Required(ErrorMessage = "Please enter your username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Password \"{0}\" must have {2} characters", MinimumLength = 8)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8}$", ErrorMessage = "Password must contain: Minimum 8 characters, at least 1 UpperCase Alphabet, 1 LowerCase Alphabet and 1 Number")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password")]
        [Display(Name = "Confirm password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
       
    }
}