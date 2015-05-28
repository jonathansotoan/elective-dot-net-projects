namespace ParkNow.Application
{
    /// <summary>
    /// Container of the dependencies of ParkNow.Application namespace
    /// </summary>
    /// <!-- Author: Jonathan Soto<theja29@hotmail.com>. For licensing, e-mail me -->
    public static class DependenciesContainer
    {
        private static readonly UserService _userService = new UserService();
        public static UserService UserService
        {
            get { return _userService; }
        }
    }
}
