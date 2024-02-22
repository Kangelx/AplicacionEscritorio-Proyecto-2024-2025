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
    public partial class Perfil : Form
    {
        AdministrarPerfilesAdmin form1 = new AdministrarPerfilesAdmin();
        public Perfil()
        {
            InitializeComponent();
        }
        public Perfil(AdministrarPerfilesAdmin form)
        {
            form1 = form;
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Perfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Visible = true;
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