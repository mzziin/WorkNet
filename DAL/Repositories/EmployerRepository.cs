using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories.IRepositories;

namespace DAL.Repositories
{
    public class EmployerRepository : IEmployerRepository
    {
        private readonly WorkNetDBEntities _context;
        public EmployerRepository()
        {
            _context = new WorkNetDBEntities();
        }

        public bool AddEmployer(Employer employer)
        {
            ObjectParameter op = new ObjectParameter("status", typeof(int));
            _context.sp_InsertEmployer(
                employer.UserId,
                employer.CompanyName,
                employer.ContactPerson,
                employer.ContactEmail,
                employer.Address,
                employer.Industry,
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


        public Employer GetEmployerById(int id)
        {
            throw new NotImplementedException();
        }
    }
}