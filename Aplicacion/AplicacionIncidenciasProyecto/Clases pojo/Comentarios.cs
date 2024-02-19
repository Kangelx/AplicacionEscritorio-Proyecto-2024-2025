using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionIncidenciasProyecto.Clases_pojo
{
    internal class Comentarios : Repositorio<Comentarios>
    {
        public int id { get; set; }
        public string texto { get; set; }
        public DateTime fechaHora { get; set; }
        public int incidenciaNum { get; set; }
        public int personalId { get; set; }
        public string adjuntoUrl { get; set; }

        public Comentarios() { }

        public Comentarios(int id, string texto, DateTime fechaHora, int incidenciaNum, int personalId, string adjuntoUrl)
        {
            this.id = id;
            this.texto = texto;
            this.fechaHora = fechaHora;
            this.incidenciaNum = incidenciaNum;
            this.personalId = personalId;
            this.adjuntoUrl = adjuntoUrl;
        }

        public List<Comentarios> listar()
        {
            throw new NotImplementedException();
        }

        public Comentarios porId(int id)
        {
            throw new NotImplementedException();
        }

        public void guardar(Comentarios t)
        {
            throw new NotImplementedException();
        }

        public void eliminar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
