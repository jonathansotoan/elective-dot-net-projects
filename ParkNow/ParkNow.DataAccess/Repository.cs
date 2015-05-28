using System.Data.Entity;
using System.Linq;

namespace ParkNow.DataAccess
{
    /// <summary>
    /// A generic repository that is used to access any entity of a specified DbContext stored in the DB
    /// </summary>
    /// <!-- Author: Jonathan Soto<theja29@hotmail.com>. For licensing, e-mail me -->
    public class Repository<TEntity> where TEntity : class
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(DbContext context)
        {
            _context = context;
            _context.Configuration.LazyLoadingEnabled = false;
            _dbSet = context.Set<TEntity>();
        }

        public IQueryable<TEntity> Get(string includeProperties = "")
        {
            return includeProperties
                    .Trim()
                    .Split(',')
                    .Where(property => property != string.Empty)
                    .Aggregate<string, IQueryable<TEntity>>(_dbSet, (current, property) => current.Include(property));
        }

        public TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public TEntity Insert(TEntity entity)
        {
            TEntity insertedEntity = _dbSet.Add(entity);
            _context.SaveChanges();

            return insertedEntity;
        }

        public void Update(TEntity entityToUpdate)
        {
            _dbSet.Attach(entityToUpdate);
            _context.Entry(entityToUpdate).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(object id)
        {
            TEntity entityToDelete = _dbSet.Find(id);

            if (entityToDelete != null)
            {
                Delete(entityToDelete);
            }

            _context.SaveChanges();
        }

        public void Delete(TEntity entityToDelete)
        {
            _dbSet.Remove(entityToDelete);
            _context.SaveChanges();
        }
    }
}