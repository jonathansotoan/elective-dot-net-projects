namespace ParkNow.DataAccess
{
    public class ParkNowRepo<TEntity> : Repository<TEntity> where TEntity : class
    {
        public ParkNowRepo() : base(DependenciesContainer.ParkNowContext)
        {
        }
    }
}
