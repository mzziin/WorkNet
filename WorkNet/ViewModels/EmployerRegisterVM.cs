using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorkNet.ViewModels
{
    public class EmployerRegisterVM
    {
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string ContactPerson { get; set; }
        [Required]
        [EmailAddress]
        public string ContactEmail { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Industry { get; set; }
    }
}