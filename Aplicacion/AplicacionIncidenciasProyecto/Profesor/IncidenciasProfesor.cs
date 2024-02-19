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
    public partial class IncidenciasProfesor : Form
    {
        FormularioProfesor form1 = new FormularioProfesor();
        public IncidenciasProfesor()
        {
            InitializeComponent();
        }
        public IncidenciasProfesor(FormularioProfesor form)
        {
            form1 = form;
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void IncidenciasProfesor_Load(object sender, EventArgs e)
        {

        }

        private void btnGestionar_Click(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            VerIncidenciaProfesor formVer = new VerIncidenciaProfesor(this);
            formVer.Owner = this;
            formVer.Show();
            this.Hide();
        }

        private void btnIncidencias_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.Visible = true;
            this.Close();
        }

        private void IncidenciasProfesor_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
