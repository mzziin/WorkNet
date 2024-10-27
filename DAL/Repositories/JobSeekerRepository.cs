using DAL.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class JobSeekerRepository : IJobSeekerRepository
    {
        private readonly WorkNetDBEntities1 _context;
        public JobSeekerRepository()
        {
            _context = new WorkNetDBEntities1();
        }
        public bool AddJobSeeker(JobSeeker jobSeeker)
        {
            ObjectParameter op = new ObjectParameter("status", typeof(int));
            _context.sp_InsertJobSeeker(
                jobSeeker.UserId,
                jobSeeker.FullName,
                jobSeeker.ContactNumber,
                jobSeeker.Address,
                jobSeeker.Skills,
                jobSeeker.Experience,
                jobSeeker.ResumePath,
                op
                );

            int status = Convert.ToInt32(op.Value);

            if(status == 1)
                return true;
            else
                return false;
        }

        public JobSeeker GetJobSeekerByUserId(int UserId)
        {
            var result = _context.sp_GetJobSeekerByUserId(UserId).FirstOrDefault();

            if (result == null)
                return null;

            return new JobSeeker
            {
                UserId = result.UserId,
                FullName = result.FullName,
                JobSeekerId = result.JobSeekerId,
                Address = result.Address,
                ContactNumber = result.ContactNumber,
                Experience = result.Experience,
                ResumePath = result.ResumePath,
                Skills = result.Skills,
            };
        }
    }
}
