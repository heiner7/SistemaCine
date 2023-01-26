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
    public partial class frmPrecio : Form
    {
        DataSet dsPrecio;
        DataTable dtPrecio;
        

        public frmPrecio()
        {
            InitializeComponent();
        }

        private void frmPrecio_Load(object sender, EventArgs e)
        {
            CargarComboMuseo();
            CargarGridPrecio();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (Validar() == 0)
            {
                using (GestorPrecio elPrecio = new GestorPrecio())
                {
                    elPrecio.InsertarPrecio(int.Parse(cbxMuseo.SelectedValue.ToString()), cbxPrecio_modalidad.SelectedItem.ToString(), float.Parse(txtPrecio_monto.Text), "A");
                }
                MessageBox.Show("Precio agregado exitosamente en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGridPrecio();
                txtPrecio_monto.Clear();
                
            }
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                using (GestorPrecio elPrecio = new GestorPrecio())
                {
                    elPrecio.ModificarPrecio(int.Parse(this.dtPrecio.Rows[0]["Precio_id"].ToString()), int.Parse(cbxMuseo.SelectedValue.ToString()), cbxPrecio_modalidad.SelectedItem.ToString(), float.Parse(txtPrecio_monto.Text), "A");
                }
                CargarGridPrecio();
                txtPrecio_monto.Clear(); 
                MessageBox.Show("Precio modificado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtPrecio = null;
                dsPrecio = null;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Precio no encontrado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnInactivar_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                using (GestorPrecio elPrecio = new GestorPrecio())
                {
                    if (int.Parse(this.dtPrecio.Rows[0]["Precio_id"].ToString()) != 0)
                        elPrecio.InactivarPrecio(int.Parse(this.dtPrecio.Rows[0]["Precio_id"].ToString()));
                }
                CargarGridPrecio();
                MessageBox.Show("Precio Inactivado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtPrecio = null;
                dsPrecio = null;
                txtPrecio_monto.Clear();
               
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Precio no encontrado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private int Validar()
        {

            if (cbxPrecio_modalidad.Text.Trim() == "")
            {
                epError.SetError(cbxPrecio_modalidad, "Seleccionar...");
                cbxPrecio_modalidad.Focus();
                return 1;
            }
            else if (txtPrecio_monto.Text.Trim() == "")
            {
                epError.SetError(txtPrecio_monto, "Insertar Monto...");
                txtPrecio_monto.Focus();
                return 1;
            }
            else
            {
                epError.Clear();
                return 0;
            }
        }

        private void CargarGridPrecio()
        {
            using (GestorPrecio elPrecio = new GestorPrecio())
            {
                dgvPrecio.DataSource = elPrecio.ListarPrecio();
                dgvPrecio.Columns["Precio_id"].Visible = false;
                dgvPrecio.Columns["Precio_modalidad"].HeaderText = "Modalidad";
                dgvPrecio.Columns["Precio_monto"].HeaderText = "Monto";
                dgvPrecio.Columns["Precio_estado"].Visible = false;
            }

        }

        private void CargarComboMuseo()
        {
            using (GestorMuseo elMuseo = new GestorMuseo())
            {
                cbxMuseo.DataSource = elMuseo.ListarMuseo();
                cbxMuseo.ValueMember = "Museo_id";
                cbxMuseo.DisplayMember = "Museo_nombre";
            }
        }

        private void dgvPrecio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numeroFila = dgvPrecio.CurrentCell.RowIndex;
                int Precio_id = int.Parse(this.dgvPrecio[0, numeroFila].Value.ToString());

                using (GestorPrecio Precio = new GestorPrecio())
                {
                    this.dsPrecio = Precio.ConsultarPrecio(Precio_id);
                    this.dtPrecio = this.dsPrecio.Tables[0];
                }
                cbxMuseo.SelectedValue = int.Parse(dtPrecio.Rows[0]["Museo_id"].ToString());
                cbxPrecio_modalidad.SelectedItem = dtPrecio.Rows[0]["Precio_modalidad"].ToString();
                txtPrecio_monto.Text = this.dtPrecio.Rows[0]["Precio_monto"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Base de datos vacía", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        
    }
}
