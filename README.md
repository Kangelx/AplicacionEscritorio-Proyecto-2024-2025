# AplicacionEscritorio-Proyecto-2024-2025

PROPUESTA DE BASE DE DATOS:
Tabla Departamentos: cambiar el int por id
Tabla Incidencias: añadir una columna de prioridad, tipo enum (hablar cuantas prioridades se quieren poner)


COMO HACER LOS CUADRADOS DINAMICOS QUE REPRESENTARAN LAS AULAS:
chatgpt:

Para lograr esto en C#, puedes utilizar Windows Forms para crear la ventana y representar dinámicamente los cuadros que representan las aulas. Aquí te muestro un ejemplo básico de cómo podrías hacerlo:

csharp
Copy code
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EjemploAulas
{
    public partial class FormPrincipal : Form
    {
        // Lista de nombres de aulas (puedes reemplazar esto con tu propia lógica para obtener los nombres de las aulas)
        List<string> nombresAulas = new List<string> { "Aula 101", "Aula 102", "Aula 103", "Aula 104" };

        public FormPrincipal()
        {
            InitializeComponent();
            // Llamar a la función para crear los cuadros de aulas
            CrearCuadrosAulas();
        }

        private void CrearCuadrosAulas()
        {
            // Espaciado entre los cuadros de las aulas
            int spacing = 20;
            // Posición inicial de los cuadros de las aulas
            Point startPosition = new Point(20, 20);

            // Iterar sobre la lista de nombres de aulas
            foreach (string nombreAula in nombresAulas)
            {
                // Crear un nuevo PictureBox para representar el cuadro del aula
                PictureBox pictureBox = new PictureBox();
                // Definir el tamaño del PictureBox
                pictureBox.Size = new Size(100, 100);
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
                    startPosition.X = 20;
                    startPosition.Y += pictureBox.Height + spacing;
                }
            }
        }
    }
}
Este código crea una ventana con cuadros dinámicos que representan diferentes aulas. Puedes ajustar el tamaño, color y otros aspectos de los cuadros según tus necesidades. Además, la lista nombresAulas puede ser reemplazada por cualquier método que tengas para obtener los nombres de las aulas dinámicamente.