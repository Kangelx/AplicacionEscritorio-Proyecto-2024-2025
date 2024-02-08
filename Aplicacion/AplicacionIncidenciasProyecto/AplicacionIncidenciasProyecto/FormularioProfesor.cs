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

        public FormularioProfesor()
        {
            InitializeComponent();

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
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Filtro para mostrar solo archivos de imagen
            openFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string rutaArchivo = openFileDialog1.FileName;

                try
                {
                    // Cargar la imagen en el PictureBox
                    Image imagenSeleccionada = Image.FromFile(rutaArchivo);
                    pictureBox1.Image = imagenSeleccionada;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }
        }
    }
}
