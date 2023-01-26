namespace CapaPresentacion
{
    partial class frmTarjeta
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
            this.btnInactivar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.dgvTarjeta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTarjeta_porcentaje = new System.Windows.Forms.TextBox();
            this.cbxTipoTarjeta = new System.Windows.Forms.ComboBox();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 78;
            this.label3.Text = "Porcentaje:";
            // 
            // btnInactivar
            // 
            this.btnInactivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInactivar.Location = new System.Drawing.Point(227, 182);
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
            this.btnModificar.Location = new System.Drawing.Point(122, 182);
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
            this.btnInsertar.Location = new System.Drawing.Point(19, 182);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(86, 30);
            this.btnInsertar.TabIndex = 73;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // dgvTarjeta
            // 
            this.dgvTarjeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarjeta.Location = new System.Drawing.Point(333, 32);
            this.dgvTarjeta.Name = "dgvTarjeta";
            this.dgvTarjeta.Size = new System.Drawing.Size(244, 150);
            this.dgvTarjeta.TabIndex = 72;
            this.dgvTarjeta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarjeta_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 70;
            this.label1.Text = "Tipo Tarjeta:";
            // 
            // txtTarjeta_porcentaje
            // 
            this.txtTarjeta_porcentaje.Location = new System.Drawing.Point(112, 89);
            this.txtTarjeta_porcentaje.Name = "txtTarjeta_porcentaje";
            this.txtTarjeta_porcentaje.Size = new System.Drawing.Size(143, 20);
            this.txtTarjeta_porcentaje.TabIndex = 79;
            // 
            // cbxTipoTarjeta
            // 
            this.cbxTipoTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoTarjeta.FormattingEnabled = true;
            this.cbxTipoTarjeta.Items.AddRange(new object[] {
            "Visa",
            "Mastercard",
            "American Express",
            "Dinner Club",
            "Uniom Pay"});
            this.cbxTipoTarjeta.Location = new System.Drawing.Point(112, 38);
            this.cbxTipoTarjeta.Name = "cbxTipoTarjeta";
            this.cbxTipoTarjeta.Size = new System.Drawing.Size(139, 21);
            this.cbxTipoTarjeta.TabIndex = 80;
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // frmTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 249);
            this.Controls.Add(this.cbxTipoTarjeta);
            this.Controls.Add(this.txtTarjeta_porcentaje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInactivar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dgvTarjeta);
            this.Controls.Add(this.label1);
            this.Name = "frmTarjeta";
            this.Text = "frmTarjeta";
            this.Load += new System.EventHandler(this.frmTarjeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInactivar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView dgvTarjeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTarjeta_porcentaje;
        private System.Windows.Forms.ComboBox cbxTipoTarjeta;
        private System.Windows.Forms.ErrorProvider epError;
    }
}