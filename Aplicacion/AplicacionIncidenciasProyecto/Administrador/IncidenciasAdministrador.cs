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
    public partial class IncidenciasAdministrador : Form
    {
        FormularioAdministrador form1 = new FormularioAdministrador();
        public IncidenciasAdministrador()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public IncidenciasAdministrador(FormularioAdministrador form)
        {
            form1 = form;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IncidenciasAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Visible = true;
        }

        
    }
}
