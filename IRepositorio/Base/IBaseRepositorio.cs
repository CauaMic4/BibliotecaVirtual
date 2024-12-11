using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IRepositorio.Base
{
    public interface IBaseRepositorio<T> where T : class
    {
        IQueryable<T> GetAll(params string[] entities);
        IQueryable<T> GetAllNoTracking();
        IQueryable<T> Get(Expression<Func<T, bool>> predicate, params string[] entities);
        T GetById(int key, params string[] entities);
        T GetById(long key, params string[] entities);
        T First(Expression<Func<T, bool>> predicate, params string[] entities);
        T FirstNoTraking(Expression<Func<T, bool>> predicate, params string[] entities);
        void Insert(T entity);
        void Update(T entity, bool detach = true);
        Task UpdateAsync(T entity, bool detach = true);
        void Delete(int key);
        void DeleteRange(IList<T> entities);
        void Commit();
        void Dispose();
    }
}
