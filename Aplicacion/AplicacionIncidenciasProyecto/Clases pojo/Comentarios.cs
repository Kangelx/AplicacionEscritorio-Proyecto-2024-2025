using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionIncidenciasProyecto.Clases_pojo
{
    internal class Comentarios
    {
        public int id { get; set; }
        public string texto { get; set; }
        public DateTime fechahora { get; set; }
        public Incidencias incidenciaNum { get; set; }
        public Personal personalId { get; set; }
        public string adjuntoUrl { get; set; }

        public Comentarios() { }

        public Comentarios(int id, string texto, DateTime fechaHora, Incidencias incidenciaNum, Personal personalId, string adjuntoUrl)
        {
            this.id = id;
            this.texto = texto;
            this.fechahora = fechaHora;
            this.incidenciaNum = incidenciaNum;
            this.personalId = personalId;
            this.adjuntoUrl = adjuntoUrl;
        }
    }
}
