using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AccountService
    {
        public bool RegisterJobSeeker(JobSeekerRegisterDTO registerDTO)
        {
            return true;
        }
        public bool RegisterEmployer(EmployerRegisterDTO registerDTO)
        {
            return true;
        }
        public bool Login(LoginDTO loginDTO)
        {
            if(loginDTO.Role == "JobSeeker")
            {
                return true;
            }
            else if(loginDTO.Role == "Employer")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
