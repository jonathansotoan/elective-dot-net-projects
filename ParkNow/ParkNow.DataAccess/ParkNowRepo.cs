namespace ParkNow.DataAccess
{
    /// <summary>
    /// The repository that is used to access any entity of ParkNowContext stored in the DB
    /// </summary>
    /// <!-- Author: Jonathan Soto<theja29@hotmail.com>. For licensing, e-mail me -->
    public class ParkNowRepo<TEntity> : Repository<TEntity> where TEntity : class
    {
        public ParkNowRepo() : base(DependenciesContainer.ParkNowContext)
        {
        }
    }
}
