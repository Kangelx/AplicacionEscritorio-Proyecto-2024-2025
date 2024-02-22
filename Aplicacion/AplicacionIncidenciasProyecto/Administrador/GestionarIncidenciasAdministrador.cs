﻿using System;
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
    public partial class GestionarIncidenciasAdministrador : Form
    {
        FormularioAdministrador form1 = new FormularioAdministrador();
        public GestionarIncidenciasAdministrador()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public GestionarIncidenciasAdministrador(FormularioAdministrador form)
        {
            form1 = form;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VerIncidenciaAdministrador form = new VerIncidenciaAdministrador(this);
            form.Owner = this;
            form.Show();
            this.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GestionarIncidenciasAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Visible = true;
        }

        private void btnComent_Click(object sender, EventArgs e)
        {
            ComentarIncidenciaAdministrador formComentAdmin = new ComentarIncidenciaAdministrador();
            formComentAdmin.Show();
        }

       
    }
}
