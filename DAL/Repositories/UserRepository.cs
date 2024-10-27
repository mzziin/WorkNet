using DAL.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;
using System.Data.SqlClient;
using System.Data.Entity.Core.Objects;

namespace DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly WorkNetDBEntities1 _context;
        public UserRepository()
        {
            _context = new WorkNetDBEntities1();
        }
        public int AddUser(User user)
        {
            ObjectParameter op = new ObjectParameter("status", typeof(int));
            _context.sp_InsertUser(user.Username, user.Email, user.PasswordHash, user.Role, op);
            int status = Convert.ToInt32(op.Value);
            if(status != 0)
            {
                return status;
            }
            return 0;
        }

        public OperationResult GetUserIdByUnameAndPwd(string uname, string pwd, string role)
        {
            OperationResult result = new OperationResult();
            var user = _context.sp_GetUserIdAndRole(uname, pwd).FirstOrDefault();
            if (user.UserId != 0 && user.Role == role)
            {
                result.IsSuccess = true;
                result.Message = "Successfully Logged In";
                result.UserId = Convert.ToInt32(user.UserId);
            }
            else
            {
                result.IsSuccess = false;
                result.Message = "Incorrect username or password";
            }
            return result;
        }
    }
}
