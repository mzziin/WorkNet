using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class JobDTO
    {
        public int JobId { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public string JobRole { get; set; }
        public string JobLocation { get; set; }
        public int Openings { get; set; }
        public string SalaryRange { get; set; }
        public string PostedDate { get; set; }

    }
}
