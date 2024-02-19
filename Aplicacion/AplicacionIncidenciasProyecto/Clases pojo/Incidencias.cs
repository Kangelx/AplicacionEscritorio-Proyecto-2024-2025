using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionIncidenciasProyecto.Clases_pojo 
{
    internal class Incidencias : Repositorio<Incidencias>
    {
        public int Id { get; set; }
        public string dni { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string direccion { get; set; }
        public string localidad { get; set; }
        public string cp { get; set; }
        public Boolean activo { get; set; }
        public int departamento_id { get; set; }

        public Incidencias() { }

        public Incidencias(int id, string dni, string nombre, string apellido1, string apellido2, string direccion, string localidad, string cp, bool activo, int departamento_id)
        {
            Id = id;
            this.dni = dni;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.direccion = direccion;
            this.localidad = localidad;
            this.cp = cp;
            this.activo = activo;
            this.departamento_id = departamento_id;
        }

        public List<Incidencias> listar()
        {
            throw new NotImplementedException();
        }

        public Incidencias porId(int id)
        {
            throw new NotImplementedException();
        }

        public void guardar(Incidencias t)
        {
            throw new NotImplementedException();
        }

        public void eliminar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
