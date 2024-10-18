using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorkNet.ViewModels
{
    public class JobSeekerRegisterVM
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        [Phone]
        public string ContactNumber { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Skills { get; set; }
        public Nullable<int> Experience { get; set; }
        [Required]
        public string ResumePath { get; set; }
    }
}