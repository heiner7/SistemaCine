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
    

    public partial class frmEntrada : Form
    {
        DataSet dsEntrada;
        DataTable dtEntrada;

        public frmEntrada()
        {
            InitializeComponent();
        }

        private void frmEntrada_Load(object sender, EventArgs e)
        {
            CargarGridEntrada();
            CargarComboMuseo();
            CargarComboPrecio();
            
            CargarComboTarjeta();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {

                float precioMonto, subtotal, total; int cantidad;
                if (Validar() == 0)
                {
                    using (GestorPrecio elPrecio = new GestorPrecio())
                    {
                        cbxPrecio.DataSource = elPrecio.ListarPrecio();
                        cbxPrecio.ValueMember = "Precio_id";
                        cbxTarjeta.DisplayMember = "Precio_monto";
                        this.dsEntrada = elPrecio.ConsultarPrecio(int.Parse(cbxPrecio.SelectedValue.ToString()));
                        this.dtEntrada = this.dsEntrada.Tables[0];
                    }
                    precioMonto = float.Parse(dtEntrada.Rows[0]["Precio_monto"].ToString());
                    cantidad = int.Parse(txtEntrada_cantidad.Text);
                    subtotal = precioMonto * cantidad;
                    total = subtotal + float.Parse(txtEntrada_comision.Text);

                    using (GestorEntrada elEntrada = new GestorEntrada())
                    {
                        elEntrada.InsertarEntrada(int.Parse(cbxMuseo.SelectedValue.ToString()), int.Parse(cbxPrecio.SelectedValue.ToString()), int.Parse(cbxTarjeta.SelectedValue.ToString()), txtEntrada_nombreVisitante.Text, dtEntrada_fecha.Text, int.Parse(txtEntrada_cantidad.Text), subtotal, float.Parse(txtEntrada_comision.Text), total, "A");
                    }
                    MessageBox.Show("Entrada agregado exitosamente en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGridEntrada();
                    txtEntrada_nombreVisitante.Clear();
                    txtFiltar_entrada.Clear();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Error en el valor númerio digitado, digite entero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnInactivar_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                using (GestorEntrada elEntrada = new GestorEntrada())
                {
                    if (int.Parse(this.dtEntrada.Rows[0]["Entrada_id"].ToString()) != 0)
                        elEntrada.InactivarEntrada(int.Parse(this.dtEntrada.Rows[0]["Entrada_id"].ToString()));
                }
                CargarGridEntrada();
                MessageBox.Show("Entrada Inactivado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtEntrada = null;
                dsEntrada = null;
                txtEntrada_nombreVisitante.Clear(); txtEntrada_cantidad.Clear(); txtEntrada_comision.Clear();
                txtFiltar_entrada.Clear();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Entrada no encontrado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private int Validar()
        {
            if (txtEntrada_nombreVisitante.Text.Trim() == "")
            {
                epError.SetError(txtEntrada_nombreVisitante, "Insertar Nombre...");
                txtEntrada_nombreVisitante.Focus();
                return 1;
            }
            else if (txtEntrada_cantidad.Text.Trim() == "")
            {
                epError.SetError(txtEntrada_cantidad, "Insertar Nombre...");
                txtEntrada_cantidad.Focus();
                return 1;
            }
           
            else
            {
                epError.Clear();
                return 0;
            }
        }

        private void CargarGridEntrada()
        {
            using (GestorEntrada elEntrada = new GestorEntrada())
            {
                dgvEntrada.DataSource = elEntrada.ListarEntrada();
                dgvEntrada.Columns["Entrada_id"].Visible = false;
                dgvEntrada.Columns["Museo_id"].HeaderText = "Museo_id";
                dgvEntrada.Columns["Precio_id"].HeaderText = "Precio_id";
                dgvEntrada.Columns["Tarjeta_id"].HeaderText = "Tarjeta_id";
                dgvEntrada.Columns["Entrada_nombreVisitante"].HeaderText = "Nombre";
                dgvEntrada.Columns["Entrada_fecha"].HeaderText = "Fecha";
                dgvEntrada.Columns["Entrada_cantidad"].HeaderText = "Cantidad";
                dgvEntrada.Columns["Entrada_subtotal"].HeaderText = "Subtotal";
                dgvEntrada.Columns["Entrada_comision"].HeaderText = "Comisión";
                dgvEntrada.Columns["Entrada_total"].HeaderText = "Total";
                dgvEntrada.Columns["Entrada_estado"].Visible = false;
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

        private void CargarComboPrecio()
        {
            using (GestorPrecio elPrecio = new GestorPrecio())
            {
                cbxPrecio.DataSource = elPrecio.ListarPrecio();
                cbxPrecio.ValueMember = "Precio_id";
                cbxPrecio.DisplayMember = "Precio_modalidad";
            }
        }

        

        private void CargarComboTarjeta()
        {
            using (GestorTarjeta elTarjeta = new GestorTarjeta())
            {
                cbxTarjeta.DataSource = elTarjeta.ListarTarjeta();
                cbxTarjeta.ValueMember = "Tarjeta_id";
                cbxTarjeta.DisplayMember = "Tarjeta_nombre";
            }
        }

        private void dgvEntrada_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numeroFila = dgvEntrada.CurrentCell.RowIndex;
                int Entrada_id = int.Parse(this.dgvEntrada[0, numeroFila].Value.ToString());

                using (GestorEntrada Entrada = new GestorEntrada())
                {
                    this.dsEntrada = Entrada.ConsultarEntrada(Entrada_id);
                    this.dtEntrada = this.dsEntrada.Tables[0];
                }
                cbxMuseo.SelectedIndex = int.Parse(dtEntrada.Rows[0]["Museo_id"].ToString());
                txtEntrada_nombreVisitante.Text = this.dtEntrada.Rows[0]["Entrada_nombreVisitante"].ToString();
                cbxPrecio.SelectedIndex = int.Parse(this.dtEntrada.Rows[0]["Precio_id"].ToString());
                cbxTarjeta.SelectedValue = int.Parse(this.dtEntrada.Rows[0]["Tarjeta_id"].ToString());
              
                txtEntrada_cantidad.Text = dtEntrada.Rows[0]["Entrada_cantidad"].ToString();
                txtEntrada_comision.Text = dtEntrada.Rows[0]["Entrada_comision"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Base de datos vacía", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
