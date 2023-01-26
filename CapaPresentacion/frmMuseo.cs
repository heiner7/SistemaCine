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
    public partial class frmMuseo : Form
    {
        DataSet dsAula;
        DataTable dtAula;
        private bool iniciandoMuseo = true;

        public frmMuseo()
        {
            InitializeComponent();
        }

        private void frmAula_Load(object sender, EventArgs e)
        {
            CargarGridMuseo();
            iniciandoMuseo = false;
            CargarComboTipoMuseo();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (Validar() == 0)
            {
                using (GestorMuseo elMuseo = new GestorMuseo())
                {
                    elMuseo.InsertarMuseo(int.Parse(cbxTipoMuseo.SelectedIndex.ToString()), txtMuseo_nombre.Text, cbxInstalacion.SelectedItem.ToString(), "A");
                }
                MessageBox.Show("Museo agregado exitosamente en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGridMuseo();
                txtMuseo_nombre.Clear();
                txtFiltar_aula.Clear();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            { 
                epError.Clear();
                using (GestorMuseo elMuseo = new GestorMuseo())
                {
                    elMuseo.ModificarMuseo(int.Parse(this.dtAula.Rows[0]["Museo_id"].ToString()), int.Parse(cbxTipoMuseo.SelectedIndex.ToString()), txtMuseo_nombre.Text, cbxInstalacion.SelectedItem.ToString(), "A");
                }
                CargarGridMuseo();
                txtMuseo_nombre.Clear(); txtFiltar_aula.Clear();
                MessageBox.Show("Museo modificado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtAula = null;
                dsAula = null;
        }
            catch (NullReferenceException)
            {
                MessageBox.Show("Museo no encontrado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                using (GestorMuseo elMuseo = new GestorMuseo())
                {
                    if (int.Parse(this.dtAula.Rows[0]["Museo_id"].ToString()) != 0)
                        elMuseo.InactivarMuseo(int.Parse(this.dtAula.Rows[0]["Museo_id"].ToString()));
                }
                CargarGridMuseo();
                MessageBox.Show("Museo Inactivado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtAula = null;
                dsAula = null;
                txtMuseo_nombre.Clear();
                txtFiltar_aula.Clear();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Museo no encontrado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


      //-----------------------------------------------------Parte de metodos----------------------------------------------------------------------------------

        private void lbxBuscarAula_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (iniciandoMuseo) return;

                // Al hacer clic, mostrar el dato
                this.txtFiltar_aula.Text = this.lbxBuscarMuseo.SelectedItem.ToString();

                // Eliminar las selecciones anteriores
                this.dgvMuseo.ClearSelection();

                // Recorrer las filas para buscar 
                foreach (DataGridViewRow fila in this.dgvMuseo.Rows)
                {

                    if (fila.Cells["Museo_nombre"].Value == null || fila.Cells == null)
                    {
                        break;
                    }

                    int i = this.txtFiltar_aula.Text.IndexOf(",");

                    if (i > -1)
                    {

                        string nombre, descripcion;
                        nombre = this.txtFiltar_aula.Text.Substring(0, i).TrimEnd();
                        descripcion = this.txtFiltar_aula.Text.Substring(i + 1).TrimStart();

                        if (nombre == fila.Cells["Museo_nombre"].Value.ToString())
                        {

                            this.dgvMuseo.Rows[fila.Index].Selected = true;

                            this.dgvMuseo.FirstDisplayedScrollingRowIndex = fila.Index;
                            break;
                        }
                    }
                    else
                    {
                        if (this.txtFiltar_aula.Text == fila.Cells["Museo_nombre"].Value.ToString())
                        {
                            this.dgvMuseo.Rows[fila.Index].Selected = true;

                            this.dgvMuseo.FirstDisplayedScrollingRowIndex = fila.Index;
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
    

        private int Validar()
        {

            if (txtMuseo_nombre.Text.Trim() == "")
            {
                epError.SetError(txtMuseo_nombre, "Insertar descripcion...");
                txtMuseo_nombre.Focus();
                return 1;
            }
            else
            {
                epError.Clear();
                return 0;
            }
        }

        private void CargarGridMuseo()
        {
            using (GestorMuseo elMuseo = new GestorMuseo())
            {
                dgvMuseo.DataSource = elMuseo.ListarMuseo();
                dgvMuseo.Columns["Museo_id"].Visible = false;
                dgvMuseo.Columns["Museo_nombre"].HeaderText = "Nombre";
                dgvMuseo.Columns["Museo_instalacion"].HeaderText = "Instalación";
                dgvMuseo.Columns["Museo_estado"].Visible = false;
            }

        }

        private void CargarComboTipoMuseo()
        {
            using (GestorTipoMuseo elTipoMuseo = new GestorTipoMuseo())
            {
                cbxTipoMuseo.DataSource = elTipoMuseo.ListarTipoMuseo();
                cbxTipoMuseo.ValueMember = "TipoMuseo_id";
                cbxTipoMuseo.DisplayMember = "TipoMuseo_tipo";
            }
        }

        private void txtFiltar_aula_TextChanged(object sender, EventArgs e)
        {
            if (iniciandoMuseo)
                return;

            DataRow[] filas;

            using (GestorMuseo elMuseo = new GestorMuseo())
            {
                dgvMuseo.DataSource = elMuseo.ListarMuseo();
                filas = elMuseo.ListarMuseo().Select("Museo_nombre LIKE '%" + txtFiltar_aula.Text + "%'");

                this.lbxBuscarMuseo.Items.Clear();

                if (filas.Length > 0)
                {
                    foreach (DataRow dr in filas)
                    {
                        this.lbxBuscarMuseo.Items.Add(dr["Museo_nombre"].ToString() + " , " +
                            dr["Museo_id"].ToString());
                    }

                }
            }
        }

        private void dgvMuseo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numeroFila = dgvMuseo.CurrentCell.RowIndex;
                int Museo_id = int.Parse(this.dgvMuseo[0, numeroFila].Value.ToString());

                using (GestorMuseo Museo = new GestorMuseo())
                {
                    this.dsAula = Museo.ConsultarMuseo(Museo_id);
                    this.dtAula = this.dsAula.Tables[0];
                }
                cbxTipoMuseo.SelectedIndex = int.Parse(dtAula.Rows[0]["TipoMuseo_id"].ToString());
                txtMuseo_nombre.Text = this.dtAula.Rows[0]["Museo_nombre"].ToString();
                cbxInstalacion.SelectedItem = this.dtAula.Rows[0]["Museo_instalacion"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Base de datos vacía", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
