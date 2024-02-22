
namespace AplicacionIncidenciasProyecto
{
    partial class GestionarIncidenciasProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarIncidenciasProfesor));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imgListIconos = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LogosCuadrados = new System.Windows.Forms.ImageList(this.components);
            this.lblSuperior = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnComent = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Controls.Add(this.txtUser);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.lblEmpresa);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblSuperior);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 81);
            this.panel2.TabIndex = 15;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(946, 27);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(84, 20);
            this.txtUser.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ImageIndex = 5;
            this.label3.ImageList = this.imgListIconos;
            this.label3.Location = new System.Drawing.Point(911, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 23);
            this.label3.TabIndex = 27;
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
            this.button1.Location = new System.Drawing.Point(1036, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 31);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ImageIndex = 5;
            this.label1.Location = new System.Drawing.Point(904, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 24;
            // 
            // btnCerrar
            // 
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCerrar.ImageIndex = 0;
            this.btnCerrar.ImageList = this.imgListIconos;
            this.btnCerrar.Location = new System.Drawing.Point(1076, 21);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(34, 31);
            this.btnCerrar.TabIndex = 25;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(64, 21);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(100, 56);
            this.lblEmpresa.TabIndex = 23;
            this.lblEmpresa.Text = "AlpacApp Incidents";
            // 
            // label5
            // 
            this.label5.ImageIndex = 0;
            this.label5.ImageList = this.LogosCuadrados;
            this.label5.Location = new System.Drawing.Point(8, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 75);
            this.label5.TabIndex = 22;
            // 
            // LogosCuadrados
            // 
            this.LogosCuadrados.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("LogosCuadrados.ImageStream")));
            this.LogosCuadrados.TransparentColor = System.Drawing.Color.Transparent;
            this.LogosCuadrados.Images.SetKeyName(0, "AlpacApp Incidents.png");
            // 
            // lblSuperior
            // 
            this.lblSuperior.AutoSize = true;
            this.lblSuperior.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperior.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSuperior.Location = new System.Drawing.Point(161, 43);
            this.lblSuperior.Name = "lblSuperior";
            this.lblSuperior.Size = new System.Drawing.Size(282, 34);
            this.lblSuperior.TabIndex = 21;
            this.lblSuperior.Text = "IES Miguel Herrero ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ImageIndex = 5;
            this.label2.Location = new System.Drawing.Point(913, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(161, 157);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnComent
            // 
            this.btnComent.Location = new System.Drawing.Point(40, 157);
            this.btnComent.Name = "btnComent";
            this.btnComent.Size = new System.Drawing.Size(75, 23);
            this.btnComent.TabIndex = 19;
            this.btnComent.Text = "Comentar";
            this.btnComent.UseVisualStyleBackColor = true;
            this.btnComent.Click += new System.EventHandler(this.btnComent_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(40, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(898, 350);
            this.dataGridView1.TabIndex = 20;
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
            this.desc.Width = 280;
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
            this.label4.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(34, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(332, 34);
            this.label4.TabIndex = 21;
            this.label4.Text = "Gestión de incidencias";
            // 
            // GestionarIncidenciasProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 577);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnComent);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionarIncidenciasProfesor";
            this.Text = "GestionarIncidenciasProfesor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GestionarIncidenciasProfesor_FormClosed);
            this.Load += new System.EventHandler(this.GestionarIncidenciasProfesor_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imgListIconos;
        private System.Windows.Forms.ImageList LogosCuadrados;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnComent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn aula;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_creacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSuperior;
    }
}