using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApi.Exceptions;
using WebApi.Fake_Database;
using WebApi.Models;

namespace WebApi.Service
{
    public static class UserService
    {
        public static List<User> GetAllUsers()
        {
            return DB.Users;
        }


        public static User GetUserByID(int id)
        {
            var user = DB.Users.Single(user => user.Id == id);
            return user;
        }

        public static List<User> GetAllUsersFriends(User FindUser)
        {
            try
            {
                if (FindUser == null)
                {
                    throw new UserServiceException("You send me a null", new Exception());
                }
                var allUsersFriends = DB.Users.Single(user => user.Equals(FindUser));
                return allUsersFriends.Friends;
            }
            catch (Exception ex)
            {

                throw new Exception();
            }

        }
    }
}
