using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApi.Exceptions;
using WebApi.Fake_Database;
using WebApi.Models;

namespace WebApi.Service
{
    public static class AdminService
    {
        public static List<Admin> GetAllAdmins()
        {
            return DB.Admins;
        }

        public static Admin GetAdminByID(int searchID)
        {
            var admin = DB.Admins.Single(admin => admin.Id == searchID);

            return admin;
        }

        public static List<Admin> GetAllAdminsFriends(Admin name)
        {
                if (name == null)
                {
                    throw new AdminServiceException("You send me a null", new Exception());
                }
                var allAdminFriends = DB.Admins.Single(admin => admin.Equals(name));
                return allAdminFriends.Friends;

        }
    }
}
