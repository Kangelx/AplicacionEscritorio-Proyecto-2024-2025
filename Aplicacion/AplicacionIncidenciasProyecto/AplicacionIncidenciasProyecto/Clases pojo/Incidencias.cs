using AplicacionIncidenciasProyecto.ControlVariables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionIncidenciasProyecto.Clases_pojo 
{
    internal class Incidencias
    {
public int num {  get; set; }
        public TipoIncidencia tipo { get; set; }
        public int subtipoId { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaCierre { get; set; }
        public string descripcion {  get; set; }
        public EstadoIncidencia estado { get; set; }
        public string adjuntoUrl { get; set; }
        public int creadorId { get; set; }
        public int responsableId { get; set; }
        public int equipoId { get; set; }
        public Prioridad prioridad { get; set; }
        public Incidencias() { }
        public Incidencias(int num, TipoIncidencia tipo, int subtipoId, DateTime fechaCreacion, DateTime fechaCierre, string descripcion, EstadoIncidencia estado, string adjuntoUrl, int creadorId, int responsableId, int equipoId, Prioridad prioridad)
        {
            this.num = num;
            this.tipo = tipo;
            this.subtipoId = subtipoId;
            this.fechaCreacion = fechaCreacion;
            this.fechaCierre = fechaCierre;
            this.descripcion = descripcion;
            this.estado = estado;
            this.adjuntoUrl = adjuntoUrl;
            this.creadorId = creadorId;
            this.responsableId = responsableId;
            this.equipoId = equipoId;
            this.prioridad = prioridad;
        }

        
        
    }
}
