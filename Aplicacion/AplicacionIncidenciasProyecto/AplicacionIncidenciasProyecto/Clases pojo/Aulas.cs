using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionIncidenciasProyecto.Clases_pojo
{
    internal class Aulas : Repositorio<Aulas>
    {
        public int num { get; set;}
        public string codigo { get; set;}
        public string descripcion { get; set;}
        public int planta { get; set;}

        public Aulas() { }

        public Aulas(int num, string codigo, string descripcion, int planta)
        {
            this.num = num;
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.planta = planta;
        }

        public List<Aulas> listar()
        {
            throw new NotImplementedException();
        }

        public Aulas porId(int id)
        {
            throw new NotImplementedException();
        }

        public void guardar(Aulas t)
        {
            throw new NotImplementedException();
        }

        public void eliminar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
