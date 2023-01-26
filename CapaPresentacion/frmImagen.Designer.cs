namespace CapaPresentacion
{
    partial class frmImagen
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
            this.btnExaminar = new System.Windows.Forms.Button();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxObra = new System.Windows.Forms.ComboBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInactivar = new System.Windows.Forms.Button();
            this.lbxBuscarImagen = new System.Windows.Forms.ListBox();
            this.txtFiltar_imagen = new System.Windows.Forms.TextBox();
            this.dgvImagen = new System.Windows.Forms.DataGridView();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExaminar
            // 
            this.btnExaminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnExaminar.Location = new System.Drawing.Point(283, 12);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(75, 28);
            this.btnExaminar.TabIndex = 4;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // pbxImagen
            // 
            this.pbxImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxImagen.Location = new System.Drawing.Point(364, 12);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(204, 138);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 3;
            this.pbxImagen.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 80;
            this.label2.Text = "Obras:";
            // 
            // cbxObra
            // 
            this.cbxObra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxObra.FormattingEnabled = true;
            this.cbxObra.Location = new System.Drawing.Point(113, 39);
            this.cbxObra.Name = "cbxObra";
            this.cbxObra.Size = new System.Drawing.Size(139, 21);
            this.cbxObra.TabIndex = 79;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnInsertar.Location = new System.Drawing.Point(25, 122);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 28);
            this.btnInsertar.TabIndex = 81;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnModificar.Location = new System.Drawing.Point(113, 122);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 28);
            this.btnModificar.TabIndex = 82;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInactivar
            // 
            this.btnInactivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnInactivar.Location = new System.Drawing.Point(207, 122);
            this.btnInactivar.Name = "btnInactivar";
            this.btnInactivar.Size = new System.Drawing.Size(75, 28);
            this.btnInactivar.TabIndex = 83;
            this.btnInactivar.Text = "Inactivar";
            this.btnInactivar.UseVisualStyleBackColor = true;
            this.btnInactivar.Click += new System.EventHandler(this.btnInactivar_Click);
            // 
            // lbxBuscarImagen
            // 
            this.lbxBuscarImagen.FormattingEnabled = true;
            this.lbxBuscarImagen.Location = new System.Drawing.Point(574, 12);
            this.lbxBuscarImagen.Name = "lbxBuscarImagen";
            this.lbxBuscarImagen.Size = new System.Drawing.Size(180, 134);
            this.lbxBuscarImagen.TabIndex = 85;
            this.lbxBuscarImagen.SelectedIndexChanged += new System.EventHandler(this.lbxBuscarImagen_SelectedIndexChanged);
            // 
            // txtFiltar_imagen
            // 
            this.txtFiltar_imagen.Location = new System.Drawing.Point(574, 168);
            this.txtFiltar_imagen.Name = "txtFiltar_imagen";
            this.txtFiltar_imagen.Size = new System.Drawing.Size(139, 20);
            this.txtFiltar_imagen.TabIndex = 84;
            this.txtFiltar_imagen.TextChanged += new System.EventHandler(this.txtFiltar_imagen_TextChanged);
            // 
            // dgvImagen
            // 
            this.dgvImagen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImagen.Location = new System.Drawing.Point(279, 156);
            this.dgvImagen.Name = "dgvImagen";
            this.dgvImagen.Size = new System.Drawing.Size(289, 150);
            this.dgvImagen.TabIndex = 86;
            this.dgvImagen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImagen_CellClick);
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // frmImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 316);
            this.Controls.Add(this.dgvImagen);
            this.Controls.Add(this.lbxBuscarImagen);
            this.Controls.Add(this.txtFiltar_imagen);
            this.Controls.Add(this.btnInactivar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxObra);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.pbxImagen);
            this.Name = "frmImagen";
            this.Text = "frmImagen";
            this.Load += new System.EventHandler(this.frmImagen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxObra;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInactivar;
        private System.Windows.Forms.ListBox lbxBuscarImagen;
        private System.Windows.Forms.TextBox txtFiltar_imagen;
        private System.Windows.Forms.DataGridView dgvImagen;
        private System.Windows.Forms.ErrorProvider epError;
    }
}