using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.DomianModels;
using _1_DAL.Respositories;

namespace _2_BUS.Service
{
    public class UserService
    {
        private UserRespositoty _userRespositoty;

        public UserService()
        {
            _userRespositoty = new UserRespositoty();
        }

        public List<User> GetAllUsers()
        {
            return _userRespositoty.GetUsersFromDb();
        }

        public User GetUserByUserName(string userName)
        {
            return _userRespositoty.GetUsersFromDb().FirstOrDefault(c => c.UserName == userName);
        }

    }
}
