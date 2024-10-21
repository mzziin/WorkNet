using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace DAL.Repositories.IRepositories
{
    public interface IUserRepository
    {
        OperationResult GetUserIdByUnameAndPwd(string uname, string pwd, string role);
        int AddUser(User user);
    }
}
