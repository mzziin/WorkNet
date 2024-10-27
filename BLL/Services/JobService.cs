using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs;
using DAL;
using DAL.Repositories;
using Utility;

namespace BLL.Services
{
    public class JobService
    {
        private readonly JobRepository _jobRepository;
        private readonly JobSeekerRepository _jobSeekerRepository;
        public JobService()
        {
            _jobRepository = new JobRepository();
            _jobSeekerRepository = new JobSeekerRepository();
        }
        public List<JobDTO> SearchJobs(string title, string location)
        {
            List<JobPosting> result = _jobRepository.GetJobsByCriteria(title, location);
            List<JobDTO> jobs = new List<JobDTO>();
            foreach(var item in result)
            {
                var job = new JobDTO
                {
                    JobId = item.JobId,
                    JobTitle = item.JobTitle,
                    JobDescription = item.JobDescription,
                    JobLocation = item.Location,
                    JobRole = item.JobRole,
                    Openings = item.Openings,
                    SalaryRange = item.SalaryRange
                };
                jobs.Add(job);
            }
            return jobs;
        }
        public JobDTO GetJobById(int id)
        {
            var result = _jobRepository.GetJobDetails(id);
            var job = new JobDTO
            {
                JobId = result.JobId,
                JobTitle = result.JobTitle,
                JobDescription = result.JobDescription,
                JobLocation = result.Location,
                JobRole = result.JobRole,
                Openings = result.Openings,
                SalaryRange = result.SalaryRange,
                PostedDate = result.PostedDate.ToString()
            };
            return job;
        }
        public OperationResult SubmitJobApplication(int jobSeekerUserId, int jobId)
        {
            JobSeeker jobSeeker = _jobSeekerRepository.GetJobSeekerByUserId(jobSeekerUserId);

            if(jobSeeker == null)
                return new OperationResult
                {
                    IsSuccess = false,
                    Message = "JobSeeker Not Found."
                };

            var status = _jobRepository.InsertJobApplication(jobSeeker.JobSeekerId, jobId);

            return new OperationResult
            {
                IsSuccess = status,
                Message = status ? "Job application submitted successfully." : "Failed to submit job application."
            };
        }
    }
}
