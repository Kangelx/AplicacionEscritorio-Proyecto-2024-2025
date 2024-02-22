﻿using System;
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
    public partial class GestionarIncidenciasProfesor : Form
    {

        FormularioProfesor form1 = new FormularioProfesor();
        public GestionarIncidenciasProfesor(FormularioProfesor form)
        {
            form1 = form;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

       
        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GestionarIncidenciasProfesor_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Visible = true;
        }


       

        private void btnComent_Click(object sender, EventArgs e)
        {
            ComentarIncidenciaProfesor formComent = new ComentarIncidenciaProfesor();
            formComent.Show();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GestionarIncidenciasProfesor_Load(object sender, EventArgs e)
        {

        }
    }
}
