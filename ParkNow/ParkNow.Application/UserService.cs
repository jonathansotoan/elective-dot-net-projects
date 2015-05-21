﻿using ParkNow.DataAccess;
using System;
using System.Linq;

namespace ParkNow.Application
{
    public class UserService
    {
        private readonly Repository<User> _usersRepository;
        private User _loggedUser;

        public UserService(Repository<User> usersRepository = null)
        {
            _usersRepository = usersRepository ?? new ParkNowRepo<User>();
        }

        public User InsertUser(User userToInsert)
        {
            return _usersRepository.Insert(userToInsert);
        }

        public User GetLoggedUser()
        {
            return _usersRepository.Get().First();
            return _loggedUser;
        }

        public void DeleteUser(int userToDeleteId)
        {
            _usersRepository.Delete(userToDeleteId);
        }

        public void SetLoggedUser(User loggedUser)
        {
            _loggedUser = loggedUser;
        }

        public Role LogIn(string username, string password)
        {
            var userToLogIn = _usersRepository.Get().FirstOrDefault(user => user.Username == username && user.Password == password);

            if (userToLogIn == null)
            {
                throw new Exception("Your username/password pair is not right");
            }
            
            _loggedUser = userToLogIn;
            return _loggedUser.Role;
        }


        private bool DoesUserExist(string username, string password)
        {
            return _usersRepository.Get().Any(user => user.Username == username && user.Password == password);
        }
    }
}