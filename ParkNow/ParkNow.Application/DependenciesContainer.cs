namespace ParkNow.Application
{
    public class DependenciesContainer
    {
        private static UserService _userService = new UserService();
        public static UserService UserService
        {
            get { return _userService; }
        }
    }
}
