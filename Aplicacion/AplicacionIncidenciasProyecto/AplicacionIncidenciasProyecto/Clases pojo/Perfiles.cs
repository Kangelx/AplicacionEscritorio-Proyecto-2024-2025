using AplicacionIncidenciasProyecto.ControlVariables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionIncidenciasProyecto.Clases_pojo
{
    internal class Perfiles
    {
        public int personalId { get; set; }
        public string dominio { get; set; }
        public string educantabria { get; set; }
        public string password { get; set; }
        public Perfil perfil { get; set; }

        public Perfiles() { }

        public Perfiles(int personalId, string dominio, string educantabria, string password, Perfil perfil)
        {
            this.personalId = personalId;
            this.dominio = dominio;
            this.educantabria = educantabria;
            this.password = password;
            this.perfil = perfil;
        }

        public List<Perfiles> listar()
        {
            throw new NotImplementedException();
        }

        public Perfiles porId(int id)
        {
            throw new NotImplementedException();
        }

        public void guardar(Perfiles t)
        {
            throw new NotImplementedException();
        }

        public void eliminar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
