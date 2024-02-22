using AplicacionIncidenciasProyecto.Clases_pojo;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacionIncidenciasProyecto.Administrador;

namespace AplicacionIncidenciasProyecto
{
    public partial class FormularioAdministrador : Form
    {
        FormularioProfesor form1=new FormularioProfesor();

        public FormularioAdministrador()
        {

            InitializeComponent();

        }
        
        public FormularioAdministrador(FormularioProfesor form)
        {
            form1 = form;
            InitializeComponent();

        }


        private void FormularioAdministrador_Load(object sender, EventArgs e)
        {
            //await ActualizarGraficoCircular();
        }
        /*private async Task ActualizarGraficoCircular()
        {
            // Llamada a la API para obtener datos de incidencias
            // List<Clases_pojo.Incidencias> incidencias = await ObtenerDatosDesdeAPI();

            // Contadores para cada estado de incidencia
            Dictionary<string, int> contadorEstados = new Dictionary<string, int>();

            // Inicializar contadores
            foreach (var estado in new string[] { "abierta", "asignada", "en proceso", "enviada a Infortec", "resuelta", "cerrada" })
            {
                contadorEstados.Add(estado, 0);
            }

            // Contar la cantidad de incidencias por estado
             foreach (var incidencia in incidencias)
             {
                 if (contadorEstados.ContainsKey(incidencia.Estado))
                 {
                     contadorEstados[incidencia.Estado]++;
                 }
             }

             // Configurar el gráfico circular
             chartDatos.Series.Clear();
             chartDatos.Series.Add("Incidencias");
             chartDatos.Series["Incidencias"].ChartType = SeriesChartType.Pie;

             // Agregar los datos al gráfico
             foreach (var estado in contadorEstados.Keys)
             {
                 chartDatos.Series["Incidencias"].Points.AddXY(estado, contadorEstados[estado]);
             }
         }
             private async Task<List<Incidencias>> ObtenerDatosDesdeAPI()
             {
                 List<Incidencias> incidencias = new List<Incidencias>();

                 // Aquí deberías realizar una llamada HTTP a tu API para obtener los datos de incidencias
                 // Este es un ejemplo de cómo podrías hacerlo usando HttpClient
                 using (HttpClient client = new HttpClient())
                 {
                     HttpResponseMessage response = await client.GetAsync("URL de tu API");
                     if (response.IsSuccessStatusCode)
                     {
                         incidencias = await response.Content.ReadAsAsync<List<Incidencias>>();
                     }
                 }

                 return incidencias;
             }



        }*/

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void FormularioAdministrador_Load_1(object sender, EventArgs e)
        {

        }

        private void FormularioAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            GestionarIncidenciasAdministrador formGestAdmin = new GestionarIncidenciasAdministrador();
            formGestAdmin.Owner=this;
            formGestAdmin.Show();
            this.Visible = false;
        }

        private void btnIncidencias_Click(object sender, EventArgs e)
        {
            IncidenciasAdministrador formInciAdmin = new IncidenciasAdministrador(this);
            formInciAdmin.Owner = this;
            formInciAdmin.Show();
            this.Visible = false;
        }

        private void btnNotificaciones_Click(object sender, EventArgs e)
        {
            NotificacionesAdministrador formNotAdmin = new NotificacionesAdministrador(this);
            formNotAdmin.Owner = this;
            formNotAdmin.Show();
            this.Visible = false;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdministrarPerfilesAdmin formPerfilesAdmin = new AdministrarPerfilesAdmin(this);
            formPerfilesAdmin.Owner = this;
            formPerfilesAdmin.Show();
            this.Visible = false;
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            InventarioAdmin formInvent = new InventarioAdmin(this);
            formInvent.Owner = this;
            formInvent.Show();
            this.Visible = false;
        }
    }
}



