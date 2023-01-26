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
    public partial class frmTarjeta : Form
    {
        DataSet dsTarjeta;
        DataTable dtTarjeta;
      

        public frmTarjeta()
        {
            InitializeComponent();
        }

        private void frmTarjeta_Load(object sender, EventArgs e)
        {
            CargarGridTarjeta();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            if (Validar() == 0)
            {
                epError.Clear();
                using (GestorTarjeta elTarjeta = new GestorTarjeta())
                {
                    elTarjeta.InsertarTarjeta(cbxTipoTarjeta.SelectedItem.ToString(), txtTarjeta_porcentaje.Text, "A");
                }
                MessageBox.Show("Tarjeta agregado exitosamente en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGridTarjeta();
                txtTarjeta_porcentaje.Clear();
                dtTarjeta = null;
                dsTarjeta = null;
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                using (GestorTarjeta elTarjeta = new GestorTarjeta())
                {
                    elTarjeta.ModificarTarjeta(int.Parse(this.dtTarjeta.Rows[0]["Tarjeta_id"].ToString()), cbxTipoTarjeta.SelectedItem.ToString(), txtTarjeta_porcentaje.Text, "A");
                }
                CargarGridTarjeta();
                txtTarjeta_porcentaje.Clear();
                MessageBox.Show("Tarjeta modificado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtTarjeta = null;
                dsTarjeta = null;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Tarjeta no encontrado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnInactivar_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                using (GestorTarjeta elTarjeta = new GestorTarjeta())
                {
                    if (int.Parse(this.dtTarjeta.Rows[0]["Tarjeta_id"].ToString()) != 0)
                        elTarjeta.InactivarTarjeta(int.Parse(this.dtTarjeta.Rows[0]["Tarjeta_id"].ToString()));
                }
                CargarGridTarjeta();
                MessageBox.Show("Tarjeta Inactivado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtTarjeta = null;
                dsTarjeta = null;
                txtTarjeta_porcentaje.Clear();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Tarjeta no encontrado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private int Validar()
        {

            if (cbxTipoTarjeta.Text.Trim() == "")
            {
                epError.SetError(cbxTipoTarjeta, "Seleccionar...");
                cbxTipoTarjeta.Focus();
                return 1;
            }
            else if (txtTarjeta_porcentaje.Text.Trim() == "")
            {
                epError.SetError(txtTarjeta_porcentaje, "Insertar porcentaje...");
                txtTarjeta_porcentaje.Focus();
                return 1;
            }
            else
            {
                epError.Clear();
                return 0;
            }
        }

        private void CargarGridTarjeta()
        {
            using (GestorTarjeta elTarjeta = new GestorTarjeta())
            {
                dgvTarjeta.DataSource = elTarjeta.ListarTarjeta();
                dgvTarjeta.Columns["Tarjeta_id"].Visible = false;
                dgvTarjeta.Columns["Tarjeta_nombre"].HeaderText = "Nombre";
                dgvTarjeta.Columns["Tarjeta_porcentaje"].HeaderText = "Porcentaje";
                dgvTarjeta.Columns["Tarjeta_estado"].Visible = false;
            }

        }

        private void dgvTarjeta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numeroFila = dgvTarjeta.CurrentCell.RowIndex;
                int Tarjeta_id = int.Parse(this.dgvTarjeta[0, numeroFila].Value.ToString());

                using (GestorTarjeta Tarjeta = new GestorTarjeta())
                {
                    this.dsTarjeta = Tarjeta.ConsultarTarjeta(Tarjeta_id);
                    this.dtTarjeta = this.dsTarjeta.Tables[0];
                }
                cbxTipoTarjeta.SelectedItem = dtTarjeta.Rows[0]["Tarjeta_nombre"].ToString();
                txtTarjeta_porcentaje.Text = this.dtTarjeta.Rows[0]["Tarjeta_porcentaje"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Base de datos vacía", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        
    }
}
