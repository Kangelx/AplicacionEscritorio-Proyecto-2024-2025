using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionIncidenciasProyecto
{
    public partial class inicioSesionAdmin : Form
    {
        FormularioProfesor form1 = new FormularioProfesor();
        public inicioSesionAdmin()
        {
           
            InitializeComponent();
        }
        public inicioSesionAdmin(FormularioProfesor form)
        {
            form1 = form;
            InitializeComponent();
        }

        private void panel_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void inicioSesionAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            FormularioAdministrador form1 = new FormularioAdministrador();
            this.Visible = false;
            form1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void inicioSesionAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Visible = true;
        }
    }
}
