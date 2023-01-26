namespace CapaPresentacion
{
    partial class frmPrecio
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
            this.txtPrecio_monto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxMuseo = new System.Windows.Forms.ComboBox();
            this.btnInactivar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.dgvPrecio = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPrecio_modalidad = new System.Windows.Forms.ComboBox();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrecio_monto
            // 
            this.txtPrecio_monto.Location = new System.Drawing.Point(109, 134);
            this.txtPrecio_monto.Name = "txtPrecio_monto";
            this.txtPrecio_monto.Size = new System.Drawing.Size(139, 20);
            this.txtPrecio_monto.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 93;
            this.label3.Text = "Monto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 92;
            this.label2.Text = "Museo:";
            // 
            // cbxMuseo
            // 
            this.cbxMuseo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMuseo.FormattingEnabled = true;
            this.cbxMuseo.Location = new System.Drawing.Point(109, 51);
            this.cbxMuseo.Name = "cbxMuseo";
            this.cbxMuseo.Size = new System.Drawing.Size(139, 21);
            this.cbxMuseo.TabIndex = 91;
            // 
            // btnInactivar
            // 
            this.btnInactivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInactivar.Location = new System.Drawing.Point(229, 197);
            this.btnInactivar.Name = "btnInactivar";
            this.btnInactivar.Size = new System.Drawing.Size(86, 30);
            this.btnInactivar.TabIndex = 88;
            this.btnInactivar.Text = "Inactivar";
            this.btnInactivar.UseVisualStyleBackColor = true;
            this.btnInactivar.Click += new System.EventHandler(this.btnInactivar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(124, 197);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 30);
            this.btnModificar.TabIndex = 87;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(21, 197);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(86, 30);
            this.btnInsertar.TabIndex = 86;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // dgvPrecio
            // 
            this.dgvPrecio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrecio.Location = new System.Drawing.Point(335, 30);
            this.dgvPrecio.Name = "dgvPrecio";
            this.dgvPrecio.Size = new System.Drawing.Size(244, 150);
            this.dgvPrecio.TabIndex = 85;
            this.dgvPrecio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrecio_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 83;
            this.label1.Text = "Fecha:";
            // 
            // cbxPrecio_modalidad
            // 
            this.cbxPrecio_modalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPrecio_modalidad.FormattingEnabled = true;
            this.cbxPrecio_modalidad.Items.AddRange(new object[] {
            "Lunes a Sábado",
            "domingo"});
            this.cbxPrecio_modalidad.Location = new System.Drawing.Point(109, 93);
            this.cbxPrecio_modalidad.Name = "cbxPrecio_modalidad";
            this.cbxPrecio_modalidad.Size = new System.Drawing.Size(139, 21);
            this.cbxPrecio_modalidad.TabIndex = 96;
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // frmPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 240);
            this.Controls.Add(this.cbxPrecio_modalidad);
            this.Controls.Add(this.txtPrecio_monto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxMuseo);
            this.Controls.Add(this.btnInactivar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dgvPrecio);
            this.Controls.Add(this.label1);
            this.Name = "frmPrecio";
            this.Text = "frmPrecio";
            this.Load += new System.EventHandler(this.frmPrecio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPrecio_monto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxMuseo;
        private System.Windows.Forms.Button btnInactivar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView dgvPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPrecio_modalidad;
        private System.Windows.Forms.ErrorProvider epError;
    }
}