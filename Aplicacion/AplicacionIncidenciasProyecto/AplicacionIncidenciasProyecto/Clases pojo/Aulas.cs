using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace AplicacionIncidenciasProyecto.Clases_pojo
{
    internal class Aulas
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

        public async Task<JArray> listar()
        {
            JArray jsonArray = new JArray();
            using (var httpClient = new HttpClient())
            {
                try
                {
                    string apiUrl = "http://localhost:4000/aula";

                    var response = await httpClient.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        jsonArray = JArray.Parse(jsonString);

                    }
                    else
                    {
                        Console.WriteLine($"Error en la solicitud: {response.StatusCode}"); 
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }


            }
            return jsonArray;
 

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
