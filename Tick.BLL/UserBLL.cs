using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tick.DAL;
using Tick.BO;

namespace Tick.BLL
{
    public class UserBLL
    {
        private UserDAL userDAL_db;

        public UserBLL()
        {
            userDAL_db = new UserDAL();
        }

        public bool Insert(User user)
        {
            return userDAL_db.Add(user);
        }

        public bool GetLogIn(User user)
        {
            return userDAL_db.GetLogIn(user);
        }
    }
}
