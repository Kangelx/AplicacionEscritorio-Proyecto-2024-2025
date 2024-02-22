
namespace AplicacionIncidenciasProyecto
{
    partial class FormularioAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioAdministrador));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.imgListIconos = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblSuperior = new System.Windows.Forms.Label();
            this.LogosCuadrados = new System.Windows.Forms.ImageList(this.components);
            this.anel_superiorIzq = new System.Windows.Forms.Panel();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_lateral = new System.Windows.Forms.Panel();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnNotificaciones = new System.Windows.Forms.Button();
            this.btnIncidencias = new System.Windows.Forms.Button();
            this.btnGestionar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chartDatos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_cierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creador_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsable_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipo_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.anel_superiorIzq.SuspendLayout();
            this.panel_lateral.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.lblSuperior);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(154, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(965, 81);
            this.panel2.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.ImageIndex = 5;
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
            // LogosCuadrados
            // 
            this.LogosCuadrados.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("LogosCuadrados.ImageStream")));
            this.LogosCuadrados.TransparentColor = System.Drawing.Color.Transparent;
            this.LogosCuadrados.Images.SetKeyName(0, "AlpacApp Incidents.png");
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
            // panel_lateral
            // 
            this.panel_lateral.BackColor = System.Drawing.Color.Moccasin;
            this.panel_lateral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_lateral.Controls.Add(this.btnInventario);
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
            this.panel_lateral.TabIndex = 9;
            // 
            // btnInventario
            // 
            this.btnInventario.Location = new System.Drawing.Point(-2, 402);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(152, 59);
            this.btnInventario.TabIndex = 12;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(-2, 344);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(152, 59);
            this.btnAdmin.TabIndex = 11;
            this.btnAdmin.Text = "Administrar Perfil";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnNotificaciones
            // 
            this.btnNotificaciones.Location = new System.Drawing.Point(-2, 286);
            this.btnNotificaciones.Name = "btnNotificaciones";
            this.btnNotificaciones.Size = new System.Drawing.Size(152, 59);
            this.btnNotificaciones.TabIndex = 11;
            this.btnNotificaciones.Text = "Notificaciones";
            this.btnNotificaciones.UseVisualStyleBackColor = true;
            this.btnNotificaciones.Click += new System.EventHandler(this.btnNotificaciones_Click);
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
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.txtUser);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(-2, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 92);
            this.panel3.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label16.Location = new System.Drawing.Point(37, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "Modo Administrador";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(40, 63);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(97, 20);
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
            this.label2.ImageList = this.imgListIconos;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 0;
            // 
            // chartDatos
            // 
            chartArea4.Name = "ChartArea1";
            this.chartDatos.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartDatos.Legends.Add(legend4);
            this.chartDatos.Location = new System.Drawing.Point(177, 157);
            this.chartDatos.Name = "chartDatos";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartDatos.Series.Add(series4);
            this.chartDatos.Size = new System.Drawing.Size(244, 118);
            this.chartDatos.TabIndex = 11;
            this.chartDatos.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.tipo,
            this.fecha_creacion,
            this.fecha_cierre,
            this.descripcion,
            this.estado,
            this.creador_id,
            this.responsable_id,
            this.equipo_id});
            this.dataGridView1.Location = new System.Drawing.Point(177, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(841, 252);
            this.dataGridView1.TabIndex = 12;
            // 
            // num
            // 
            this.num.HeaderText = "id";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.Width = 25;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // fecha_creacion
            // 
            this.fecha_creacion.HeaderText = "abierta";
            this.fecha_creacion.Name = "fecha_creacion";
            this.fecha_creacion.ReadOnly = true;
            // 
            // fecha_cierre
            // 
            this.fecha_cierre.HeaderText = "cierre";
            this.fecha_cierre.Name = "fecha_cierre";
            this.fecha_cierre.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // creador_id
            // 
            this.creador_id.HeaderText = "Profesor";
            this.creador_id.Name = "creador_id";
            this.creador_id.ReadOnly = true;
            // 
            // responsable_id
            // 
            this.responsable_id.HeaderText = "Responsable";
            this.responsable_id.Name = "responsable_id";
            this.responsable_id.ReadOnly = true;
            // 
            // equipo_id
            // 
            this.equipo_id.HeaderText = "equipo";
            this.equipo_id.Name = "equipo_id";
            this.equipo_id.ReadOnly = true;
            this.equipo_id.Width = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(171, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(402, 34);
            this.label4.TabIndex = 13;
            this.label4.Text = "Resumen de las incidencias";
            // 
            // FormularioAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 577);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chartDatos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_lateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioAdministrador";
            this.Text = "FormularioAdministrador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormularioAdministrador_FormClosed);
            this.Load += new System.EventHandler(this.FormularioAdministrador_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.anel_superiorIzq.ResumeLayout(false);
            this.panel_lateral.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblSuperior;
        private System.Windows.Forms.ImageList LogosCuadrados;
        private System.Windows.Forms.ImageList imgListIconos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel anel_superiorIzq;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_lateral;
        private System.Windows.Forms.Button btnGestionar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnNotificaciones;
        private System.Windows.Forms.Button btnIncidencias;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDatos;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_creacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_cierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn creador_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsable_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipo_id;
        private System.Windows.Forms.Label label4;
    }
}