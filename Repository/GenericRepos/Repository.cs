using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.GenericRepos
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;

        public Repository(DbContext context)
        {
            Context = context;
        }

        public void Add(TEntity entityToAdd)
        {
            Context.Set<TEntity>().Add(entityToAdd);
            Context.Entry<TEntity>(entityToAdd).State = EntityState.Added;
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }

        public IEnumerable<TEntity> Find(System.Linq.Expressions.Expression<Func<TEntity, bool>> filterPredicate)
        {
            return Context.Set<TEntity>().Where(filterPredicate);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int EntityToGetById)
        {
            return Context.Set<TEntity>().Find(EntityToGetById);
        }

        public void Remove(TEntity entityToRemove)
        {
            Context.Set<TEntity>().Remove(entityToRemove);
        }

        public void RemoveById(int entityToRemoveById)
        {
            TEntity entToRemove = GetById(entityToRemoveById);
            if (entToRemove == null) throw new ArgumentException("NO DATA");
            Remove(entToRemove);
        }
    }
}
