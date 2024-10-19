using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class JobSeekerRegisterDTO
    {
        public string FullName { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string Skills { get; set; }
        public Nullable<int> Experience { get; set; }
        public string ResumePath { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
