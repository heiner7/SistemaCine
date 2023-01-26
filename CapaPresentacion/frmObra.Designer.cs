namespace CapaPresentacion
{
    partial class frmObra
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
            this.cbxCultura = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTipoObra = new System.Windows.Forms.ComboBox();
            this.lbxBuscarObra = new System.Windows.Forms.ListBox();
            this.txtFiltar_obra = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvObra = new System.Windows.Forms.DataGridView();
            this.txtObra_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxArtista = new System.Windows.Forms.ComboBox();
            this.txtObra_descripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxColeccion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxCultura
            // 
            this.cbxCultura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCultura.FormattingEnabled = true;
            this.cbxCultura.Items.AddRange(new object[] {
            "Griega",
            "Romana",
            "Olmeca",
            "Maya",
            "Italiana"});
            this.cbxCultura.Location = new System.Drawing.Point(103, 100);
            this.cbxCultura.Name = "cbxCultura";
            this.cbxCultura.Size = new System.Drawing.Size(139, 21);
            this.cbxCultura.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 79;
            this.label3.Text = "Cultura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 78;
            this.label2.Text = "Tipo Obra:";
            // 
            // cbxTipoObra
            // 
            this.cbxTipoObra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoObra.FormattingEnabled = true;
            this.cbxTipoObra.Location = new System.Drawing.Point(103, 22);
            this.cbxTipoObra.Name = "cbxTipoObra";
            this.cbxTipoObra.Size = new System.Drawing.Size(139, 21);
            this.cbxTipoObra.TabIndex = 77;
            // 
            // lbxBuscarObra
            // 
            this.lbxBuscarObra.FormattingEnabled = true;
            this.lbxBuscarObra.Location = new System.Drawing.Point(526, 22);
            this.lbxBuscarObra.Name = "lbxBuscarObra";
            this.lbxBuscarObra.Size = new System.Drawing.Size(180, 147);
            this.lbxBuscarObra.TabIndex = 76;
            this.lbxBuscarObra.SelectedIndexChanged += new System.EventHandler(this.lbxBuscarObra_SelectedIndexChanged);
            // 
            // txtFiltar_obra
            // 
            this.txtFiltar_obra.Location = new System.Drawing.Point(526, 175);
            this.txtFiltar_obra.Name = "txtFiltar_obra";
            this.txtFiltar_obra.Size = new System.Drawing.Size(139, 20);
            this.txtFiltar_obra.TabIndex = 75;
            this.txtFiltar_obra.TextChanged += new System.EventHandler(this.txtFiltar_obra_TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(212, 269);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 30);
            this.btnEliminar.TabIndex = 74;
            this.btnEliminar.Text = "Inactivar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(107, 269);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 30);
            this.btnModificar.TabIndex = 73;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvObra
            // 
            this.dgvObra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObra.Location = new System.Drawing.Point(265, 19);
            this.dgvObra.Name = "dgvObra";
            this.dgvObra.Size = new System.Drawing.Size(244, 150);
            this.dgvObra.TabIndex = 72;
            this.dgvObra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObra_CellClick);
            // 
            // txtObra_nombre
            // 
            this.txtObra_nombre.Location = new System.Drawing.Point(103, 65);
            this.txtObra_nombre.Name = "txtObra_nombre";
            this.txtObra_nombre.Size = new System.Drawing.Size(143, 20);
            this.txtObra_nombre.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 70;
            this.label1.Text = "Nombre:";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(15, 269);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(86, 30);
            this.btnInsertar.TabIndex = 81;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 82;
            this.label4.Text = "Artista:";
            // 
            // cbxArtista
            // 
            this.cbxArtista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxArtista.FormattingEnabled = true;
            this.cbxArtista.Location = new System.Drawing.Point(103, 146);
            this.cbxArtista.Name = "cbxArtista";
            this.cbxArtista.Size = new System.Drawing.Size(139, 21);
            this.cbxArtista.TabIndex = 83;
            // 
            // txtObra_descripcion
            // 
            this.txtObra_descripcion.Location = new System.Drawing.Point(103, 222);
            this.txtObra_descripcion.Name = "txtObra_descripcion";
            this.txtObra_descripcion.Size = new System.Drawing.Size(143, 20);
            this.txtObra_descripcion.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 84;
            this.label5.Text = "Descripción:";
            // 
            // cbxColeccion
            // 
            this.cbxColeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxColeccion.FormattingEnabled = true;
            this.cbxColeccion.Location = new System.Drawing.Point(103, 184);
            this.cbxColeccion.Name = "cbxColeccion";
            this.cbxColeccion.Size = new System.Drawing.Size(139, 21);
            this.cbxColeccion.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 86;
            this.label6.Text = "Colección:";
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(443, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 88;
            this.label7.Text = "Nombre:";
            // 
            // frmObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 314);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxColeccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtObra_descripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxArtista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.cbxCultura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxTipoObra);
            this.Controls.Add(this.lbxBuscarObra);
            this.Controls.Add(this.txtFiltar_obra);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvObra);
            this.Controls.Add(this.txtObra_nombre);
            this.Controls.Add(this.label1);
            this.Name = "frmObra";
            this.Text = "frmObra";
            this.Load += new System.EventHandler(this.frmObra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxCultura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTipoObra;
        private System.Windows.Forms.ListBox lbxBuscarObra;
        private System.Windows.Forms.TextBox txtFiltar_obra;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvObra;
        private System.Windows.Forms.TextBox txtObra_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxArtista;
        private System.Windows.Forms.TextBox txtObra_descripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxColeccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.Label label7;
    }
}