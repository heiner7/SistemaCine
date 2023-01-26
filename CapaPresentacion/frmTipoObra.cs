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
    public partial class frmTipoObra : Form
    {
        DataSet dsTipoObra;
        DataTable dtTipoObra;
        private bool iniciandoTipoObra = true;

        public frmTipoObra()
        {
            InitializeComponent();
        }

        private void frmTipoObra_Load(object sender, EventArgs e)
        {
            CargarGridTipoObra();
            iniciandoTipoObra = false;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (Validar() == 0)
            {
                using (GestorTipoObra elTipoObra = new GestorTipoObra())
                {
                    elTipoObra.InsertarTipoObra(cbxTipoObra.SelectedItem.ToString(), txtTipoObra_descripcion.Text,  "A");
                }
                MessageBox.Show("TipoObra agregado exitosamente en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGridTipoObra();
                txtFiltar_tipoObra.Clear(); txtTipoObra_descripcion.Clear();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                using (GestorTipoObra elTipoObra = new GestorTipoObra())
                {
                    elTipoObra.ModificarTipoObra(int.Parse(this.dtTipoObra.Rows[0]["TipoObra_id"].ToString()), cbxTipoObra.SelectedItem.ToString(), txtTipoObra_descripcion.Text, "A");
                }
                CargarGridTipoObra();
                txtFiltar_tipoObra.Clear();
                MessageBox.Show("TipoObra modificado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtTipoObra = null;
                dsTipoObra = null; txtTipoObra_descripcion.Clear(); txtFiltar_tipoObra.Clear();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Museo no encontrado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnInactivar_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                using (GestorTipoObra elTipoObra = new GestorTipoObra())
                {
                    if (int.Parse(this.dtTipoObra.Rows[0]["TipoObra_id"].ToString()) != 0)
                        elTipoObra.InactivarTipoObra(int.Parse(this.dtTipoObra.Rows[0]["TipoObra_id"].ToString()));
                }
                CargarGridTipoObra();
                MessageBox.Show("TipoObra Inactivado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtTipoObra = null;
                dsTipoObra = null;
                txtTipoObra_descripcion.Clear();
                txtFiltar_tipoObra.Clear();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("TipoObra no encontrado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //-----------------------------------------------------Parte de metodos----------------------------------------------------------------------------------


        private int Validar()
        {

            if (cbxTipoObra.SelectedItem == null)
            {
                epError.SetError(cbxTipoObra, "Selecionar...");
                cbxTipoObra.Focus();
                return 1;
            }
            else
            {
                epError.Clear();
                return 0;
            }
        }

        private void CargarGridTipoObra()
        {
            using (GestorTipoObra elTipoObra = new GestorTipoObra())
            {
                dgvTipoObra.DataSource = elTipoObra.ListarTipoObra();
                dgvTipoObra.Columns["TipoObra_id"].Visible = false;
                dgvTipoObra.Columns["TipoObra_tipoObra"].HeaderText = "Tipo Obra";
                dgvTipoObra.Columns["TipoObra_descripcion"].HeaderText = "Descripción";
                dgvTipoObra.Columns["TipoObra_estado"].Visible = false;
            }

        }

        private void dgvTipoObra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numeroFila = dgvTipoObra.CurrentCell.RowIndex;
                int TipoObra_id = int.Parse(this.dgvTipoObra[0, numeroFila].Value.ToString());

                using (GestorTipoObra TipoObra = new GestorTipoObra())
                {
                    this.dsTipoObra = TipoObra.ConsultarTipoObra(TipoObra_id);
                    this.dtTipoObra = this.dsTipoObra.Tables[0];
                }
                cbxTipoObra.SelectedItem = dtTipoObra.Rows[0]["TipoObra_tipoObra"].ToString();
                txtTipoObra_descripcion.Text = this.dtTipoObra.Rows[0]["TipoObra_descripcion"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Base de datos vacía", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lbxBuscarTipoObra_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (iniciandoTipoObra) return;

                // Al hacer clic, mostrar el dato
                this.txtFiltar_tipoObra.Text = this.lbxBuscarTipoObra.SelectedItem.ToString();

                // Eliminar las selecciones anteriores
                this.dgvTipoObra.ClearSelection();

                // Recorrer las filas para buscar 
                foreach (DataGridViewRow fila in this.dgvTipoObra.Rows)
                {

                    if (fila.Cells["TipoObra_tipoObra"].Value == null || fila.Cells == null)
                    {
                        break;
                    }

                    int i = this.txtFiltar_tipoObra.Text.IndexOf(",");

                    if (i > -1)
                    {

                        string nombre, descripcion;
                        nombre = this.txtFiltar_tipoObra.Text.Substring(0, i).TrimEnd();
                        descripcion = this.txtFiltar_tipoObra.Text.Substring(i + 1).TrimStart();

                        if (nombre == fila.Cells["TipoObra_tipoObra"].Value.ToString())
                        {

                            this.dgvTipoObra.Rows[fila.Index].Selected = true;

                            this.dgvTipoObra.FirstDisplayedScrollingRowIndex = fila.Index;
                            break;
                        }
                    }
                    else
                    {
                        if (this.txtFiltar_tipoObra.Text == fila.Cells["TipoObra_tipoObra"].Value.ToString())
                        {
                            this.dgvTipoObra.Rows[fila.Index].Selected = true;

                            this.dgvTipoObra.FirstDisplayedScrollingRowIndex = fila.Index;
                            break;
                        }
                    }
                }

            }
            catch (NullReferenceException)
            {
                MessageBox.Show(" Seleccione una opción", "Seleccion no valida",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtFiltar_tipoObra_TextChanged(object sender, EventArgs e)
        {
            if (iniciandoTipoObra)
                return;

            DataRow[] filas;

            using (GestorTipoObra elTipoObra = new GestorTipoObra())
            {
                dgvTipoObra.DataSource = elTipoObra.ListarTipoObra();
                filas = elTipoObra.ListarTipoObra().Select("TipoObra_tipoObra LIKE '%" + txtFiltar_tipoObra.Text + "%'");

                this.lbxBuscarTipoObra.Items.Clear();

                if (filas.Length > 0)
                {
                    foreach (DataRow dr in filas)
                    {
                        this.lbxBuscarTipoObra.Items.Add(dr["TipoObra_tipoObra"].ToString() + " , " +
                            dr["TipoObra_id"].ToString());
                    }

                }
            }
        }
    }
}
