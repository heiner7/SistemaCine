namespace CapaPresentacion
{
    partial class frmActivar
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
            this.lbxBuscarActivar = new System.Windows.Forms.ListBox();
            this.txtFiltar_activar = new System.Windows.Forms.TextBox();
            this.dgvMuseo = new System.Windows.Forms.DataGridView();
            this.btnActivar = new System.Windows.Forms.Button();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cbxTabla = new System.Windows.Forms.ComboBox();
            this.Tablas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuseo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxBuscarActivar
            // 
            this.lbxBuscarActivar.FormattingEnabled = true;
            this.lbxBuscarActivar.Location = new System.Drawing.Point(384, 12);
            this.lbxBuscarActivar.Name = "lbxBuscarActivar";
            this.lbxBuscarActivar.Size = new System.Drawing.Size(180, 134);
            this.lbxBuscarActivar.TabIndex = 68;
            this.lbxBuscarActivar.SelectedIndexChanged += new System.EventHandler(this.lbxBuscarMuseo_SelectedIndexChanged);
            // 
            // txtFiltar_activar
            // 
            this.txtFiltar_activar.Location = new System.Drawing.Point(384, 168);
            this.txtFiltar_activar.Name = "txtFiltar_activar";
            this.txtFiltar_activar.Size = new System.Drawing.Size(139, 20);
            this.txtFiltar_activar.TabIndex = 67;
            this.txtFiltar_activar.TextChanged += new System.EventHandler(this.txtFiltar_museo_TextChanged);
            // 
            // dgvMuseo
            // 
            this.dgvMuseo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuseo.Location = new System.Drawing.Point(28, 12);
            this.dgvMuseo.Name = "dgvMuseo";
            this.dgvMuseo.Size = new System.Drawing.Size(336, 150);
            this.dgvMuseo.TabIndex = 66;
            this.dgvMuseo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMuseo_CellClick);
            // 
            // btnActivar
            // 
            this.btnActivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivar.Location = new System.Drawing.Point(28, 181);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(86, 30);
            this.btnActivar.TabIndex = 72;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Green;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConsultar.Location = new System.Drawing.Point(585, 111);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(101, 35);
            this.btnConsultar.TabIndex = 73;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cbxTabla
            // 
            this.cbxTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTabla.FormattingEnabled = true;
            this.cbxTabla.Items.AddRange(new object[] {
            "Museo",
            "Artista",
            "Obra",
            "Imagen",
            "Tipo Obra",
            "Colección",
            "Tipo Museo",
            "Entrada",
            "Precio",
            "Tarjeta"});
            this.cbxTabla.Location = new System.Drawing.Point(573, 45);
            this.cbxTabla.Name = "cbxTabla";
            this.cbxTabla.Size = new System.Drawing.Size(139, 24);
            this.cbxTabla.TabIndex = 75;
            // 
            // Tablas
            // 
            this.Tablas.AutoSize = true;
            this.Tablas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tablas.ForeColor = System.Drawing.Color.Blue;
            this.Tablas.Location = new System.Drawing.Point(570, 12);
            this.Tablas.Name = "Tablas";
            this.Tablas.Size = new System.Drawing.Size(58, 18);
            this.Tablas.TabIndex = 74;
            this.Tablas.Text = "Tablas";
            // 
            // frmActivar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 236);
            this.Controls.Add(this.cbxTabla);
            this.Controls.Add(this.Tablas);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnActivar);
            this.Controls.Add(this.lbxBuscarActivar);
            this.Controls.Add(this.txtFiltar_activar);
            this.Controls.Add(this.dgvMuseo);
            this.Name = "frmActivar";
            this.Text = "frmActivar";
            this.Load += new System.EventHandler(this.frmActivar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuseo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxBuscarActivar;
        private System.Windows.Forms.TextBox txtFiltar_activar;
        private System.Windows.Forms.DataGridView dgvMuseo;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.ComboBox cbxTabla;
        private System.Windows.Forms.Label Tablas;
        private System.Windows.Forms.Button btnConsultar;
    }
}