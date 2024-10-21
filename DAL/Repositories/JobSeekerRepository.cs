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
        private readonly WorkNetDBEntities _context;
        public JobSeekerRepository()
        {
            _context = new WorkNetDBEntities();
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
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public JobSeeker GetJobSeekerById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
