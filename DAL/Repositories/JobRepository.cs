using DAL.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity.Core.Objects;
using Utility;

namespace DAL.Repositories
{
    public class JobRepository : IJobRepository
    {
        private readonly WorkNetDBEntities1 _entity;
        public JobRepository()
        {
            _entity = new WorkNetDBEntities1();
        }

        public JobPosting GetJobDetails(int id)
        {
            var result = _entity.sp_GetJobDetail(id).FirstOrDefault();

            if (result == null)
                return null;
            
            return new JobPosting
            {
                JobId = result.JobId,
                CategoryId = result.CategoryId,
                EmployerId = result.EmployerId,
                JobDescription = result.JobDescription,
                JobTitle = result.JobTitle,
                JobRole = result.JobRole,
                JobType = result.JobType,
                Location = result.Location,
                Openings = result.Openings,
                PostedDate = result.PostedDate,
                SalaryRange = result.SalaryRange
            };
        }

        public List<JobPosting> GetJobsByCriteria(string title, string location)
        {
            List<JobPosting> Jobs = new List<JobPosting>();
            var result = _entity.sp_SearchJobs(title, location);

            foreach(var item in result)
            {
                var job = new JobPosting
                {
                    JobId = item.JobId,
                    CategoryId = item.CategoryId,
                    EmployerId = item.EmployerId,
                    JobTitle = item.JobTitle,
                    JobDescription = item.JobDescription,
                    JobType = item.JobType,
                    JobRole = item.JobRole,
                    Location = item.Location,
                    Openings = item.Openings,
                    SalaryRange = item.SalaryRange,
                    PostedDate = item.PostedDate,
                };
                Jobs.Add(job);
            }
            return Jobs;
        }
        public bool InsertJobApplication(int jobSeekerId, int jobId)
        {
            ObjectParameter op = new ObjectParameter("status", typeof(int));
            _entity.sp_InsertJobApplication(jobSeekerId, jobId, op);
            int status = Convert.ToInt32(op.Value);
            
            if(status > 0)
                return true;
            else
                return false;
        }
    }
}
