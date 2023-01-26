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
    public partial class frmTipoMuseo : Form
    {
        DataSet dsTipoMuseo;
        DataTable dtTipoMuseo;
        private bool iniciandoTipoMuseo = true;

        public frmTipoMuseo()
        {
            InitializeComponent();
        }

        private void frmTipoMuseo_Load(object sender, EventArgs e)
        {
            CargarGridTipoMuseo();
            iniciandoTipoMuseo = false;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (Validar() == 0)
            {
                using (GestorTipoMuseo elTipoMuseo = new GestorTipoMuseo())
                {
                    elTipoMuseo.InsertarTipoMuseo(cbxTipoMuseo.SelectedItem.ToString(), txtTipoMuseo_descripcion.Text, "A");
                }
                MessageBox.Show("TipoMuseo agregado exitosamente en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGridTipoMuseo();
                txtTipoMuseo_descripcion.Clear();
                txtFiltar_tipoMuseo.Clear();
                dtTipoMuseo = null;
                dsTipoMuseo = null;
            }           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                using (GestorTipoMuseo elTipoMuseo = new GestorTipoMuseo())
                {
                    elTipoMuseo.ModificarTipoMuseo(int.Parse(this.dtTipoMuseo.Rows[0]["TipoMuseo_id"].ToString()), cbxTipoMuseo.SelectedItem.ToString(), txtTipoMuseo_descripcion.Text, "A");
                }
                CargarGridTipoMuseo();
                txtTipoMuseo_descripcion.Clear(); txtFiltar_tipoMuseo.Clear();
                MessageBox.Show("TipoMuseo modificado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtTipoMuseo = null;
                dsTipoMuseo = null;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("TipoMuseo no encontrado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnInactivar_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                using (GestorTipoMuseo elTipoMuseo = new GestorTipoMuseo())
                {
                    if (int.Parse(this.dtTipoMuseo.Rows[0]["TipoMuseo_id"].ToString()) != 0)
                        elTipoMuseo.InactivarTipoMuseo(int.Parse(this.dtTipoMuseo.Rows[0]["TipoMuseo_id"].ToString()));
                }
                CargarGridTipoMuseo();
                MessageBox.Show("TipoMuseo Inactivado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtTipoMuseo = null;
                dsTipoMuseo = null;
                txtTipoMuseo_descripcion.Clear();
                txtFiltar_tipoMuseo.Clear();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("TipoMuseo no encontrado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //-----------------------------------------------------Parte de metodos----------------------------------------------------

        private int Validar()
        {

            if (cbxTipoMuseo.SelectedItem == null)
            {
                epError.SetError(cbxTipoMuseo, "Seleccionar...");
                cbxTipoMuseo.Focus();
                return 1;
            }
            else
            {
                epError.Clear();
                return 0;
            }
        }

        private void CargarGridTipoMuseo()
        {
            using (GestorTipoMuseo elTipoMuseo = new GestorTipoMuseo())
            {
                dgvTipoMuseo.DataSource = elTipoMuseo.ListarTipoMuseo();
                dgvTipoMuseo.Columns["TipoMuseo_id"].Visible = false;
                dgvTipoMuseo.Columns["TipoMuseo_tipo"].HeaderText = "Tipo Museo";
                dgvTipoMuseo.Columns["TipoMuseo_descripcion"].HeaderText = "Descripción";
                dgvTipoMuseo.Columns["TipoMuseo_estado"].Visible = false;
            }

        }

        private void dgvTipoMuseo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numeroFila = dgvTipoMuseo.CurrentCell.RowIndex;
                int TipoMuseo_id = int.Parse(this.dgvTipoMuseo[0, numeroFila].Value.ToString());

                using (GestorTipoMuseo TipoMuseo = new GestorTipoMuseo())
                {
                    this.dsTipoMuseo = TipoMuseo.ConsultarTipoMuseo(TipoMuseo_id);
                    this.dtTipoMuseo = this.dsTipoMuseo.Tables[0];
                }
                cbxTipoMuseo.SelectedItem = dtTipoMuseo.Rows[0]["TipoMuseo_tipo"].ToString();
                txtTipoMuseo_descripcion.Text = this.dtTipoMuseo.Rows[0]["TipoMuseo_descripcion"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Base de datos vacía", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtFiltar_tipoMuseo_TextChanged(object sender, EventArgs e)
        {
            if (iniciandoTipoMuseo)
                return;

            DataRow[] filas;

            using (GestorTipoMuseo elTipoMuseo = new GestorTipoMuseo())
            {
                dgvTipoMuseo.DataSource = elTipoMuseo.ListarTipoMuseo();
                filas = elTipoMuseo.ListarTipoMuseo().Select("TipoMuseo_tipo LIKE '%" + txtFiltar_tipoMuseo.Text + "%'");

                this.lbxBuscarTipoMuseo.Items.Clear();

                if (filas.Length > 0)
                {
                    foreach (DataRow dr in filas)
                    {
                        this.lbxBuscarTipoMuseo.Items.Add(dr["TipoMuseo_tipo"].ToString() + " , " +
                            dr["TipoMuseo_id"].ToString());
                    }

                }
            }
        }

        private void lbxBuscarTipoMuseo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (iniciandoTipoMuseo) return;

                // Al hacer clic, mostrar el dato
                this.txtFiltar_tipoMuseo.Text = this.lbxBuscarTipoMuseo.SelectedItem.ToString();

                // Eliminar las selecciones anteriores
                this.dgvTipoMuseo.ClearSelection();

                // Recorrer las filas para buscar 
                foreach (DataGridViewRow fila in this.dgvTipoMuseo.Rows)
                {

                    if (fila.Cells["TipoMuseo_tipo"].Value == null || fila.Cells == null)
                    {
                        break;
                    }

                    int i = this.txtFiltar_tipoMuseo.Text.IndexOf(",");

                    if (i > -1)
                    {

                        string nombre, descripcion;
                        nombre = this.txtFiltar_tipoMuseo.Text.Substring(0, i).TrimEnd();
                        descripcion = this.txtFiltar_tipoMuseo.Text.Substring(i + 1).TrimStart();

                        if (nombre == fila.Cells["TipoMuseo_tipo"].Value.ToString())
                        {

                            this.dgvTipoMuseo.Rows[fila.Index].Selected = true;

                            this.dgvTipoMuseo.FirstDisplayedScrollingRowIndex = fila.Index;
                            break;
                        }
                    }
                    else
                    {
                        if (this.txtFiltar_tipoMuseo.Text == fila.Cells["TipoMuseo_tipo"].Value.ToString())
                        {
                            this.dgvTipoMuseo.Rows[fila.Index].Selected = true;

                            this.dgvTipoMuseo.FirstDisplayedScrollingRowIndex = fila.Index;
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
    }
}
