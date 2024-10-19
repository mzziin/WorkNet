using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class EmployerRegisterDTO
    {
        public string CompanyName { get; set; }
        public string ContactPerson { get; set; }
        public string ContactEmail { get; set; }
        public string Address { get; set; }
        public string Industry { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
