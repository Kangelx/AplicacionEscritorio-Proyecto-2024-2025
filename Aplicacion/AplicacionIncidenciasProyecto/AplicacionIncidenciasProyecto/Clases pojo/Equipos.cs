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
        public TipoEquipo tipoEquipo { get; set; }
        public DateTime fechaAdquisicion { get; set; }
        public string etiqueta { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string descricpcion { get; set; }
        public bool baja { get; set; }
        public int aulaNum { get; set; }
        public int puesto { get; set; }

        public Equipos() { }

        public Equipos(int id, TipoEquipo tipoEquipo, DateTime fechaAdquisicion, string etiqueta, string marca, string modelo, string descricpcion, bool baja, int aulaNum, int puesto)
        {
            this.id = id;
            this.tipoEquipo = tipoEquipo;
            this.fechaAdquisicion = fechaAdquisicion;
            this.etiqueta = etiqueta;
            this.marca = marca;
            this.modelo = modelo;
            this.descricpcion = descricpcion;
            this.baja = baja;
            this.aulaNum = aulaNum;
            this.puesto = puesto;
        }

    }
}
