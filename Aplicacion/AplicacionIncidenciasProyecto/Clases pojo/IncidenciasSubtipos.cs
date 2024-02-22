using AplicacionIncidenciasProyecto.ControlVariables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionIncidenciasProyecto.Clases_pojo
{
    internal class IncidenciasSubtipos
    {
        public int id { get; set; }
        public TipoIncidencia tipo { get; set; }
        public string subtipo_nombre { get; set; }
        public string sub_subtipo { get; set; } 

        public IncidenciasSubtipos()
        {

        }

        public IncidenciasSubtipos(int id, TipoIncidencia tipo, string nombre, string subtipo)
        {
            this.id = id;
            this.tipo = tipo;
            this.subtipo_nombre = nombre;
            this.sub_subtipo = subtipo;
        }

        public void eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void guardar(IncidenciasSubtipos t)
        {
            throw new NotImplementedException();
        }

        public List<IncidenciasSubtipos> listar()
        {
            throw new NotImplementedException();
        }

        public IncidenciasSubtipos porId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
