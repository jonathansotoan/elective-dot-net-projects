using System.Data.Entity;
using System.Linq;

namespace ParkNow.DataAccess
{
    public class Repository<TEntity> where TEntity : class
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public IQueryable<TEntity> Get(string includeProperties = "")
        {
            IQueryable<TEntity> query = _dbSet;

            foreach (string property in includeProperties.Trim().Split(','))
            {
                if (property != string.Empty)
                {
                    query.Include(property);
                }
            }

            return query;
        }

        public TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public TEntity Insert(TEntity entity)
        {
            var insertedEntity = _dbSet.Add(entity);
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