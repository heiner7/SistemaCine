namespace CapaPresentacion
{
    partial class frmColeccion
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
            this.cbxMuseo = new System.Windows.Forms.ComboBox();
            this.lbxBuscarColeccion = new System.Windows.Forms.ListBox();
            this.txtFiltar_coleccion = new System.Windows.Forms.TextBox();
            this.btnInactivar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.dgvColeccion = new System.Windows.Forms.DataGridView();
            this.txtColeccion_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtColeccion_siglo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtColeccion_observaciones = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColeccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 79;
            this.label2.Text = "Museo:";
            // 
            // cbxMuseo
            // 
            this.cbxMuseo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMuseo.FormattingEnabled = true;
            this.cbxMuseo.Location = new System.Drawing.Point(114, 48);
            this.cbxMuseo.Name = "cbxMuseo";
            this.cbxMuseo.Size = new System.Drawing.Size(139, 21);
            this.cbxMuseo.TabIndex = 78;
            // 
            // lbxBuscarColeccion
            // 
            this.lbxBuscarColeccion.FormattingEnabled = true;
            this.lbxBuscarColeccion.Location = new System.Drawing.Point(596, 26);
            this.lbxBuscarColeccion.Name = "lbxBuscarColeccion";
            this.lbxBuscarColeccion.Size = new System.Drawing.Size(180, 134);
            this.lbxBuscarColeccion.TabIndex = 77;
            this.lbxBuscarColeccion.SelectedIndexChanged += new System.EventHandler(this.lbxBuscarColeccion_SelectedIndexChanged);
            // 
            // txtFiltar_coleccion
            // 
            this.txtFiltar_coleccion.Location = new System.Drawing.Point(596, 182);
            this.txtFiltar_coleccion.Name = "txtFiltar_coleccion";
            this.txtFiltar_coleccion.Size = new System.Drawing.Size(139, 20);
            this.txtFiltar_coleccion.TabIndex = 76;
            this.txtFiltar_coleccion.TextChanged += new System.EventHandler(this.txtFiltar_coleccion_TextChanged);
            // 
            // btnInactivar
            // 
            this.btnInactivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInactivar.Location = new System.Drawing.Point(230, 237);
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
            this.btnModificar.Location = new System.Drawing.Point(125, 237);
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
            this.btnInsertar.Location = new System.Drawing.Point(22, 237);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(86, 30);
            this.btnInsertar.TabIndex = 73;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // dgvColeccion
            // 
            this.dgvColeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColeccion.Location = new System.Drawing.Point(336, 26);
            this.dgvColeccion.Name = "dgvColeccion";
            this.dgvColeccion.Size = new System.Drawing.Size(244, 150);
            this.dgvColeccion.TabIndex = 72;
            this.dgvColeccion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvColeccion_CellClick);
            // 
            // txtColeccion_nombre
            // 
            this.txtColeccion_nombre.Location = new System.Drawing.Point(110, 90);
            this.txtColeccion_nombre.Name = "txtColeccion_nombre";
            this.txtColeccion_nombre.Size = new System.Drawing.Size(143, 20);
            this.txtColeccion_nombre.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 70;
            this.label1.Text = "Nombre:";
            // 
            // txtColeccion_siglo
            // 
            this.txtColeccion_siglo.Location = new System.Drawing.Point(110, 140);
            this.txtColeccion_siglo.Name = "txtColeccion_siglo";
            this.txtColeccion_siglo.Size = new System.Drawing.Size(143, 20);
            this.txtColeccion_siglo.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 80;
            this.label3.Text = "Siglo:";
            // 
            // txtColeccion_observaciones
            // 
            this.txtColeccion_observaciones.Location = new System.Drawing.Point(137, 182);
            this.txtColeccion_observaciones.Name = "txtColeccion_observaciones";
            this.txtColeccion_observaciones.Size = new System.Drawing.Size(143, 20);
            this.txtColeccion_observaciones.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 82;
            this.label4.Text = "Observaciones:";
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(514, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 84;
            this.label5.Text = "Nombre:";
            // 
            // frmColeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 288);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtColeccion_observaciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtColeccion_siglo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxMuseo);
            this.Controls.Add(this.lbxBuscarColeccion);
            this.Controls.Add(this.txtFiltar_coleccion);
            this.Controls.Add(this.btnInactivar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dgvColeccion);
            this.Controls.Add(this.txtColeccion_nombre);
            this.Controls.Add(this.label1);
            this.Name = "frmColeccion";
            this.Text = "frmColeccion";
            this.Load += new System.EventHandler(this.frmColeccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColeccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxMuseo;
        private System.Windows.Forms.ListBox lbxBuscarColeccion;
        private System.Windows.Forms.TextBox txtFiltar_coleccion;
        private System.Windows.Forms.Button btnInactivar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView dgvColeccion;
        private System.Windows.Forms.TextBox txtColeccion_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtColeccion_siglo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtColeccion_observaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.Label label5;
    }
}