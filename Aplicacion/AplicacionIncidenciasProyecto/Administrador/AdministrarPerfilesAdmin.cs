using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionIncidenciasProyecto.Administrador
{
    public partial class AdministrarPerfilesAdmin : Form
    {
        FormularioAdministrador form1 = new FormularioAdministrador();
        public AdministrarPerfilesAdmin()
        {
            InitializeComponent();
        }
        public AdministrarPerfilesAdmin(FormularioAdministrador form)
        {
            form1 = form;
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdministrarPerfilesAdmin_Load(object sender, EventArgs e)
        {

        }

        private void AdministrarPerfilesAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Perfil formPerfil = new Perfil(this);
            formPerfil.Owner = this;
            formPerfil.Show();
            this.Visible = false;
        }
    }
}
