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
    internal class ApiService<T> :IApiService<T>
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        private static readonly Dictionary<Type, string> BaseUrlMappings = new Dictionary<Type, string>
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


            if (BaseUrlMappings.TryGetValue(typeOfT, out string baseUrl))
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
            try { 
                var response = await _httpClient.GetAsync($"{_baseUrl}/{id}");
                response.EnsureSuccessStatusCode(); // Lanza una excepción si la solicitud no fue exitosa
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(content);
            }
            catch (JsonSerializationException ex)
            {
                // Manejar la excepción
                Console.WriteLine("Error de deserialización JSON:");
                Console.WriteLine(ex.Message);
                Console.WriteLine("StackTrace:");
                Console.WriteLine(ex.StackTrace);
                throw; // Relanza la excepción para que pueda ser manejada más arriba si es necesario
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones que puedan ocurrir
                Console.WriteLine("Error general:");
                Console.WriteLine(ex.Message);
                Console.WriteLine("StackTrace:");
                Console.WriteLine(ex.StackTrace);
                throw; // Relanza la excepción para que pueda ser manejada más arriba si es necesario
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            try
            {
                var response = await _httpClient.GetAsync(_baseUrl);
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<T>>(content);
            }
            catch (JsonSerializationException ex)
            {
                // Manejar la excepción
                Console.WriteLine("Error de deserialización JSON:");
                Console.WriteLine(ex.Message);
                Console.WriteLine("StackTrace:");
                Console.WriteLine(ex.StackTrace);
                throw; // Relanza la excepción para que pueda ser manejada más arriba si es necesario
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones que puedan ocurrir
                Console.WriteLine("Error general:");
                Console.WriteLine(ex.Message);
                Console.WriteLine("StackTrace:");
                Console.WriteLine(ex.StackTrace);
                throw; // Relanza la excepción para que pueda ser manejada más arriba si es necesario
            }
        }

        public async Task<string> Create(T item)
        {
            try { 
            var json = JsonConvert.SerializeObject(item);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(_baseUrl, content);
            response.EnsureSuccessStatusCode();
            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<string>(responseContent);
            }
            catch (JsonSerializationException ex)
            {
                // Manejar la excepción
                Console.WriteLine("Error de deserialización JSON:");
                Console.WriteLine(ex.Message);
                Console.WriteLine("StackTrace:");
                Console.WriteLine(ex.StackTrace);
                throw; // Relanza la excepción para que pueda ser manejada más arriba si es necesario
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones que puedan ocurrir
                Console.WriteLine("Error general:");
                Console.WriteLine(ex.Message);
                Console.WriteLine("StackTrace:");
                Console.WriteLine(ex.StackTrace);
                throw; // Relanza la excepción para que pueda ser manejada más arriba si es necesario
            }
        }

        public async Task<string> Update(T item)
        {
            try
            {

            
            var json = JsonConvert.SerializeObject(item);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"{_baseUrl}", content);
            response.EnsureSuccessStatusCode();
            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<string>(responseContent);
            }
            catch (JsonSerializationException ex)
            {
                // Manejar la excepción
                Console.WriteLine("Error de deserialización JSON:");
                Console.WriteLine(ex.Message);
                Console.WriteLine("StackTrace:");
                Console.WriteLine(ex.StackTrace);
                throw; // Relanza la excepción para que pueda ser manejada más arriba si es necesario
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones que puedan ocurrir
                Console.WriteLine("Error general:");
                Console.WriteLine(ex.Message);
                Console.WriteLine("StackTrace:");
                Console.WriteLine(ex.StackTrace);
                throw; // Relanza la excepción para que pueda ser manejada más arriba si es necesario
            }
        }

        public async Task<string> Delete(int id)
        {
            try 
            { 
                var response = await _httpClient.DeleteAsync($"{_baseUrl}/{id}");
                var responseContent = await response.Content.ReadAsStringAsync();
                return responseContent;
            }
            catch (JsonSerializationException ex)
            {
                // Manejar la excepción
                Console.WriteLine("Error de deserialización JSON:");
                Console.WriteLine(ex.Message);
                Console.WriteLine("StackTrace:");
                Console.WriteLine(ex.StackTrace);
                throw; // Relanza la excepción para que pueda ser manejada más arriba si es necesario
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones que puedan ocurrir
                Console.WriteLine("Error general:");
                Console.WriteLine(ex.Message);
                Console.WriteLine("StackTrace:");
                Console.WriteLine(ex.StackTrace);
                throw; // Relanza la excepción para que pueda ser manejada más arriba si es necesario
            }
        }
    }
}
