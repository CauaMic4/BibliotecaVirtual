
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace INegocio.Base
{
    public interface IBaseNegocio<TViewModel, T>
    {
        IList<TViewModel> GetAllNoTracking();
        IList<TViewModel> GetAll(params string[] entities);
        IList<TViewModel> Get(Expression<Func<T, bool>> predicate, params string[] entities);
        IList<TViewModel> GetNoTracking(Expression<Func<T, bool>> predicate, params string[] entities);
        TViewModel GetById(int key, params string[] entities);
        TViewModel First(Expression<Func<T, bool>> predicate, params string[] entities);
        TViewModel FirstNoTracking(Expression<Func<T, bool>> predicate, params string[] entities);
        void Insert(TViewModel entity);
        void Update(TViewModel entity, bool commit = true);
        void Delete(int key);
        void DeleteRange(IList<TViewModel> entities);
        void Commit();
        void Dispose();
    }
}
