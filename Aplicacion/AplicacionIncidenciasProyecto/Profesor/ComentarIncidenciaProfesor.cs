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
    public partial class ComentarIncidenciaProfesor : Form
    {
        private string rutaArchivo;
        public ComentarIncidenciaProfesor()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Configuraciones del OpenFileDialog
            openFileDialog.InitialDirectory = "C:\\"; // Directorio inicial
            openFileDialog.Filter = "Todos los archivos|*.*"; // Filtros para tipos de archivos permitidos

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = openFileDialog.FileName;
                labelRutaArchivo.Text = rutaArchivo; // Actualiza el texto del Label con la ruta seleccionada
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtComent.Text = "";
            labelRutaArchivo.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void ComentarIncidenciaProfesor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
