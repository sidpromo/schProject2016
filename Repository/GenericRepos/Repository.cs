using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;

        /// <summary>
        /// Példányosításnál meg kell adni az Entity objektumot (EducationDatabaseEntities), ez lesz a context.
        /// </summary>
        /// <param name="context"></param>
        public Repository(DbContext context)
        {
            Context = context;
        }

        /// <summary>
        /// Új elem hozzáadása.
        /// </summary>
        /// <param name="entityToAdd"></param>
        public void Add(TEntity entityToAdd)
        {
            Context.Set<TEntity>().Add(entityToAdd);
            Context.Entry<TEntity>(entityToAdd).State = EntityState.Added;
            SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }

        /// <summary>
        /// Visszaad egy listát, amelyben csak a feltételnek eleget tévő elemek találhatóak meg.
        /// </summary>
        /// <param name="filterPredicate"></param>
        /// <returns></returns>
        public IEnumerable<TEntity> Find(System.Linq.Expressions.Expression<Func<TEntity, bool>> filterPredicate)
        {
            return Context.Set<TEntity>().Where(filterPredicate);
        }

        /// <summary>
        /// Visszaad egy listát, amelyben minden elem megtalálható.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        /// <summary>
        /// Visszaadja a megadott Id-jű elemet.
        /// </summary>
        /// <param name="EntityToGetById"></param>
        /// <returns></returns>
        public TEntity GetById(int EntityToGetById)
        {
            return Context.Set<TEntity>().Find(EntityToGetById);
        }

        /// <summary>
        /// Törli a megadott elemet.
        /// </summary>
        /// <param name="entityToRemove"></param>
        public void Remove(TEntity entityToRemove)
        {
            if (entityToRemove != null)
            {
                Context.Set<TEntity>().Remove(entityToRemove);
                //Context.Entry<TEntity>(entityToRemove).State = EntityState.Deleted;
                SaveChanges();
            }
            else throw new NullReferenceException();
        }

        /// <summary>
        /// Törli a megadott Id-jű elemet.
        /// </summary>
        /// <param name="entityToRemoveById"></param>
        public void RemoveById(int entityToRemoveById)
        {
            TEntity entToRemove = GetById(entityToRemoveById);
            if (entToRemove != null)
            {
                Remove(entToRemove);
                SaveChanges();
            }
            else throw new ArgumentException("NO DATA");
        }

        /// <summary>
        /// Menti a változtatásokat.
        /// </summary>
        public void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
}
