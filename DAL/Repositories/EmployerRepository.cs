using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories.IRepositories;

namespace DAL.Repositories
{
    public class EmployerRepository : IEmployerRepository
    {
        private WorkNetDBEntities _context;
        public EmployerRepository()
        {
            _context = new WorkNetDBEntities();
        }

        public bool AddEmployer(Employer employer)
        {
            throw new NotImplementedException();
        }

        public Employer GetEmployerById(int id)
        {
            throw new NotImplementedException();
        }
    }
}