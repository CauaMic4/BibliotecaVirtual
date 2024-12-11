using INegocio.Base;
using Microsoft.EntityFrameworkCore;
using Repositorio.Contexto;
using System.Linq.Expressions;

namespace Negocio.Base
{
    public class BaseNegocio<TViewModel, T>: IBaseNegocio<TViewModel, T>, IDisposable where T : class
    {
        protected DatabaseContext _ctx = new();
        public BaseRepositorio(DatabaseContext ctx)
        {
            _ctx = ctx;
        }

        protected BaseRepositorio()
        {
            DbContextOptionsBuilder options = new DbContextOptionsBuilder();
            var connection = Connection();
            options.UseSqlServer(connection);
            _ctx = new DatabaseContext(options.Options);
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IList<TViewModel> entities)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public TViewModel First(Expression<Func<T, bool>> predicate, params string[] entities)
        {
            throw new NotImplementedException();
        }

        public TViewModel FirstNoTracking(Expression<Func<T, bool>> predicate, params string[] entities)
        {
            throw new NotImplementedException();
        }

        public IList<TViewModel> Get(Expression<Func<T, bool>> predicate, params string[] entities)
        {
            throw new NotImplementedException();
        }

        public IList<TViewModel> GetAll(params string[] entities)
        {
            throw new NotImplementedException();
        }

        public IList<TViewModel> GetAllNoTracking()
        {
            throw new NotImplementedException();
        }

        public TViewModel GetById(int key, params string[] entities)
        {
            throw new NotImplementedException();
        }

        public IList<TViewModel> GetNoTracking(Expression<Func<T, bool>> predicate, params string[] entities)
        {
            throw new NotImplementedException();
        }

        public void Insert(TViewModel entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TViewModel entity, bool commit = true)
        {
            throw new NotImplementedException();
        }
    }
}
