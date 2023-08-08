using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IConexionApi<T> where T : class
    {
        List<T> GetAll(string url, string jwt);

        bool Add(T entity, string url, string jwt);

        bool Remove(string url, string jwt);

        bool Update(T entity, string url, string jwt);
    }
}
