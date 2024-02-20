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
    public partial class FormularioProfesor : Form
    {
        private string rutaArchivo;
        public FormularioProfesor()
        {
            InitializeComponent();
           // this.Load += Form1_Load;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            inicioSesionAdmin formLogIn = new inicioSesionAdmin();
            formLogIn.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Configuraciones del OpenFileDialog
            openFileDialog.InitialDirectory = "C:\\"; // Directorio inicial
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif"; // Filtros para tipos de archivos permitidos

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = openFileDialog.FileName;
                labelRutaArchivo.Text = rutaArchivo; // Actualiza el texto del Label con la ruta seleccionada
            }
        }

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            GestionarIncidenciasProfesor formGest = new GestionarIncidenciasProfesor(this);
            formGest.Owner = this;
            formGest.Show();
            this.Visible = false;
        }

        private void grpIncidencia_Enter(object sender, EventArgs e)
        {

        }

        private void btnIncidencias_Click(object sender, EventArgs e)
        {
            IncidenciasProfesor formIncidenias = new IncidenciasProfesor();
            formIncidenias.Show();
        }

        private void btnNotificaciones_Click(object sender, EventArgs e)
        {

        }

        private void FormularioProfesor_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }
    }
}
