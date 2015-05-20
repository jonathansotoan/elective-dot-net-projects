namespace ParkNow.DataAccess
{
    internal static class DependenciesContainer
    {
        private static readonly ParkNowContext _parkNowContext = new ParkNowContext();

        public static ParkNowContext ParkNowContext
        {
            get { return _parkNowContext; }
        }
    }
}