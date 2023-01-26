namespace CapaPresentacion
{
    partial class frmTipoMuseo
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
            this.lbxBuscarTipoMuseo = new System.Windows.Forms.ListBox();
            this.txtFiltar_tipoMuseo = new System.Windows.Forms.TextBox();
            this.btnInactivar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.dgvTipoMuseo = new System.Windows.Forms.DataGridView();
            this.txtTipoMuseo_descripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTipoMuseo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoMuseo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxBuscarTipoMuseo
            // 
            this.lbxBuscarTipoMuseo.FormattingEnabled = true;
            this.lbxBuscarTipoMuseo.Location = new System.Drawing.Point(596, 26);
            this.lbxBuscarTipoMuseo.Name = "lbxBuscarTipoMuseo";
            this.lbxBuscarTipoMuseo.Size = new System.Drawing.Size(180, 134);
            this.lbxBuscarTipoMuseo.TabIndex = 90;
            this.lbxBuscarTipoMuseo.SelectedIndexChanged += new System.EventHandler(this.lbxBuscarTipoMuseo_SelectedIndexChanged);
            // 
            // txtFiltar_tipoMuseo
            // 
            this.txtFiltar_tipoMuseo.Location = new System.Drawing.Point(596, 182);
            this.txtFiltar_tipoMuseo.Name = "txtFiltar_tipoMuseo";
            this.txtFiltar_tipoMuseo.Size = new System.Drawing.Size(139, 20);
            this.txtFiltar_tipoMuseo.TabIndex = 89;
            this.txtFiltar_tipoMuseo.TextChanged += new System.EventHandler(this.txtFiltar_tipoMuseo_TextChanged);
            // 
            // btnInactivar
            // 
            this.btnInactivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInactivar.Location = new System.Drawing.Point(220, 146);
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
            this.btnModificar.Location = new System.Drawing.Point(115, 146);
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
            this.btnInsertar.Location = new System.Drawing.Point(12, 146);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(86, 30);
            this.btnInsertar.TabIndex = 86;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // dgvTipoMuseo
            // 
            this.dgvTipoMuseo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoMuseo.Location = new System.Drawing.Point(336, 26);
            this.dgvTipoMuseo.Name = "dgvTipoMuseo";
            this.dgvTipoMuseo.Size = new System.Drawing.Size(244, 150);
            this.dgvTipoMuseo.TabIndex = 85;
            this.dgvTipoMuseo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoMuseo_CellClick);
            // 
            // txtTipoMuseo_descripcion
            // 
            this.txtTipoMuseo_descripcion.Location = new System.Drawing.Point(103, 91);
            this.txtTipoMuseo_descripcion.Name = "txtTipoMuseo_descripcion";
            this.txtTipoMuseo_descripcion.Size = new System.Drawing.Size(143, 20);
            this.txtTipoMuseo_descripcion.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 83;
            this.label1.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 95;
            this.label2.Text = "Tipo Museo:";
            // 
            // cbxTipoMuseo
            // 
            this.cbxTipoMuseo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoMuseo.FormattingEnabled = true;
            this.cbxTipoMuseo.Items.AddRange(new object[] {
            "Arte",
            "Historia",
            "Musical",
            "Militar"});
            this.cbxTipoMuseo.Location = new System.Drawing.Point(115, 45);
            this.cbxTipoMuseo.Name = "cbxTipoMuseo";
            this.cbxTipoMuseo.Size = new System.Drawing.Size(139, 21);
            this.cbxTipoMuseo.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(489, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 96;
            this.label3.Text = "Tipo Museo:";
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // frmTipoMuseo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 230);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxTipoMuseo);
            this.Controls.Add(this.lbxBuscarTipoMuseo);
            this.Controls.Add(this.txtFiltar_tipoMuseo);
            this.Controls.Add(this.btnInactivar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dgvTipoMuseo);
            this.Controls.Add(this.txtTipoMuseo_descripcion);
            this.Controls.Add(this.label1);
            this.Name = "frmTipoMuseo";
            this.Text = "frmTipoMuseo";
            this.Load += new System.EventHandler(this.frmTipoMuseo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoMuseo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbxBuscarTipoMuseo;
        private System.Windows.Forms.TextBox txtFiltar_tipoMuseo;
        private System.Windows.Forms.Button btnInactivar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView dgvTipoMuseo;
        private System.Windows.Forms.TextBox txtTipoMuseo_descripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTipoMuseo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider epError;
    }
}