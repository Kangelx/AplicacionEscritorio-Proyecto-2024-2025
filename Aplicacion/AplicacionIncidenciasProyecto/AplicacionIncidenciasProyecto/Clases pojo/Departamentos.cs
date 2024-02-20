using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionIncidenciasProyecto.Clases_pojo
{
    internal class Departamentos
    {
        public int id { get; set; }
        public string cod { get; set; }
        public string nombre { get; set; }
        public bool activo { get; set; }
        public int? jefeDepartamentoId { get; set; }

        public Departamentos() { }

        public Departamentos(int id, string cod, string nombre, bool activo, int? jefeDepId)
        {
            this.id = id;
            this.cod = cod;
            this.nombre = nombre;
            this.activo = activo;
            this.jefeDepartamentoId = jefeDepId;
        }

    }
}
