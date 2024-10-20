using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.IRepositories
{
    public interface IEmployerRepository
    {
        Employer GetEmployerById(int id);
        bool AddEmployer(Employer employer); 
    }
}
