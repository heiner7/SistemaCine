using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaMatricula.CapaIntegracion;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            Form form = new frmMuseo();
            form.Show();
            
        }

        private void btnProfesor_Click(object sender, EventArgs e)
        {
            Form form = new frmArtista();
            form.Show();
        }

        private void btnGrupo_Click(object sender, EventArgs e)
        {
            Form form = new frmObra();
            form.Show();
        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            Form form = new frmTipoObra();
            form.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Form form = new frmActivar();
            form.Show();
        }

        private void btnMatricula_Click(object sender, EventArgs e)
        {
            Form form = new frmColeccion();
            form.Show();
        }

        private void btnHorario_Click(object sender, EventArgs e)
        {
            Form form = new frmTipoMuseo();
            form.Show();
        }

        private void btnAula_Click(object sender, EventArgs e)
        {
            Form form = new frmPrecio();
            form.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Form form = new frmUsuario();
            form.Show();
        }

        private void btnImagenObra_Click(object sender, EventArgs e)
        {
            Form form = new frmImagen();
            form.Show();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            Form form = new frmEntrada();
            form.Show();
        }

        private void btnTarjeta_Click(object sender, EventArgs e)
        {
            Form form = new frmTarjeta();
            form.Show();
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form form = new Login();
            form.Visible = true;
            Visible = false;
        }
    }
}
