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
    public partial class frmArtista : Form
    {

        DataSet dsArtista;
        DataTable dtArtista;
        private bool iniciandoArtista = true;

        public frmArtista()
        {
            InitializeComponent();
        }

        private void frmArtista_Load(object sender, EventArgs e)
        {
            CargarGridArtista();
            iniciandoArtista = false;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (Validar() == 0)
            {
                using (GestorArtista elArtista = new GestorArtista())
                {
                    elArtista.InsertarArtista(cbxNacionalidad.SelectedItem.ToString(), txtArtista_nombre.Text, txtArtista_biografia.Text, "A");
                }
                MessageBox.Show("Artista agregado exitosamente en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGridArtista();
                txtArtista_nombre.Clear(); txtArtista_biografia.Clear();
                txtFiltar_artista.Clear();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                using (GestorArtista elArtista = new GestorArtista())
                {
                    elArtista.ModificarArtista(int.Parse(this.dtArtista.Rows[0]["Artista_id"].ToString()), cbxNacionalidad.SelectedItem.ToString(), txtArtista_nombre.Text,txtArtista_biografia.Text, "A");
                }
                CargarGridArtista();
                txtArtista_nombre.Clear(); txtFiltar_artista.Clear(); txtArtista_biografia.Clear();
                MessageBox.Show("Artista modificado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtArtista = null;
                dsArtista = null;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Museo no encontado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnInactivar_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                using (GestorArtista elArtista = new GestorArtista())
                {
                    if (int.Parse(this.dtArtista.Rows[0]["Artista_id"].ToString()) != 0)
                        elArtista.InactivarArtista(int.Parse(this.dtArtista.Rows[0]["Artista_id"].ToString()));
                }
                CargarGridArtista();
                MessageBox.Show("Artista Inactivado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtArtista = null;
                dtArtista = null;
                txtArtista_nombre.Clear(); txtArtista_biografia.Clear();
                txtFiltar_artista.Clear();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Artista no encontado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //-----------------------------------------------------Parte de metodos----------------------------------------------------------------------

        private int Validar()
        {

            if (txtArtista_nombre.Text.Trim() == "")
            {
                epError.SetError(txtArtista_nombre, "Insertar Nombre...");
                txtArtista_nombre.Focus();
                return 1;
            }
            else
            {
                epError.Clear();
                return 0;
            }
        }

        private void CargarGridArtista()
        {
            using (GestorArtista elArtista = new GestorArtista())
            {
                dgvArtista.DataSource = elArtista.ListarArtista();
                dgvArtista.Columns["Artista_id"].Visible = false;
                dgvArtista.Columns["Artista_nacionalidad"].HeaderText = "Nacionalidad";
                dgvArtista.Columns["Artista_nombre"].HeaderText = "Nombre";
                dgvArtista.Columns["Artista_biografia"].HeaderText = "Biografía";
                dgvArtista.Columns["Artista_estado"].Visible = false;
            }

        }

        private void dgvArtista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numeroFila = dgvArtista.CurrentCell.RowIndex;
                int Artista_id = int.Parse(this.dgvArtista[0, numeroFila].Value.ToString());

                using (GestorArtista Artista = new GestorArtista())
                {
                    this.dsArtista = Artista.ConsultarArtista(Artista_id);
                    this.dtArtista = this.dsArtista.Tables[0];
                }
                cbxNacionalidad.SelectedItem = dtArtista.Rows[0]["Artista_nacionalidad"].ToString();
                txtArtista_nombre.Text = this.dtArtista.Rows[0]["Artista_nombre"].ToString();
                txtArtista_biografia.Text = this.dtArtista.Rows[0]["Artista_biografia"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Base de datos vacía", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lbxBuscarArtista_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (iniciandoArtista) return;

                // Al hacer clic, mostrar el dato
                this.txtFiltar_artista.Text = this.lbxBuscarArtista.SelectedItem.ToString();

                // Eliminar las selecciones anteriores
                this.dgvArtista.ClearSelection();

                // Recorrer las filas para buscar 
                foreach (DataGridViewRow fila in this.dgvArtista.Rows)
                {

                    if (fila.Cells["Artista_nombre"].Value == null || fila.Cells == null)
                    {
                        break;
                    }

                    int i = this.txtFiltar_artista.Text.IndexOf(",");

                    if (i > -1)
                    {

                        string nombre, descripcion;
                        nombre = this.txtFiltar_artista.Text.Substring(0, i).TrimEnd();
                        descripcion = this.txtFiltar_artista.Text.Substring(i + 1).TrimStart();

                        if (nombre == fila.Cells["Artista_nombre"].Value.ToString())
                        {

                            this.dgvArtista.Rows[fila.Index].Selected = true;

                            this.dgvArtista.FirstDisplayedScrollingRowIndex = fila.Index;
                            break;
                        }
                    }
                    else
                    {
                        if (this.txtFiltar_artista.Text == fila.Cells["Artista_nombre"].Value.ToString())
                        {
                            this.dgvArtista.Rows[fila.Index].Selected = true;

                            this.dgvArtista.FirstDisplayedScrollingRowIndex = fila.Index;
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

        private void txtFiltar_artista_TextChanged(object sender, EventArgs e)
        {
            if (iniciandoArtista)
                return;

            DataRow[] filas;

            using (GestorArtista elArtista = new GestorArtista())
            {
                dgvArtista.DataSource = elArtista.ListarArtista();
                filas = elArtista.ListarArtista().Select("Artista_nombre LIKE '%" + txtFiltar_artista.Text + "%'");

                this.lbxBuscarArtista.Items.Clear();

                if (filas.Length > 0)
                {
                    foreach (DataRow dr in filas)
                    {
                        this.lbxBuscarArtista.Items.Add(dr["Artista_nombre"].ToString() + " , " +
                            dr["Artista_id"].ToString());
                    }

                }
            }
        }
    }
}
