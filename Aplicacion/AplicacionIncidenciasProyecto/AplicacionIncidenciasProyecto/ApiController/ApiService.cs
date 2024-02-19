using AplicacionIncidenciasProyecto.Clases_pojo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionIncidenciasProyecto.ApiController
{
    internal class ApiService<T>
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        private static readonly Dictionary<Type, string> BaseUrlMapping = new Dictionary<Type, string>
        {
            { typeof(Aulas), "http://localhost:4001/aula" },
            { typeof(Comentarios), "http://localhost:4001/comentario" },
            { typeof(Departamentos), "http://localhost:4001/departamento" },
            { typeof(Equipos), "http://localhost:4001/equipo" },
            { typeof(Incidencias), "http://localhost:4001/incidencia" },
            { typeof(IncidenciasSubtipos), "http://localhost:4001/incidenciasubtipo" },
            { typeof(Perfiles), "http://localhost:4001/perfil" },
            { typeof(Personal), "http://localhost:4001/personal" }
        };
        public ApiService()
        {
            _httpClient = new HttpClient();
            _baseUrl = DetermineBaseUrl();
        }

        private string DetermineBaseUrl()
        {

            Type typeOfT = typeof(T);


            if (BaseUrlMapping.TryGetValue(typeOfT, out string baseUrl))
            {
                return baseUrl;
            }
            else
            {

                throw new NotSupportedException($"Tipo no soportado: {typeOfT}");
            }
        }

        public async Task<T> GetById(int id)
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/{id}");
            response.EnsureSuccessStatusCode(); // Lanza una excepción si la solicitud no fue exitosa
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseUrl);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<T>>(content);
        }

        public async Task<T> Create(T item)
        {
            var json = JsonConvert.SerializeObject(item);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(_baseUrl, content);
            response.EnsureSuccessStatusCode();
            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(responseContent);
        }

        public async Task<T> Update(int id, T item)
        {
            var json = JsonConvert.SerializeObject(item);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"{_baseUrl}/{id}", content);
            response.EnsureSuccessStatusCode();
            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(responseContent);
        }

        public async Task<bool> Delete(int id)
        {
            var response = await _httpClient.DeleteAsync($"{_baseUrl}/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
