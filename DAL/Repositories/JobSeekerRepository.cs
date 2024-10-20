using DAL.Repositories.IRepositories;
using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public JobSeeker GetJobSeekerById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
