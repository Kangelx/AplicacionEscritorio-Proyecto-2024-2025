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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtComent.Text = "";
            labelRutaArchivo.Text = "";
        }
    }
}
