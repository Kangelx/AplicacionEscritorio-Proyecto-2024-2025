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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CrearCuadrosAulas();

        }


        private void CrearCuadrosAulas()
        {
            List<string> nombresAulas = new List<string> { "Aula 101", "Aula 102", "Aula 103", "Aula 104", "Aula 104", "Aula 104", "Aula 104", "Aula 104", "Aula 104" };

            // Espaciado entre los cuadros de las aulas
            int spacing = 20;
            // Posición inicial de los cuadros de las aulas
            Point startPosition = new Point(201, 68);

            // Iterar sobre la lista de nombres de aulas
            foreach (string nombreAula in nombresAulas)
            {
                // Crear un nuevo PictureBox para representar el cuadro del aula
                PictureBox pictureBox = new PictureBox();
                // Definir el tamaño del PictureBox
                pictureBox.Size = new Size(150, 125);
                // Definir la posición del PictureBox
                pictureBox.Location = startPosition;
                // Asignar un color de fondo para representar el aula
                pictureBox.BackColor = Color.LightBlue;
                // Añadir el nombre del aula como texto al PictureBox
                pictureBox.Text = nombreAula;
                // Añadir un borde al PictureBox para mejorar la visualización
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
                // Añadir un evento clic para manejar la selección del aula (opcional)
                pictureBox.Click += (sender, e) =>
                {
                    MessageBox.Show($"Has seleccionado el aula: {((PictureBox)sender).Text}");
                };
                // Agregar el PictureBox al formulario
                Controls.Add(pictureBox);

                // Actualizar la posición de inicio para el próximo cuadro de aula
                startPosition.X += pictureBox.Width + spacing;

                // Si la siguiente posición supera el ancho del formulario, moverse a la siguiente fila
                if (startPosition.X + pictureBox.Width > ClientSize.Width)
                {
                    startPosition.X = 201;
                    startPosition.Y += pictureBox.Height + spacing;
                }
            }

        }
    }
}
