using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionIncidenciasProyecto
{
    internal interface IApiService<T>
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task<string> Create(T item);
        Task<string> Update(T item);
        Task<string> Delete(int id);

    }
}
