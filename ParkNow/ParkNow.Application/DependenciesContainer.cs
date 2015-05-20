namespace ParkNow.Application
{
    public static class DependenciesContainer
    {
        private static readonly UserService _userService = new UserService();
        public static UserService UserService
        {
            get { return _userService; }
        }
    }
}
