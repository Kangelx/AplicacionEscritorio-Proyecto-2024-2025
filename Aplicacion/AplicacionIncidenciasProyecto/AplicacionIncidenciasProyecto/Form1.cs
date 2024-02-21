using AplicacionIncidenciasProyecto.ApiController;
using AplicacionIncidenciasProyecto.Clases_pojo;
using AplicacionIncidenciasProyecto.ControlVariables;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionIncidenciasProyecto
{
    public partial class Form1 : Form
    {
        public bool permiso = false;
        public static string token = string.Empty;
        public Form1()
        {
            InitializeComponent();
            //apiLogin();
            pruebaAsync();
            obtenerUsuario();
        }

        private async void apiLogin()
        {
            using (var httpClient = new HttpClient())
            {
                var credentials = new { username = "m", password = "m" };


                var json = JsonConvert.SerializeObject(credentials);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync("http://localhost:4001/login", content);


                if (response.IsSuccessStatusCode)
                {

                    token = await response.Content.ReadAsStringAsync();


                    Console.WriteLine("Token recibido: " + token);
                }
                else
                {
                    Console.WriteLine("Error al autenticar: " + response.StatusCode);
                }
            }
        }
        private async void obtenerUsuario()
        {
            string username = Environment.UserName;
            txtUsuario.Text = username;
            var apiService = new ApiService<Perfiles>();
            IEnumerable<Perfiles> perfiles = await apiService.GetAll();
            foreach ( Perfiles perfil in perfiles)
            {
                if (perfil.dominio == username) permiso = true;
            }
            permisos.Text = permiso.ToString();

        }
        

        public async Task pruebaAsync()
        {
            //Perfiles perfiles = new Perfiles();
            //perfiles.personalId = 12;
            //perfiles.dominio = "angel";
            //perfiles.educantabria = "angel.garciagarcia@educantabria.es";
            //perfiles.password = "angel";
            //perfiles.perfil = Perfil.Administrador;
            //
            //var apiService = new ApiService<Perfiles>();
            //var respuesta = await apiService.Create(perfiles);
            //Debug.WriteLine(respuesta);

            var apiService = new ApiService<Aulas>();
            
            
            IEnumerable<Aulas> aulaCreada = await apiService.GetAll();
            foreach (Aulas aulas in aulaCreada)
            {
                Debug.WriteLine(aulas.codigo);
                Debug.WriteLine(aulas.planta);
                Debug.WriteLine(aulas.num);
                Debug.WriteLine(aulas.descripcion);
            
            }

            //var apiService = new ApiService<Incidencias>();
            //
            //
            //IEnumerable<Incidencias> aulaCreada = await apiService.GetAll();
            //foreach(Incidencias aulas in aulaCreada)
            //{
            //    Debug.WriteLine(aulas.num);
            //    Debug.WriteLine(aulas.tipo);
            //    Debug.WriteLine(aulas.subtipoId.id);
            //    Debug.WriteLine(aulas.subtipoId.tipo);
            //    Debug.WriteLine(aulas.subtipoId.subtipo_nombre);
            //    Debug.WriteLine(aulas.subtipoId.sub_subtipo);
            //    Debug.WriteLine(aulas.fechaCreacion);
            //    Debug.WriteLine(aulas.fechaCierre);
            //    Debug.WriteLine(aulas.descripcion);
            //    Debug.WriteLine(aulas.estado);
            //    Debug.WriteLine(aulas.adjuntoUrl);
            //    Debug.WriteLine(aulas.creadorId.nombre);
            //    if (aulas.responsableId != null) Debug.WriteLine(aulas.responsableId.nombre);
            //    else Debug.WriteLine("es null");
            //    
            //    Debug.WriteLine(aulas.tiempo);
            //    //Debug.WriteLine(aulas.equipoId.id);
            //
            //
            //}

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
