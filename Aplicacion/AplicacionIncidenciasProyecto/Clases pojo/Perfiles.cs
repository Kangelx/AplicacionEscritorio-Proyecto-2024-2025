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

    }
}
