using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace BLL.Services
{
    public class AccountService
    {
        public OperationResult RegisterJobSeeker(JobSeekerRegisterDTO registerDTO)
        {
            var result = new OperationResult();

            return result;
        }
        public OperationResult RegisterEmployer(EmployerRegisterDTO registerDTO)
        {
            var result = new OperationResult();

            return result;
        }
        public OperationResult Login(LoginDTO loginDTO)
        {
            var result = new OperationResult();

            if(loginDTO.Role == "JobSeeker")
            {
                result.IsSuccess = true;
                result.Message = "Successfully Inserted";
                return result;
            }
            else if(loginDTO.Role == "Employer")
            {
                result.IsSuccess = true;
                result.Message = "Successfully Inserted";
                return result;
            }
            else
            {
                result.IsSuccess = true;
                result.Message = "Successfully Inserted";
                return result;
            }
        }
    }
}
