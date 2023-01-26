namespace CapaPresentacion
{
    partial class frmPrincipal
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
            this.btnMuseo = new System.Windows.Forms.Button();
            this.btnArtista = new System.Windows.Forms.Button();
            this.btnObra = new System.Windows.Forms.Button();
            this.btnTipoObra = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnColeccion = new System.Windows.Forms.Button();
            this.btnTipoMuseo = new System.Windows.Forms.Button();
            this.btnAula = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnImagenObra = new System.Windows.Forms.Button();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnTarjeta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMuseo
            // 
            this.btnMuseo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuseo.Location = new System.Drawing.Point(66, 51);
            this.btnMuseo.Name = "btnMuseo";
            this.btnMuseo.Size = new System.Drawing.Size(152, 39);
            this.btnMuseo.TabIndex = 0;
            this.btnMuseo.Text = "Museo";
            this.btnMuseo.UseVisualStyleBackColor = true;
            this.btnMuseo.Click += new System.EventHandler(this.btnEstudiante_Click);
            // 
            // btnArtista
            // 
            this.btnArtista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtista.Location = new System.Drawing.Point(241, 51);
            this.btnArtista.Name = "btnArtista";
            this.btnArtista.Size = new System.Drawing.Size(152, 39);
            this.btnArtista.TabIndex = 1;
            this.btnArtista.Text = "Artista";
            this.btnArtista.UseVisualStyleBackColor = true;
            this.btnArtista.Click += new System.EventHandler(this.btnProfesor_Click);
            // 
            // btnObra
            // 
            this.btnObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObra.Location = new System.Drawing.Point(411, 51);
            this.btnObra.Name = "btnObra";
            this.btnObra.Size = new System.Drawing.Size(152, 39);
            this.btnObra.TabIndex = 2;
            this.btnObra.Text = "Obra";
            this.btnObra.UseVisualStyleBackColor = true;
            this.btnObra.Click += new System.EventHandler(this.btnGrupo_Click);
            // 
            // btnTipoObra
            // 
            this.btnTipoObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoObra.Location = new System.Drawing.Point(66, 117);
            this.btnTipoObra.Name = "btnTipoObra";
            this.btnTipoObra.Size = new System.Drawing.Size(152, 39);
            this.btnTipoObra.TabIndex = 3;
            this.btnTipoObra.Text = "Tipo Obra";
            this.btnTipoObra.UseVisualStyleBackColor = true;
            this.btnTipoObra.Click += new System.EventHandler(this.btnCurso_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(411, 250);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(152, 39);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Activar Datos BD";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnColeccion
            // 
            this.btnColeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColeccion.Location = new System.Drawing.Point(241, 117);
            this.btnColeccion.Name = "btnColeccion";
            this.btnColeccion.Size = new System.Drawing.Size(152, 39);
            this.btnColeccion.TabIndex = 5;
            this.btnColeccion.Text = "Coleccion";
            this.btnColeccion.UseVisualStyleBackColor = true;
            this.btnColeccion.Click += new System.EventHandler(this.btnMatricula_Click);
            // 
            // btnTipoMuseo
            // 
            this.btnTipoMuseo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoMuseo.Location = new System.Drawing.Point(411, 117);
            this.btnTipoMuseo.Name = "btnTipoMuseo";
            this.btnTipoMuseo.Size = new System.Drawing.Size(152, 39);
            this.btnTipoMuseo.TabIndex = 6;
            this.btnTipoMuseo.Text = "Tipo Museo";
            this.btnTipoMuseo.UseVisualStyleBackColor = true;
            this.btnTipoMuseo.Click += new System.EventHandler(this.btnHorario_Click);
            // 
            // btnAula
            // 
            this.btnAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAula.Location = new System.Drawing.Point(66, 182);
            this.btnAula.Name = "btnAula";
            this.btnAula.Size = new System.Drawing.Size(152, 39);
            this.btnAula.TabIndex = 7;
            this.btnAula.Text = "Precio";
            this.btnAula.UseVisualStyleBackColor = true;
            this.btnAula.Click += new System.EventHandler(this.btnAula_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.Location = new System.Drawing.Point(241, 182);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(152, 39);
            this.btnUsuario.TabIndex = 8;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnImagenObra
            // 
            this.btnImagenObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagenObra.Location = new System.Drawing.Point(411, 182);
            this.btnImagenObra.Name = "btnImagenObra";
            this.btnImagenObra.Size = new System.Drawing.Size(152, 39);
            this.btnImagenObra.TabIndex = 9;
            this.btnImagenObra.Text = "Imagen Obra";
            this.btnImagenObra.UseVisualStyleBackColor = true;
            this.btnImagenObra.Click += new System.EventHandler(this.btnImagenObra_Click);
            // 
            // btnEntrada
            // 
            this.btnEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.Location = new System.Drawing.Point(241, 250);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(152, 39);
            this.btnEntrada.TabIndex = 10;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnTarjeta
            // 
            this.btnTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarjeta.Location = new System.Drawing.Point(66, 250);
            this.btnTarjeta.Name = "btnTarjeta";
            this.btnTarjeta.Size = new System.Drawing.Size(152, 39);
            this.btnTarjeta.TabIndex = 11;
            this.btnTarjeta.Text = "Tarjeta";
            this.btnTarjeta.UseVisualStyleBackColor = true;
            this.btnTarjeta.Click += new System.EventHandler(this.btnTarjeta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(241, 319);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(152, 39);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(635, 393);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnTarjeta);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.btnImagenObra);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnAula);
            this.Controls.Add(this.btnTipoMuseo);
            this.Controls.Add(this.btnColeccion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnTipoObra);
            this.Controls.Add(this.btnObra);
            this.Controls.Add(this.btnArtista);
            this.Controls.Add(this.btnMuseo);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMuseo;
        private System.Windows.Forms.Button btnArtista;
        private System.Windows.Forms.Button btnObra;
        private System.Windows.Forms.Button btnTipoObra;
        private System.Windows.Forms.Button btnColeccion;
        private System.Windows.Forms.Button btnTipoMuseo;
        private System.Windows.Forms.Button btnAula;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnImagenObra;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnTarjeta;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
    }
}