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
            // Configurando el control DateTimePicker para mostrar un calendario
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.ShowUpDown = false;
            dateTimePicker1.Value = DateTime.Today;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public IncidenciasProfesor(FormularioProfesor form)
        {
            form1 = form;
            InitializeComponent();
            // Configurando el control DateTimePicker para mostrar un calendario
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.ShowUpDown = false;
            dateTimePicker1.Value = DateTime.Today;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            VerIncidenciaProfesor formVer = new VerIncidenciaProfesor(this);
            formVer.Owner = this;
            formVer.Show();
            this.Hide();
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
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IncidenciasProfesor_Load(object sender, EventArgs e)
        {

        }
    }
}
