using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionIncidenciasProyecto.Clases_pojo
{
    internal class Personal
    {
        public int id { get; set; }
        public string dni { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string direccion { get; set; }
        public string localidad { get; set; }
        public string cp { get; set; }
        public string tlf { get; set; }
        public bool? activo { get; set; }
        public Departamentos departamentoId { get; set; }

        public Personal() { }

        public Personal(int id, string dni, string nombre, string apellido1, string apellido2, string direccion, string localidad, string cp, string tlf, bool? activo, Departamentos departamentoId)
        {
            this.id = id;
            this.dni = dni;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.direccion = direccion;
            this.localidad = localidad;
            this.cp = cp;
            this.tlf = tlf;
            this.activo = activo;
            this.departamentoId = departamentoId;
        }

        public List<Personal> listar()
        {
            throw new NotImplementedException();
        }

        public Personal porId(int id)
        {
            throw new NotImplementedException();
        }

        public void guardar(Personal t)
        {
            throw new NotImplementedException();
        }

        public void eliminar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
