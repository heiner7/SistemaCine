namespace CapaPresentacion
{
    partial class frmArtista
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxBuscarArtista = new System.Windows.Forms.ListBox();
            this.txtFiltar_artista = new System.Windows.Forms.TextBox();
            this.btnInactivar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.dgvArtista = new System.Windows.Forms.DataGridView();
            this.txtArtista_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxNacionalidad = new System.Windows.Forms.ComboBox();
            this.txtArtista_biografia = new System.Windows.Forms.TextBox();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 80;
            this.label3.Text = "Biografía:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 79;
            this.label2.Text = "Nacionalidad:";
            // 
            // lbxBuscarArtista
            // 
            this.lbxBuscarArtista.FormattingEnabled = true;
            this.lbxBuscarArtista.Location = new System.Drawing.Point(597, 26);
            this.lbxBuscarArtista.Name = "lbxBuscarArtista";
            this.lbxBuscarArtista.Size = new System.Drawing.Size(180, 134);
            this.lbxBuscarArtista.TabIndex = 77;
            this.lbxBuscarArtista.SelectedIndexChanged += new System.EventHandler(this.lbxBuscarArtista_SelectedIndexChanged);
            // 
            // txtFiltar_artista
            // 
            this.txtFiltar_artista.Location = new System.Drawing.Point(597, 182);
            this.txtFiltar_artista.Name = "txtFiltar_artista";
            this.txtFiltar_artista.Size = new System.Drawing.Size(139, 20);
            this.txtFiltar_artista.TabIndex = 76;
            this.txtFiltar_artista.TextChanged += new System.EventHandler(this.txtFiltar_artista_TextChanged);
            // 
            // btnInactivar
            // 
            this.btnInactivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInactivar.Location = new System.Drawing.Point(231, 193);
            this.btnInactivar.Name = "btnInactivar";
            this.btnInactivar.Size = new System.Drawing.Size(86, 30);
            this.btnInactivar.TabIndex = 75;
            this.btnInactivar.Text = "Inactivar";
            this.btnInactivar.UseVisualStyleBackColor = true;
            this.btnInactivar.Click += new System.EventHandler(this.btnInactivar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(126, 193);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 30);
            this.btnModificar.TabIndex = 74;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(23, 193);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(86, 30);
            this.btnInsertar.TabIndex = 73;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // dgvArtista
            // 
            this.dgvArtista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtista.Location = new System.Drawing.Point(337, 26);
            this.dgvArtista.Name = "dgvArtista";
            this.dgvArtista.Size = new System.Drawing.Size(244, 150);
            this.dgvArtista.TabIndex = 72;
            this.dgvArtista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArtista_CellClick);
            // 
            // txtArtista_nombre
            // 
            this.txtArtista_nombre.Location = new System.Drawing.Point(111, 90);
            this.txtArtista_nombre.Name = "txtArtista_nombre";
            this.txtArtista_nombre.Size = new System.Drawing.Size(143, 20);
            this.txtArtista_nombre.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 70;
            this.label1.Text = "Nombre:";
            // 
            // cbxNacionalidad
            // 
            this.cbxNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNacionalidad.FormattingEnabled = true;
            this.cbxNacionalidad.Items.AddRange(new object[] {
            "Costarricenses",
            "Panamá",
            "Nicaragua"});
            this.cbxNacionalidad.Location = new System.Drawing.Point(123, 48);
            this.cbxNacionalidad.Name = "cbxNacionalidad";
            this.cbxNacionalidad.Size = new System.Drawing.Size(139, 21);
            this.cbxNacionalidad.TabIndex = 78;
            // 
            // txtArtista_biografia
            // 
            this.txtArtista_biografia.Location = new System.Drawing.Point(111, 130);
            this.txtArtista_biografia.Name = "txtArtista_biografia";
            this.txtArtista_biografia.Size = new System.Drawing.Size(143, 20);
            this.txtArtista_biografia.TabIndex = 81;
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(515, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 82;
            this.label4.Text = "Nombre:";
            // 
            // frmArtista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 258);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtArtista_biografia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxNacionalidad);
            this.Controls.Add(this.lbxBuscarArtista);
            this.Controls.Add(this.txtFiltar_artista);
            this.Controls.Add(this.btnInactivar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dgvArtista);
            this.Controls.Add(this.txtArtista_nombre);
            this.Controls.Add(this.label1);
            this.Name = "frmArtista";
            this.Text = "frmArtista";
            this.Load += new System.EventHandler(this.frmArtista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxBuscarArtista;
        private System.Windows.Forms.TextBox txtFiltar_artista;
        private System.Windows.Forms.Button btnInactivar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView dgvArtista;
        private System.Windows.Forms.TextBox txtArtista_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxNacionalidad;
        private System.Windows.Forms.TextBox txtArtista_biografia;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.Label label4;
    }
}