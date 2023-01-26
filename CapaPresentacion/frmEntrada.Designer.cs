namespace CapaPresentacion
{
    partial class frmEntrada
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.cbxTarjeta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxMuseo = new System.Windows.Forms.ComboBox();
            this.lbxBuscarEntrada = new System.Windows.Forms.ListBox();
            this.txtFiltar_entrada = new System.Windows.Forms.TextBox();
            this.btnInactivar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvEntrada = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPrecio = new System.Windows.Forms.ComboBox();
            this.txtEntrada_nombreVisitante = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEntrada_cantidad = new System.Windows.Forms.TextBox();
            this.txtEntrada_comision = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtEntrada_fecha = new System.Windows.Forms.DateTimePicker();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(338, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 107;
            this.label7.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 105;
            this.label6.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 103;
            this.label5.Text = "Fecha:";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(27, 375);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(86, 30);
            this.btnInsertar.TabIndex = 100;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // cbxTarjeta
            // 
            this.cbxTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTarjeta.FormattingEnabled = true;
            this.cbxTarjeta.Location = new System.Drawing.Point(115, 128);
            this.cbxTarjeta.Name = "cbxTarjeta";
            this.cbxTarjeta.Size = new System.Drawing.Size(139, 21);
            this.cbxTarjeta.TabIndex = 99;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 98;
            this.label3.Text = "Tarjeta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 97;
            this.label2.Text = "Museo:";
            // 
            // cbxMuseo
            // 
            this.cbxMuseo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMuseo.FormattingEnabled = true;
            this.cbxMuseo.Location = new System.Drawing.Point(115, 41);
            this.cbxMuseo.Name = "cbxMuseo";
            this.cbxMuseo.Size = new System.Drawing.Size(139, 21);
            this.cbxMuseo.TabIndex = 96;
            // 
            // lbxBuscarEntrada
            // 
            this.lbxBuscarEntrada.FormattingEnabled = true;
            this.lbxBuscarEntrada.Location = new System.Drawing.Point(341, 204);
            this.lbxBuscarEntrada.Name = "lbxBuscarEntrada";
            this.lbxBuscarEntrada.Size = new System.Drawing.Size(180, 147);
            this.lbxBuscarEntrada.TabIndex = 95;
            // 
            // txtFiltar_entrada
            // 
            this.txtFiltar_entrada.Location = new System.Drawing.Point(341, 357);
            this.txtFiltar_entrada.Name = "txtFiltar_entrada";
            this.txtFiltar_entrada.Size = new System.Drawing.Size(139, 20);
            this.txtFiltar_entrada.TabIndex = 94;
            // 
            // btnInactivar
            // 
            this.btnInactivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInactivar.Location = new System.Drawing.Point(235, 375);
            this.btnInactivar.Name = "btnInactivar";
            this.btnInactivar.Size = new System.Drawing.Size(86, 30);
            this.btnInactivar.TabIndex = 93;
            this.btnInactivar.Text = "Inactivar";
            this.btnInactivar.UseVisualStyleBackColor = true;
            this.btnInactivar.Click += new System.EventHandler(this.btnInactivar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(132, 375);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 30);
            this.btnModificar.TabIndex = 92;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // dgvEntrada
            // 
            this.dgvEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrada.Location = new System.Drawing.Point(277, 38);
            this.dgvEntrada.Name = "dgvEntrada";
            this.dgvEntrada.Size = new System.Drawing.Size(244, 150);
            this.dgvEntrada.TabIndex = 91;
            this.dgvEntrada.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntrada_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 89;
            this.label1.Text = "Precio:";
            // 
            // cbxPrecio
            // 
            this.cbxPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPrecio.FormattingEnabled = true;
            this.cbxPrecio.Items.AddRange(new object[] {
            "Griega",
            "Romana",
            "Olmeca",
            "Maya",
            "Italiana"});
            this.cbxPrecio.Location = new System.Drawing.Point(115, 83);
            this.cbxPrecio.Name = "cbxPrecio";
            this.cbxPrecio.Size = new System.Drawing.Size(139, 21);
            this.cbxPrecio.TabIndex = 108;
            // 
            // txtEntrada_nombreVisitante
            // 
            this.txtEntrada_nombreVisitante.Location = new System.Drawing.Point(115, 179);
            this.txtEntrada_nombreVisitante.Name = "txtEntrada_nombreVisitante";
            this.txtEntrada_nombreVisitante.Size = new System.Drawing.Size(143, 20);
            this.txtEntrada_nombreVisitante.TabIndex = 109;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 18);
            this.label8.TabIndex = 110;
            this.label8.Text = "Cantidad:";
            // 
            // txtEntrada_cantidad
            // 
            this.txtEntrada_cantidad.Location = new System.Drawing.Point(111, 256);
            this.txtEntrada_cantidad.Name = "txtEntrada_cantidad";
            this.txtEntrada_cantidad.Size = new System.Drawing.Size(143, 20);
            this.txtEntrada_cantidad.TabIndex = 111;
            // 
            // txtEntrada_comision
            // 
            this.txtEntrada_comision.Location = new System.Drawing.Point(111, 296);
            this.txtEntrada_comision.Name = "txtEntrada_comision";
            this.txtEntrada_comision.Size = new System.Drawing.Size(143, 20);
            this.txtEntrada_comision.TabIndex = 117;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 298);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 18);
            this.label11.TabIndex = 116;
            this.label11.Text = "Comisión:";
            // 
            // dtEntrada_fecha
            // 
            this.dtEntrada_fecha.Location = new System.Drawing.Point(111, 218);
            this.dtEntrada_fecha.Name = "dtEntrada_fecha";
            this.dtEntrada_fecha.Size = new System.Drawing.Size(200, 20);
            this.dtEntrada_fecha.TabIndex = 118;
            this.dtEntrada_fecha.Value = new System.DateTime(2019, 9, 29, 0, 0, 0, 0);
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // frmEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 413);
            this.Controls.Add(this.dtEntrada_fecha);
            this.Controls.Add(this.txtEntrada_comision);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEntrada_cantidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEntrada_nombreVisitante);
            this.Controls.Add(this.cbxPrecio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.cbxTarjeta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxMuseo);
            this.Controls.Add(this.lbxBuscarEntrada);
            this.Controls.Add(this.txtFiltar_entrada);
            this.Controls.Add(this.btnInactivar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvEntrada);
            this.Controls.Add(this.label1);
            this.Name = "frmEntrada";
            this.Text = "frmEntrada";
            this.Load += new System.EventHandler(this.frmEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.ComboBox cbxTarjeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxMuseo;
        private System.Windows.Forms.ListBox lbxBuscarEntrada;
        private System.Windows.Forms.TextBox txtFiltar_entrada;
        private System.Windows.Forms.Button btnInactivar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPrecio;
        private System.Windows.Forms.TextBox txtEntrada_nombreVisitante;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEntrada_cantidad;
        private System.Windows.Forms.TextBox txtEntrada_comision;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtEntrada_fecha;
        private System.Windows.Forms.ErrorProvider epError;
    }
}