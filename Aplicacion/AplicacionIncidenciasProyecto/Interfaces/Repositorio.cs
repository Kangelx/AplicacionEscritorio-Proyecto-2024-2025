using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionIncidenciasProyecto
{
    internal interface Repositorio<T>
    {
        List<T> listar();

        T porId(int id);
        void guardar(T t);
        void eliminar(int id);

    }
}
