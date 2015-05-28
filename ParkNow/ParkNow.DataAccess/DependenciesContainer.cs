namespace ParkNow.DataAccess
{
    /// <summary>
    /// Container of the dependencies of ParkNow.DataAccess namespace
    /// </summary>
    /// <!-- Author: Jonathan Soto<theja29@hotmail.com>. For licensing, e-mail me -->
    internal static class DependenciesContainer
    {
        private static readonly ParkNowContext _parkNowContext = new ParkNowContext();

        public static ParkNowContext ParkNowContext
        {
            get { return _parkNowContext; }
        }
    }
}