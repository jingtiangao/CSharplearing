using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UserManager.DAL;
using UserManager.Models;

namespace UserManager.BLL
{
    public class UserBLL
    {
        private UserDAL userDAL =new UserDAL();
        public User GetUserByName(string username)
        {
            return userDAL.GetUserByUserName(username);
        }

        public IList<User> GetUser()
        {
            return userDAL.GetUsers();
        }
        public int AddUser(User user)
        {
            return userDAL.AddUser(user);
        }
        public int DeleteUser(int id)
        {
            return userDAL.DeleteUser(id);
        }
        public int UpdateUser(User user)
        {
            return userDAL.UpdateUser(user);
        }


    }
}
