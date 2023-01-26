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
    public partial class frmObra : Form
    {
        DataSet dsObra;
        DataTable dtObra;
        private bool iniciandoObra = true;

        public frmObra()
        {
            InitializeComponent();
        }

        private void frmObra_Load(object sender, EventArgs e)
        {
            CargarGridObra();
            iniciandoObra = false;
            CargarComboTipoObra();
            CargarComboArtista();
            CargarComboColeccion();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (Validar() == 0)
            {
                using (GestorObra elObra = new GestorObra())
                {
                    elObra.InsertarObra(int.Parse(cbxArtista.SelectedValue.ToString()), int.Parse(cbxColeccion.SelectedValue.ToString()), int.Parse(cbxTipoObra.SelectedValue.ToString()), txtObra_nombre.Text, txtObra_descripcion.Text, cbxCultura.SelectedItem.ToString(), "A");
                }
                MessageBox.Show("Obra agregado exitosamente en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGridObra();
                txtObra_nombre.Clear();
                txtFiltar_obra.Clear();
                dtObra = null;
                dsObra = null;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                using (GestorObra elObra = new GestorObra())
                {
                    elObra.ModificarObra(int.Parse(this.dtObra.Rows[0]["Obra_id"].ToString()), int.Parse(cbxArtista.SelectedValue.ToString()), int.Parse(cbxColeccion.SelectedValue.ToString()), int.Parse(cbxTipoObra.SelectedValue.ToString()), txtObra_nombre.Text, txtObra_descripcion.Text, cbxCultura.SelectedItem.ToString(), "A");
                }
                CargarGridObra();
                txtObra_nombre.Clear(); txtFiltar_obra.Clear();
                MessageBox.Show("Obra modificado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtObra = null;
                dsObra = null;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Obra no encontrado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                using (GestorObra elObra = new GestorObra())
                {
                    if (int.Parse(this.dtObra.Rows[0]["Obra_id"].ToString()) != 0)
                        elObra.InactivarObra(int.Parse(this.dtObra.Rows[0]["Obra_id"].ToString()));
                }
                CargarGridObra();
                MessageBox.Show("Obra Inactivado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtObra = null;
                dsObra = null;
                txtObra_nombre.Clear();
                txtFiltar_obra.Clear();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Obra no encontrado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //-----------------------------------------------------Parte de metodos----------------------------------------------------------------------------------

        private void CargarGridObra()
        {
            using (GestorObra elObra = new GestorObra())
            {
                dgvObra.DataSource = elObra.ListarObra();
                dgvObra.Columns["Obra_id"].Visible = false;
                dgvObra.Columns["Artista_id"].HeaderText = "Artista_id";
                dgvObra.Columns["Coleccion_id"].HeaderText = "Colección_id";
                dgvObra.Columns["TipoObra_id"].HeaderText = "TipoObra_id";
                dgvObra.Columns["Obra_nombre"].HeaderText = "Nombre";
                dgvObra.Columns["Obra_descripcion"].HeaderText = "Descripción";
                dgvObra.Columns["Obra_cultura"].HeaderText = "Cultura";
                dgvObra.Columns["Obra_estado"].Visible = false;
            }

        }

        private int Validar()
        {

            if (txtObra_nombre.Text.Trim() == "")
            {
                epError.SetError(txtObra_nombre, "Insertar Nombre...");
                txtObra_nombre.Focus();
                return 1;
            }
            else
            {
                epError.Clear();
                return 0;
            }
        }

        private void dgvObra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numeroFila = dgvObra.CurrentCell.RowIndex;
                int Obra_id = int.Parse(this.dgvObra[0, numeroFila].Value.ToString());

                using (GestorObra Obra = new GestorObra())
                {
                    this.dsObra = Obra.ConsultarObra(Obra_id);
                    this.dtObra = this.dsObra.Tables[0];
                }
                cbxTipoObra.SelectedValue = int.Parse(dtObra.Rows[0]["TipoObra_id"].ToString());
                txtObra_nombre.Text = this.dtObra.Rows[0]["Obra_nombre"].ToString();
                cbxCultura.SelectedItem = dtObra.Rows[0]["Obra_cultura"].ToString();
                cbxArtista.SelectedValue = int.Parse(dtObra.Rows[0]["Artista_id"].ToString());
                cbxColeccion.SelectedValue = int.Parse(this.dtObra.Rows[0]["Coleccion_id"].ToString());
                txtObra_descripcion.Text = this.dtObra.Rows[0]["Obra_descripcion"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Base de datos vacía", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lbxBuscarObra_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (iniciandoObra) return;

                // Al hacer clic, mostrar el dato
                this.txtFiltar_obra.Text = this.lbxBuscarObra.SelectedItem.ToString();

                // Eliminar las selecciones anteriores
                this.dgvObra.ClearSelection();

                // Recorrer las filas para buscar 
                foreach (DataGridViewRow fila in this.dgvObra.Rows)
                {

                    if (fila.Cells["Obra_nombre"].Value == null || fila.Cells == null)
                    {
                        break;
                    }

                    int i = this.txtFiltar_obra.Text.IndexOf(",");

                    if (i > -1)
                    {

                        string nombre, descripcion;
                        nombre = this.txtFiltar_obra.Text.Substring(0, i).TrimEnd();
                        descripcion = this.txtFiltar_obra.Text.Substring(i + 1).TrimStart();

                        if (nombre == fila.Cells["Obra_nombre"].Value.ToString())
                        {

                            this.dgvObra.Rows[fila.Index].Selected = true;

                            this.dgvObra.FirstDisplayedScrollingRowIndex = fila.Index;
                            break;
                        }
                    }
                    else
                    {
                        if (this.txtFiltar_obra.Text == fila.Cells["Obra_nombre"].Value.ToString())
                        {
                            this.dgvObra.Rows[fila.Index].Selected = true;

                            this.dgvObra.FirstDisplayedScrollingRowIndex = fila.Index;
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

        private void txtFiltar_obra_TextChanged(object sender, EventArgs e)
        {
            if (iniciandoObra)
                return;

            DataRow[] filas;

            using (GestorObra elObra = new GestorObra())
            {
                dgvObra.DataSource = elObra.ListarObra();
                filas = elObra.ListarObra().Select("Obra_nombre LIKE '%" + txtFiltar_obra.Text + "%'");

                this.lbxBuscarObra.Items.Clear();

                if (filas.Length > 0)
                {
                    foreach (DataRow dr in filas)
                    {
                        this.lbxBuscarObra.Items.Add(dr["Obra_nombre"].ToString() + " , " +
                            dr["Obra_id"].ToString());
                    }

                }
            }
        }

        private void CargarComboTipoObra()
        {
            using (GestorTipoObra elTipoObra = new GestorTipoObra())
            {
                cbxTipoObra.DataSource = elTipoObra.ListarTipoObra();
                cbxTipoObra.ValueMember = "TipoObra_id";
                cbxTipoObra.DisplayMember = "TipoObra_tipoObra";
            }
        }
        private void CargarComboArtista()
        {
            using (GestorArtista elArtista = new GestorArtista())
            {
                cbxArtista.DataSource = elArtista.ListarArtista();
                cbxArtista.ValueMember = "Artista_id";
                cbxArtista.DisplayMember = "Artista_nombre";
            }
        }
        private void CargarComboColeccion()
        {
            using (GestorColeccion elColeccion = new GestorColeccion())
            {
                cbxColeccion.DataSource = elColeccion.ListarColeccion();
                cbxColeccion.ValueMember = "Coleccion_id";
                cbxColeccion.DisplayMember = "Coleccion_nombre";
            }
        }
    }
}
