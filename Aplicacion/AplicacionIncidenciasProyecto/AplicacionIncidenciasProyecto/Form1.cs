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
            Point startPosition = new Point(201, 91);

            // Iterar sobre la lista de nombres de aulas
            foreach (string nombreAula in nombresAulas)
            {
                Button aulas = new Button();

                aulas.Size = new Size(150, 125);

                aulas.Location = startPosition;
                aulas.BackColor = Color.LightBlue;
                aulas.Text = nombreAula;
                aulas.Click += (sender, e) =>
                {
                    MessageBox.Show($"Has seleccionado el aula: {((Button)sender).Text}");
                };

                Controls.Add(aulas);
                startPosition.X += aulas.Width + spacing;

                if (startPosition.X + aulas.Width > ClientSize.Width)
                {
                    startPosition.X = 201;
                    startPosition.Y += aulas.Height + spacing;
                }

                
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
