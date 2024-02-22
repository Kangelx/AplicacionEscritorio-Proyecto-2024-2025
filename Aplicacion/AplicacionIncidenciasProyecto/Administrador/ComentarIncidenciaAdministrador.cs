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
    public partial class ComentarIncidenciaAdministrador : Form
    {
        private string rutaArchivo;
        public ComentarIncidenciaAdministrador()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
