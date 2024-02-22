
namespace AplicacionIncidenciasProyecto.Administrador
{
    partial class InventarioAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventarioAdmin));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.imgListIconos = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.LogosCuadrados = new System.Windows.Forms.ImageList(this.components);
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSuperior = new System.Windows.Forms.Label();
            this.grpbxFiltros = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_adquisicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etiqueta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aula_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.grpbxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Controls.Add(this.lblEmpresa);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtUser);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblSuperior);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 81);
            this.panel2.TabIndex = 35;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(63, 25);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(100, 56);
            this.lblEmpresa.TabIndex = 3;
            this.lblEmpresa.Text = "AlpacApp Incidents";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label16.Location = new System.Drawing.Point(927, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Modo Administrador";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.ImageIndex = 6;
            this.button1.ImageList = this.imgListIconos;
            this.button1.Location = new System.Drawing.Point(1033, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 31);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // label1
            // 
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.LogosCuadrados;
            this.label1.Location = new System.Drawing.Point(3, 6);
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
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(930, 36);
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
            this.label3.Location = new System.Drawing.Point(895, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 23);
            this.label3.TabIndex = 14;
            // 
            // btnCerrar
            // 
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCerrar.ImageIndex = 0;
            this.btnCerrar.ImageList = this.imgListIconos;
            this.btnCerrar.Location = new System.Drawing.Point(1073, 25);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(34, 31);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ImageIndex = 5;
            this.label2.Location = new System.Drawing.Point(903, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 0;
            // 
            // lblSuperior
            // 
            this.lblSuperior.AutoSize = true;
            this.lblSuperior.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperior.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSuperior.Location = new System.Drawing.Point(169, 37);
            this.lblSuperior.Name = "lblSuperior";
            this.lblSuperior.Size = new System.Drawing.Size(282, 34);
            this.lblSuperior.TabIndex = 0;
            this.lblSuperior.Text = "IES Miguel Herrero ";
            // 
            // grpbxFiltros
            // 
            this.grpbxFiltros.Controls.Add(this.textBox1);
            this.grpbxFiltros.Controls.Add(this.btnBuscar);
            this.grpbxFiltros.Controls.Add(this.label6);
            this.grpbxFiltros.Controls.Add(this.comboBox1);
            this.grpbxFiltros.Controls.Add(this.label5);
            this.grpbxFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxFiltros.Location = new System.Drawing.Point(58, 135);
            this.grpbxFiltros.Name = "grpbxFiltros";
            this.grpbxFiltros.Size = new System.Drawing.Size(489, 90);
            this.grpbxFiltros.TabIndex = 36;
            this.grpbxFiltros.TabStop = false;
            this.grpbxFiltros.Text = "Buscar por";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(239, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 17;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(184, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Etiqueta:";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(61, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 34);
            this.label4.TabIndex = 18;
            this.label4.Text = "Inventario";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tipo,
            this.fecha_adquisicion,
            this.etiqueta,
            this.marca,
            this.modelo,
            this.descripcion,
            this.baja,
            this.aula_num,
            this.puesto});
            this.dataGridView1.Location = new System.Drawing.Point(74, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(953, 324);
            this.dataGridView1.TabIndex = 37;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 35;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // fecha_adquisicion
            // 
            this.fecha_adquisicion.HeaderText = "Fecha adqusición";
            this.fecha_adquisicion.Name = "fecha_adquisicion";
            this.fecha_adquisicion.ReadOnly = true;
            // 
            // etiqueta
            // 
            this.etiqueta.HeaderText = "etiqueta";
            this.etiqueta.Name = "etiqueta";
            this.etiqueta.ReadOnly = true;
            this.etiqueta.Width = 60;
            // 
            // marca
            // 
            this.marca.HeaderText = "marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            this.marca.Width = 75;
            // 
            // modelo
            // 
            this.modelo.HeaderText = "modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            this.modelo.Width = 75;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 300;
            // 
            // baja
            // 
            this.baja.HeaderText = "baja";
            this.baja.Name = "baja";
            this.baja.ReadOnly = true;
            this.baja.Width = 70;
            // 
            // aula_num
            // 
            this.aula_num.HeaderText = "aula";
            this.aula_num.Name = "aula_num";
            this.aula_num.ReadOnly = true;
            this.aula_num.Width = 45;
            // 
            // puesto
            // 
            this.puesto.HeaderText = "puesto";
            this.puesto.Name = "puesto";
            this.puesto.ReadOnly = true;
            this.puesto.Width = 50;
            // 
            // InventarioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 577);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpbxFiltros);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventarioAdmin";
            this.Text = "InventarioAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InventarioAdmin_FormClosed);
            
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpbxFiltros.ResumeLayout(false);
            this.grpbxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblSuperior;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imgListIconos;
        private System.Windows.Forms.ImageList LogosCuadrados;
        private System.Windows.Forms.GroupBox grpbxFiltros;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_adquisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn etiqueta;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn baja;
        private System.Windows.Forms.DataGridViewTextBoxColumn aula_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn puesto;
    }
}