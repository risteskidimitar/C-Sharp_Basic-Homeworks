﻿using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Models;

namespace WebApi.Fake_Database
{
    internal static class MockData
    {
        internal static List<User> GetMockedUsers()
        {
            User john = new User()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe"
            };
            User bob = new User()
            {
                Id = 2,
                FirstName = "Bob",
                LastName = "Bobsky"
            };
            User mark = new User()
            {
                Id = 3,
                FirstName = "Mark",
                LastName = "Dean",
                Friends = new List<User>() { john, bob }
            };
            User harry = new User()
            {
                Id = 4,
                FirstName = "Harry",
                LastName = "O'Connel",
                Friends = new List<User>() { mark }
            };
            User jina = new User()
            {
                Id = 5,
                FirstName = "Jina",
                LastName = "Johnson",
                Friends = new List<User>() { harry, bob, john }
            };
            return new List<User>() { john, bob, harry, mark, jina };
        }
        internal static List<Admin> GetMockedAdmins()
        {
            Admin miki = new Admin()
            {
                Id = 10,
                FirstName = "Miki",
                LastName = "Mikikj",
                Friends = new List<Admin>() { }

            };
            Admin gordan = new Admin()
            {
                Id = 20,
                FirstName = "Gordan",
                LastName = "Babov",
                Friends = new List<Admin>() { miki }

            };

            Admin dime = new Admin()
            {
                Id = 30,
                FirstName = "Dimitar",
                LastName = "Risteski",
                Friends = new List<Admin>() { miki, gordan }

            };

            return new List<Admin>() { miki, gordan, dime };
        }
    }
}