using System;
using System.Collections.Generic;
using System.Net.Http;
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
            using (var httpClient = new HttpClient())
            {
                try
                {
                    string apiUrl = "http://localhost:4000/aula";

                    // Realiza la solicitud GET
                    HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
                    
                }catch(Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }


            }
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
