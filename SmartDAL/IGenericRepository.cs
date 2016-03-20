using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SmartDAL
{
    public interface IGenericRepository<TEntity>
    where TEntity : class
    {
        void Delete(object id);
        void Delete(TEntity entityToDelete);
        Task<System.Collections.Generic.IEnumerable<TEntity>> Get();
        Task<TEntity> GetById(object id);
        void Insert(TEntity entity);
        void Update(TEntity entityToUpdate);
        void Save();
        void Dispose();
    }
}
