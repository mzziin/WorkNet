using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.IRepositories
{
    public interface IJobRepository
    {
        List<JobPosting> GetJobsByCriteria(string title, string location);
        JobPosting GetJobDetails(int id);

    }
}
