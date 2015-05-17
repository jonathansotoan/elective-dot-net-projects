using System.Linq;
using ParkNow.DataAccess;

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
            return _loggedUser;
        }

        public void SetLoggedUser(User loggedUser)
        {
            _loggedUser = loggedUser;
        }

        public bool DoesUserExist(string username, string password)
        {
            return _usersRepository.Get().Any(user => user.Username == username && user.Password == password);
        }
    }
}