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
    public partial class VerIncidenciaAdministrador : Form
    {
        GestionarIncidenciasAdministrador formPadre;
        public VerIncidenciaAdministrador(GestionarIncidenciasAdministrador form)
        {
            formPadre = form;
            InitializeComponent();
        }

        private void VerIncidenciaAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void VerIncidenciaAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPadre.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
