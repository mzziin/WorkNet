using DAL.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        public int AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public OperationResult GetUserIdByUnameAndPwd(string uname, string pwd)
        {
            OperationResult result = new OperationResult();
            if (result.IsSuccess)
            {

            }
            throw new NotImplementedException();
        }
    }
}
