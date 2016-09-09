using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity GetById(int entityToGetById);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> filterPredicate);

        void Add(TEntity entityToAdd);
        void Remove(TEntity entityToRemove);
        void RemoveById(int entityToRemoveById);
        void SaveChanges();
        void Update(TEntity entityToUpdate);
    }
}
