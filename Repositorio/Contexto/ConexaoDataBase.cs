using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Contexto
{
    public static class ConexaoDataBase
    {
        private static HttpContextAccessor _httpContextAccessor = new();
        private static string Connection()
        {
            return @"Server=CAUAMICAEL\SQLEXPRESSCAUA;Database=BibliotecaVirtual;Trusted_Connection=True;";
        }
    }
}
