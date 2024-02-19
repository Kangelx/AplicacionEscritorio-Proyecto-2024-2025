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
    public partial class NotificacionesProfesor : Form
    {
        FormularioProfesor form1 = new FormularioProfesor();
        public NotificacionesProfesor(FormularioProfesor form)
        {
            form1 = form;
            InitializeComponent();
        }

        private void NotificacionesProfesor_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NotificacionesProfesor_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Visible = true;
        }
    }
}
