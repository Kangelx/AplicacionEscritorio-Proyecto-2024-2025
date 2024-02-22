using AplicacionIncidenciasProyecto.ControlVariables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionIncidenciasProyecto.Clases_pojo
{
    internal class Equipos
    {
        public int id { get; set; }
        public string tipoEquipo { get; set; }
        public DateTime? fechaAdquisicion { get; set; }
        public string etiqueta { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string descripcion { get; set; }
        public bool? baja { get; set; }
        public Aulas aula_num { get; set; }
        public int? puesto { get; set; }

        public Equipos() { }

        public Equipos(int id, string tipoEquipo, DateTime fechaAdquisicion, string etiqueta, string marca, string modelo, string descripcion, bool? baja, Aulas aula_num, int? puesto)
        {
            this.id = id;
            this.tipoEquipo = tipoEquipo;
            this.fechaAdquisicion = fechaAdquisicion;
            this.etiqueta = etiqueta;
            this.marca = marca;
            this.modelo = modelo;
            this.descripcion = descripcion;
            this.baja = baja;
            this.aula_num = aula_num;
            this.puesto = puesto;
        }

    }
}
