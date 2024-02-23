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
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        
        public FormularioAdministrador(FormularioProfesor form)
        {
            form1 = form;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }


        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

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

        private void FormularioAdministrador_Load(object sender, EventArgs e)
        {

        }
    }
}



