﻿
namespace AplicacionIncidenciasProyecto
{
    partial class IncidenciasProfesor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncidenciasProfesor));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.imgListIconos = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblSuperior = new System.Windows.Forms.Label();
            this.panel_lateral = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnNotificaciones = new System.Windows.Forms.Button();
            this.btnIncidencias = new System.Windows.Forms.Button();
            this.btnGestionar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.anel_superiorIzq = new System.Windows.Forms.Panel();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LogosCuadrados = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.grpbxFiltros = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel_lateral.SuspendLayout();
            this.panel3.SuspendLayout();
            this.anel_superiorIzq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpbxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txtBuscar);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.lblSuperior);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(154, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(965, 81);
            this.panel2.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.ImageIndex = 7;
            this.button3.ImageList = this.imgListIconos;
            this.button3.Location = new System.Drawing.Point(790, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 31);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // imgListIconos
            // 
            this.imgListIconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListIconos.ImageStream")));
            this.imgListIconos.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListIconos.Images.SetKeyName(0, "apagado.png");
            this.imgListIconos.Images.SetKeyName(1, "notificacion.png");
            this.imgListIconos.Images.SetKeyName(2, "casa.png");
            this.imgListIconos.Images.SetKeyName(3, "lupa.png");
            this.imgListIconos.Images.SetKeyName(4, "añadir.png");
            this.imgListIconos.Images.SetKeyName(5, "user.png");
            this.imgListIconos.Images.SetKeyName(6, "volver.png");
            this.imgListIconos.Images.SetKeyName(7, "admin.png");
            this.imgListIconos.Images.SetKeyName(8, "refresh.png");
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.ImageIndex = 6;
            this.button1.ImageList = this.imgListIconos;
            this.button1.Location = new System.Drawing.Point(830, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 31);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.ImageIndex = 3;
            this.button2.ImageList = this.imgListIconos;
            this.button2.Location = new System.Drawing.Point(723, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 31);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBuscar.Location = new System.Drawing.Point(551, 22);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(166, 18);
            this.txtBuscar.TabIndex = 4;
            // 
            // btnCerrar
            // 
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCerrar.ImageIndex = 0;
            this.btnCerrar.ImageList = this.imgListIconos;
            this.btnCerrar.Location = new System.Drawing.Point(870, 16);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(34, 31);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblSuperior
            // 
            this.lblSuperior.AutoSize = true;
            this.lblSuperior.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperior.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSuperior.Location = new System.Drawing.Point(6, 43);
            this.lblSuperior.Name = "lblSuperior";
            this.lblSuperior.Size = new System.Drawing.Size(282, 34);
            this.lblSuperior.TabIndex = 0;
            this.lblSuperior.Text = "IES Miguel Herrero ";
            // 
            // panel_lateral
            // 
            this.panel_lateral.BackColor = System.Drawing.Color.Moccasin;
            this.panel_lateral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_lateral.Controls.Add(this.btnAdmin);
            this.panel_lateral.Controls.Add(this.btnNotificaciones);
            this.panel_lateral.Controls.Add(this.btnIncidencias);
            this.panel_lateral.Controls.Add(this.btnGestionar);
            this.panel_lateral.Controls.Add(this.panel3);
            this.panel_lateral.Controls.Add(this.anel_superiorIzq);
            this.panel_lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_lateral.Location = new System.Drawing.Point(0, 0);
            this.panel_lateral.Name = "panel_lateral";
            this.panel_lateral.Size = new System.Drawing.Size(154, 577);
            this.panel_lateral.TabIndex = 11;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(-2, 344);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(152, 59);
            this.btnAdmin.TabIndex = 11;
            this.btnAdmin.Text = "Administrar Perfil";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // btnNotificaciones
            // 
            this.btnNotificaciones.Location = new System.Drawing.Point(-2, 286);
            this.btnNotificaciones.Name = "btnNotificaciones";
            this.btnNotificaciones.Size = new System.Drawing.Size(152, 59);
            this.btnNotificaciones.TabIndex = 11;
            this.btnNotificaciones.Text = "Notificaciones";
            this.btnNotificaciones.UseVisualStyleBackColor = true;
            // 
            // btnIncidencias
            // 
            this.btnIncidencias.Location = new System.Drawing.Point(-2, 228);
            this.btnIncidencias.Name = "btnIncidencias";
            this.btnIncidencias.Size = new System.Drawing.Size(152, 59);
            this.btnIncidencias.TabIndex = 3;
            this.btnIncidencias.Text = "Mis Incidencias";
            this.btnIncidencias.UseVisualStyleBackColor = true;
            this.btnIncidencias.Click += new System.EventHandler(this.btnIncidencias_Click);
            // 
            // btnGestionar
            // 
            this.btnGestionar.Location = new System.Drawing.Point(-2, 170);
            this.btnGestionar.Name = "btnGestionar";
            this.btnGestionar.Size = new System.Drawing.Size(152, 59);
            this.btnGestionar.TabIndex = 2;
            this.btnGestionar.Text = "Gestionar Incidencias";
            this.btnGestionar.UseVisualStyleBackColor = true;
            this.btnGestionar.Click += new System.EventHandler(this.btnGestionar_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.txtUser);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(-2, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 92);
            this.panel3.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(40, 63);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(84, 20);
            this.txtUser.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ImageIndex = 5;
            this.label3.ImageList = this.imgListIconos;
            this.label3.Location = new System.Drawing.Point(5, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 23);
            this.label3.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ImageIndex = 5;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 0;
            // 
            // anel_superiorIzq
            // 
            this.anel_superiorIzq.BackColor = System.Drawing.SystemColors.Control;
            this.anel_superiorIzq.Controls.Add(this.lblEmpresa);
            this.anel_superiorIzq.Controls.Add(this.label1);
            this.anel_superiorIzq.Dock = System.Windows.Forms.DockStyle.Top;
            this.anel_superiorIzq.Location = new System.Drawing.Point(0, 0);
            this.anel_superiorIzq.Name = "anel_superiorIzq";
            this.anel_superiorIzq.Size = new System.Drawing.Size(150, 79);
            this.anel_superiorIzq.TabIndex = 0;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(58, 19);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(100, 56);
            this.lblEmpresa.TabIndex = 3;
            this.lblEmpresa.Text = "AlpacApp Incidents";
            // 
            // label1
            // 
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.LogosCuadrados;
            this.label1.Location = new System.Drawing.Point(-3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 75);
            this.label1.TabIndex = 2;
            // 
            // LogosCuadrados
            // 
            this.LogosCuadrados.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("LogosCuadrados.ImageStream")));
            this.LogosCuadrados.TransparentColor = System.Drawing.Color.Transparent;
            this.LogosCuadrados.Images.SetKeyName(0, "AlpacApp Incidents.png");
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.tipo,
            this.aula,
            this.desc,
            this.fecha_creacion,
            this.estado,
            this.responsable});
            this.dataGridView1.Location = new System.Drawing.Point(164, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(858, 284);
            this.dataGridView1.TabIndex = 13;
            // 
            // num
            // 
            this.num.HeaderText = "Id";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.Width = 75;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // aula
            // 
            this.aula.HeaderText = "Aula";
            this.aula.Name = "aula";
            // 
            // desc
            // 
            this.desc.HeaderText = "Descripción";
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            this.desc.Width = 240;
            // 
            // fecha_creacion
            // 
            this.fecha_creacion.HeaderText = "Abierta";
            this.fecha_creacion.Name = "fecha_creacion";
            this.fecha_creacion.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // responsable
            // 
            this.responsable.HeaderText = "Responsable";
            this.responsable.Name = "responsable";
            this.responsable.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(158, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 34);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mis Incidencias";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(1032, 472);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 14;
            this.btnVer.Text = "Seleccionar";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // grpbxFiltros
            // 
            this.grpbxFiltros.Controls.Add(this.btnBuscar);
            this.grpbxFiltros.Controls.Add(this.dateTimePicker1);
            this.grpbxFiltros.Controls.Add(this.label6);
            this.grpbxFiltros.Controls.Add(this.comboBox1);
            this.grpbxFiltros.Controls.Add(this.label5);
            this.grpbxFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxFiltros.Location = new System.Drawing.Point(164, 153);
            this.grpbxFiltros.Name = "grpbxFiltros";
            this.grpbxFiltros.Size = new System.Drawing.Size(489, 90);
            this.grpbxFiltros.TabIndex = 15;
            this.grpbxFiltros.TabStop = false;
            this.grpbxFiltros.Text = "Buscar por";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnBuscar.Location = new System.Drawing.Point(408, 61);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(245, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(158, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(195, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Fecha: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "EQUIPOS",
            "CUENTAS",
            "WIFI",
            "INTERNET",
            "SOFTWARRE"});
            this.comboBox1.Location = new System.Drawing.Point(47, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tipo: ";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1032, 509);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // IncidenciasProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 577);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.grpbxFiltros);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_lateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IncidenciasProfesor";
            this.Text = "IncidenciasProfesor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IncidenciasProfesor_FormClosed);
            this.Load += new System.EventHandler(this.IncidenciasProfesor_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_lateral.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.anel_superiorIzq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpbxFiltros.ResumeLayout(false);
            this.grpbxFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblSuperior;
        private System.Windows.Forms.Panel panel_lateral;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnNotificaciones;
        private System.Windows.Forms.Button btnIncidencias;
        private System.Windows.Forms.Button btnGestionar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel anel_superiorIzq;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imgListIconos;
        private System.Windows.Forms.ImageList LogosCuadrados;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn aula;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_creacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsable;
        private System.Windows.Forms.GroupBox grpbxFiltros;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
    }
}