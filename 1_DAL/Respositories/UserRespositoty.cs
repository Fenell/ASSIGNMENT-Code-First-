using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Context;
using _1_DAL.DomianModels;

namespace _1_DAL.Respositories
{
    public class UserRespositoty
    {
        private DaoTaoContext _daoTaoContext;

        public UserRespositoty()
        {
            _daoTaoContext = new DaoTaoContext();
        }

        public List<User> GetUsersFromDb()
        {
            return _daoTaoContext.Users.ToList();
        }
    }
}
