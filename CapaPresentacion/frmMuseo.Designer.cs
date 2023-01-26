namespace CapaPresentacion
{
    partial class frmMuseo
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.dgvMuseo = new System.Windows.Forms.DataGridView();
            this.txtMuseo_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbxBuscarMuseo = new System.Windows.Forms.ListBox();
            this.txtFiltar_aula = new System.Windows.Forms.TextBox();
            this.cbxTipoMuseo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxInstalacion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuseo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(251, 183);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 30);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Inactivar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(146, 183);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 30);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(43, 183);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(86, 30);
            this.btnInsertar.TabIndex = 9;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // dgvMuseo
            // 
            this.dgvMuseo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuseo.Location = new System.Drawing.Point(357, 33);
            this.dgvMuseo.Name = "dgvMuseo";
            this.dgvMuseo.Size = new System.Drawing.Size(244, 150);
            this.dgvMuseo.TabIndex = 8;
            this.dgvMuseo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMuseo_CellClick);
            // 
            // txtMuseo_nombre
            // 
            this.txtMuseo_nombre.Location = new System.Drawing.Point(131, 97);
            this.txtMuseo_nombre.Name = "txtMuseo_nombre";
            this.txtMuseo_nombre.Size = new System.Drawing.Size(143, 20);
            this.txtMuseo_nombre.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre:";
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // lbxBuscarMuseo
            // 
            this.lbxBuscarMuseo.FormattingEnabled = true;
            this.lbxBuscarMuseo.Location = new System.Drawing.Point(617, 33);
            this.lbxBuscarMuseo.Name = "lbxBuscarMuseo";
            this.lbxBuscarMuseo.Size = new System.Drawing.Size(180, 134);
            this.lbxBuscarMuseo.TabIndex = 65;
            this.lbxBuscarMuseo.SelectedIndexChanged += new System.EventHandler(this.lbxBuscarAula_SelectedIndexChanged);
            // 
            // txtFiltar_aula
            // 
            this.txtFiltar_aula.Location = new System.Drawing.Point(617, 189);
            this.txtFiltar_aula.Name = "txtFiltar_aula";
            this.txtFiltar_aula.Size = new System.Drawing.Size(139, 20);
            this.txtFiltar_aula.TabIndex = 64;
            this.txtFiltar_aula.TextChanged += new System.EventHandler(this.txtFiltar_aula_TextChanged);
            // 
            // cbxTipoMuseo
            // 
            this.cbxTipoMuseo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoMuseo.FormattingEnabled = true;
            this.cbxTipoMuseo.Location = new System.Drawing.Point(135, 55);
            this.cbxTipoMuseo.Name = "cbxTipoMuseo";
            this.cbxTipoMuseo.Size = new System.Drawing.Size(139, 21);
            this.cbxTipoMuseo.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 67;
            this.label2.Text = "Tipo Museo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 68;
            this.label3.Text = "Instalación:";
            // 
            // cbxInstalacion
            // 
            this.cbxInstalacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxInstalacion.FormattingEnabled = true;
            this.cbxInstalacion.Items.AddRange(new object[] {
            "Biblioteca",
            "Armaría",
            "Salón Real",
            "Habitaciones"});
            this.cbxInstalacion.Location = new System.Drawing.Point(131, 146);
            this.cbxInstalacion.Name = "cbxInstalacion";
            this.cbxInstalacion.Size = new System.Drawing.Size(139, 21);
            this.cbxInstalacion.TabIndex = 69;
            // 
            // frmMuseo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(809, 268);
            this.Controls.Add(this.cbxInstalacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxTipoMuseo);
            this.Controls.Add(this.lbxBuscarMuseo);
            this.Controls.Add(this.txtFiltar_aula);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dgvMuseo);
            this.Controls.Add(this.txtMuseo_nombre);
            this.Controls.Add(this.label1);
            this.Name = "frmMuseo";
            this.Text = "frmMuseo";
            this.Load += new System.EventHandler(this.frmAula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuseo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView dgvMuseo;
        private System.Windows.Forms.TextBox txtMuseo_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.ListBox lbxBuscarMuseo;
        private System.Windows.Forms.TextBox txtFiltar_aula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTipoMuseo;
        private System.Windows.Forms.ComboBox cbxInstalacion;
        private System.Windows.Forms.Label label3;
    }
}