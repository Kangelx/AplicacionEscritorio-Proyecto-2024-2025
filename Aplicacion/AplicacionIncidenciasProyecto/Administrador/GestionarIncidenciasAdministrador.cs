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
    public partial class GestionarIncidenciasAdministrador : Form
    {
        public GestionarIncidenciasAdministrador()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VerIncidenciaAdministrador form = new VerIncidenciaAdministrador(this);
            form.Owner = this;
            form.Show();
            this.Visible = false;
        }
    }
}
