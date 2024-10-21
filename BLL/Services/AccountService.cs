using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;
using DAL;
using DAL.Repositories;

namespace BLL.Services
{
    public class AccountService
    {
        private readonly JobSeekerRepository _jobRepository;
        private readonly EmployerRepository _employerRepository;
        private readonly UserRepository _userRepository;
        public AccountService()
        {
            _userRepository = new UserRepository();
            _jobRepository = new JobSeekerRepository();
            _employerRepository = new EmployerRepository();
        }

        public OperationResult RegisterJobSeeker(JobSeekerRegisterDTO registerDTO)
        {
            var user = new User
            {
                Username = registerDTO.Username,
                Email = registerDTO.Email,
                PasswordHash = registerDTO.Password,
                Role = "JobSeeker"
            };
            bool status = false;
            var result = new OperationResult();
            try
            {
                int uid = _userRepository.AddUser(user);
                var jobSeeker = new JobSeeker
                {
                    UserId = uid,
                    FullName = registerDTO.FullName,
                    Address = registerDTO.Address,
                    ContactNumber = registerDTO.ContactNumber,
                    Experience = registerDTO.Experience,
                    ResumePath = registerDTO.ResumePath,
                    Skills = registerDTO.Skills,
                };
                status = _jobRepository.AddJobSeeker(jobSeeker);
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Message = "An unexpected error occurred: "+ex.Message;
                return result;
            }
            if (status)
            {
                result.IsSuccess = true;
                result.Message = "Successfully Registered";
            }
            else
            {
                result.IsSuccess = false;
                result.Message = "Something went wrong";
            }
            return result;
        }

        public OperationResult RegisterEmployer(EmployerRegisterDTO registerDTO)
        {
            var user = new User
            {
                Username = registerDTO.Username,
                Email = registerDTO.ContactEmail,
                PasswordHash = registerDTO.Password,
                Role = "Employer"
            };
            bool status=false;
            var result = new OperationResult();
            try
            {
                int uid = _userRepository.AddUser(user);
                var employer = new Employer
                {
                    UserId = uid,
                    CompanyName = registerDTO.CompanyName,
                    Address = registerDTO.Address,
                    ContactEmail = registerDTO.ContactEmail,
                    ContactPerson = registerDTO.ContactPerson,
                    Industry = registerDTO.Industry,
                };
                status = _employerRepository.AddEmployer(employer);
            }
            catch(Exception ex)
            {
                result.IsSuccess = false;
                result.Message = "An unexpected error occurred: " + ex.Message;
                return result;
            }
            if (status)
            {
                result.IsSuccess = true;
                result.Message = "Successfully Inserted";
            }
            else
            {
                result.IsSuccess = false;
                result.Message = "Something went wrong";
            }
            return result;
        }
        public OperationResult Login(LoginDTO loginDTO)
        {
            return _userRepository.GetUserIdByUnameAndPwd(loginDTO.Username, loginDTO.Password, loginDTO.Role);
        }
    }
}
