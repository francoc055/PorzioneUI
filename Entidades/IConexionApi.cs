using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IConexionApi<T> where T : class
    {
        List<T> GetAll(string url);

        bool Add(T entity, string url);

        bool Remove(string url);

        bool Update(T entity, string url);
    }
}
