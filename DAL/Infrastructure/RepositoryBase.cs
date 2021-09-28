using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dev69Restaurant.DAL.Infrastructure
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        private RestaurantDbContext _dbContext;
        private readonly IDbSet<T> _dbSet;

        protected IDbFactory DbFactory
        {
            get;
            private set;
        }

        protected RestaurantDbContext DbContext
        {
            get
            {
                return _dbContext ?? (_dbContext = DbFactory.Init());
            }
        }

        protected RepositoryBase(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
            _dbSet = DbContext.Set<T>();
        }

        public virtual T Add(T entity)
        {
            return _dbSet.Add(entity);
        }

        public virtual T Delete(T entity)
        {
            return _dbSet.Remove(entity);
        }

        public virtual T Delete(int id)
        {
            var entity = _dbSet.Find(id);
            return _dbSet.Remove(entity);
        }

        public IEnumerable<T> GetAll(string[] includes = null)
        {
            if (includes != null && includes.Count() > 0)
            {
                var query = _dbContext.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                return query.AsQueryable();
            }

            return _dbContext.Set<T>().AsQueryable();
        }

        public IEnumerable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null)
        {
            if (includes != null && includes.Count() > 0)
            {
                var query = _dbContext.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                return query.Where<T>(predicate).AsQueryable<T>();
            }

            return _dbContext.Set<T>().Where<T>(predicate).AsQueryable<T>();
        }

        public T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null)
        {
            if (includes != null && includes.Count() > 0)
            {
                var query = _dbContext.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                return query.FirstOrDefault(expression);
            }
            return _dbContext.Set<T>().FirstOrDefault(expression);
        }

        public virtual T GetSingleById(int id)
        {
            return _dbSet.Find(id);
        }

        public virtual void Update(T entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
