using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorkNet.Areas.JobSeeker.ViewModels
{
    public class JobSeekerLoginVM
    {
        [Required(ErrorMessage ="Please enter your username")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Please enter your password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}