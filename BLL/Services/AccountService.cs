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
        public void RegisterJobSeeker(JobSeekerRegisterDTO registerDTO)
        {

        }
        public void RegisterEmployer(EmployerRegisterDTO registerDTO)
        {

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
