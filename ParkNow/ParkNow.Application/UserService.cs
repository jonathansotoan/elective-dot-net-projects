﻿using ParkNow.DataAccess;
using System;
using System.Linq;

namespace ParkNow.Application
{
    /// <summary>
    /// Performs the required operations within users for the application to work
    /// </summary>
    /// <!-- Author: Jonathan Soto<theja29@hotmail.com>. For licensing, e-mail me -->
    public class UserService
    {
        private readonly Repository<User> _usersRepository;
        private User _loggedUser;

        public UserService(Repository<User> usersRepository = null)
        {
            _usersRepository = usersRepository ?? new ParkNowRepo<User>();
        }

        public User GetById(int nationalId)
        {
            return _usersRepository.GetById(nationalId);
        }

        public IQueryable<User> GetUsers(string includeProperties = "")
        {
            return _usersRepository.Get(includeProperties);
        }

        public User InsertUser(User userToInsert)
        {
            return _usersRepository.Insert(userToInsert);
        }

        public User GetLoggedUser()
        {
            return _loggedUser;
        }

        public void DeleteUser(int userToDeleteId)
        {
            _usersRepository.Delete(userToDeleteId);
        }

        public void UpdateUser(User userToUpdate)
        {
            _usersRepository.Update(userToUpdate);
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

        public void LogOut()
        {
            _loggedUser = null;
        }


        private bool DoesUserExist(string username, string password)
        {
            return _usersRepository.Get().Any(user => user.Username == username && user.Password == password);
        }
    }
}