using ParkNow.DataAccess;
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

        public User GetLoggedUser()
        {
            return _usersRepository.Get().First();
            return _loggedUser;
        }

        public void SetLoggedUser(User loggedUser)
        {
            _loggedUser = loggedUser;
        }

        public void LogIn(string username, string password)
        {
            var userToLogIn = new User
            {
                Username = username,
                Password = password
            };

            if (DoesUserExist(username, password))
            {
                _loggedUser = userToLogIn;
                return;
            }

            throw new Exception("Your username/password pair is not right");
        }


        private bool DoesUserExist(string username, string password)
        {
            return _usersRepository.Get().Any(user => user.Username == username && user.Password == password);
        }
    }
}