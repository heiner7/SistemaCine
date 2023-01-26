namespace CapaPresentacion
{
    partial class frmTipoObra
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTipoObra = new System.Windows.Forms.ComboBox();
            this.lbxBuscarTipoObra = new System.Windows.Forms.ListBox();
            this.txtFiltar_tipoObra = new System.Windows.Forms.TextBox();
            this.btnInactivar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.dgvTipoObra = new System.Windows.Forms.DataGridView();
            this.txtTipoObra_descripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoObra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 79;
            this.label2.Text = "Tipo Obra:";
            // 
            // cbxTipoObra
            // 
            this.cbxTipoObra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoObra.FormattingEnabled = true;
            this.cbxTipoObra.Items.AddRange(new object[] {
            "Pintura",
            "Escultura",
            "Arma",
            "Instrumento Musical",
            "Auto",
            "Avión",
            "Honra Fúnebre",
            "Libro"});
            this.cbxTipoObra.Location = new System.Drawing.Point(115, 47);
            this.cbxTipoObra.Name = "cbxTipoObra";
            this.cbxTipoObra.Size = new System.Drawing.Size(139, 21);
            this.cbxTipoObra.TabIndex = 78;
            // 
            // lbxBuscarTipoObra
            // 
            this.lbxBuscarTipoObra.FormattingEnabled = true;
            this.lbxBuscarTipoObra.Location = new System.Drawing.Point(597, 25);
            this.lbxBuscarTipoObra.Name = "lbxBuscarTipoObra";
            this.lbxBuscarTipoObra.Size = new System.Drawing.Size(180, 134);
            this.lbxBuscarTipoObra.TabIndex = 77;
            this.lbxBuscarTipoObra.SelectedIndexChanged += new System.EventHandler(this.lbxBuscarTipoObra_SelectedIndexChanged);
            // 
            // txtFiltar_tipoObra
            // 
            this.txtFiltar_tipoObra.Location = new System.Drawing.Point(622, 179);
            this.txtFiltar_tipoObra.Name = "txtFiltar_tipoObra";
            this.txtFiltar_tipoObra.Size = new System.Drawing.Size(139, 20);
            this.txtFiltar_tipoObra.TabIndex = 76;
            this.txtFiltar_tipoObra.TextChanged += new System.EventHandler(this.txtFiltar_tipoObra_TextChanged);
            // 
            // btnInactivar
            // 
            this.btnInactivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInactivar.Location = new System.Drawing.Point(231, 175);
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
            this.btnModificar.Location = new System.Drawing.Point(126, 175);
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
            this.btnInsertar.Location = new System.Drawing.Point(23, 175);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(86, 30);
            this.btnInsertar.TabIndex = 73;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // dgvTipoObra
            // 
            this.dgvTipoObra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoObra.Location = new System.Drawing.Point(337, 25);
            this.dgvTipoObra.Name = "dgvTipoObra";
            this.dgvTipoObra.Size = new System.Drawing.Size(244, 150);
            this.dgvTipoObra.TabIndex = 72;
            this.dgvTipoObra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoObra_CellClick);
            // 
            // txtTipoObra_descripcion
            // 
            this.txtTipoObra_descripcion.Location = new System.Drawing.Point(111, 89);
            this.txtTipoObra_descripcion.Name = "txtTipoObra_descripcion";
            this.txtTipoObra_descripcion.Size = new System.Drawing.Size(143, 20);
            this.txtTipoObra_descripcion.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 70;
            this.label1.Text = "Descripción:";
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(538, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 80;
            this.label3.Text = "Tipo Obra:";
            // 
            // frmTipoObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 245);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxTipoObra);
            this.Controls.Add(this.lbxBuscarTipoObra);
            this.Controls.Add(this.txtFiltar_tipoObra);
            this.Controls.Add(this.btnInactivar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dgvTipoObra);
            this.Controls.Add(this.txtTipoObra_descripcion);
            this.Controls.Add(this.label1);
            this.Name = "frmTipoObra";
            this.Text = "frmTipoObra";
            this.Load += new System.EventHandler(this.frmTipoObra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoObra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTipoObra;
        private System.Windows.Forms.ListBox lbxBuscarTipoObra;
        private System.Windows.Forms.TextBox txtFiltar_tipoObra;
        private System.Windows.Forms.Button btnInactivar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView dgvTipoObra;
        private System.Windows.Forms.TextBox txtTipoObra_descripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.Label label3;
    }
}