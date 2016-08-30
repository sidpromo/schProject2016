using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.GenericRepos
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity GetById(int EntityToGetById);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> filterPredicate);

        void Add(TEntity entityToAdd);
        void Remove(TEntity entityToRemove);
        void RemoveById(int entityToRemoveById);
    }
}
