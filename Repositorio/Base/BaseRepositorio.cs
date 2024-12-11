using IRepositorio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Base
{
    public class BaseRepositorio<T> : IBaseRepositorio<T>, IDisposable where T : class
    {
    }
}
