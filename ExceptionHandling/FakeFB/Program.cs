using FakeFB.Logger;
using System;
using WebApi.Exceptions;
using WebApi.Service;

namespace FakeFB
{
    class Program
    {
        static void Main(string[] args)
        {

            var allUser = UserService.GetAllUsers();


            try
            {
                //var userByID = UserService.GetUserByID(4);
                var usersFrineds = UserService.GetAllUsersFriends(null);
                foreach (var user in usersFrineds)
                {
                    Console.WriteLine(user.FirstName);
                }
                //Console.WriteLine(userByID.FirstName);
            }
            catch(UserServiceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                var logger = new UserExceptionsLogger();
                logger.LogExeption(ex);
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("I procesed to work");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            var allAdmins = AdminService.GetAllAdmins();

            try
            {
                var AdminByID = AdminService.GetAdminByID(30);
                Console.WriteLine(AdminByID.FirstName);
                var AdminsFriends = AdminService.GetAllAdminsFriends(null);// for admin service exception
                //var miki = AdminService.GetAdminByID(10);

                //if (miki.FirstName.Length > 3)//for logger exception
                //{
                //    throw new Exception();
                //}
                //var AdminsFriends = AdminService.GetAllAdminsFriends(AdminByID);
                //AdminsFriends.ForEach(friend => Console.WriteLine(friend.FirstName));
            }
            catch (AdminServiceException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($" Admin Service exeption: {ex.Message} {ex.StackTrace}");
                Console.WriteLine($"Inner Exeption msg: {ex.InnerException.Message}");
            }

            catch (Exception ex)
            {
                var loggeradmin = new AdminExceptionsLogger();
                loggeradmin.AdminLogExeption(ex);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Logger exception :  {ex.Message}");
            }


            Console.ReadLine();
        }
    }
}
