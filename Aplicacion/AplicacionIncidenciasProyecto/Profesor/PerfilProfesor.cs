using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionIncidenciasProyecto.Profesor
{
    public partial class PerfilProfesor : Form
    {
        FormularioProfesor form1 = new FormularioProfesor();
        public PerfilProfesor(FormularioProfesor form)
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

        private void PerfilProfesor_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Visible = true;
        }
    }
}
