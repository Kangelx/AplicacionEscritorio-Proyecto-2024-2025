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
        public IncidenciasProfesor()
        {
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
            VerIncidenciaProfesor formVer = new VerIncidenciaProfesor();
            formVer.Owner = this;
            formVer.Show();
            this.Hide();
        }

        private void btnIncidencias_Click(object sender, EventArgs e)
        {
            IncidenciasProfesor formIncidencias = new IncidenciasProfesor();
            formIncidencias.Show();
        }
    }
}
