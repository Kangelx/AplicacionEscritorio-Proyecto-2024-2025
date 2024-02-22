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
    public partial class VerIncidenciaProfesor : Form
    {
        IncidenciasProfesor form1 = new IncidenciasProfesor();
        public VerIncidenciaProfesor(IncidenciasProfesor form)
        {
            form1 = form;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ComentarIncidenciaProfesor formComent = new ComentarIncidenciaProfesor();
            formComent.Show();
        }

        private void btnIncidencias_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VerIncidenciaProfesor_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VerIncidenciaProfesor_Load(object sender, EventArgs e)
        {

        }
    }
}
