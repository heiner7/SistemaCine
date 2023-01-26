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
    public partial class frmColeccion : Form
    {
        DataSet dsColeccion;
        DataTable dtColeccion;
        private bool iniciandoColeccion = true;

        public frmColeccion()
        {
            InitializeComponent();
        }

        private void frmColeccion_Load(object sender, EventArgs e)
        {
            CargarGridColeccion();
            iniciandoColeccion = false;
            CargarComboMuseo();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            epError.Clear();
            if (Validar() == 0)
            {
                using (GestorColeccion elColeccion = new GestorColeccion())
                {
                    elColeccion.InsertarColeccion(int.Parse(cbxMuseo.SelectedValue.ToString()), txtColeccion_nombre.Text, txtColeccion_siglo.Text, txtColeccion_observaciones.Text, "A");
                }
                MessageBox.Show("Coleccion agregado exitosamente en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGridColeccion();
                txtColeccion_nombre.Clear(); txtColeccion_siglo.Clear(); txtColeccion_observaciones.Clear();
                txtFiltar_coleccion.Clear();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                using (GestorColeccion elColeccion = new GestorColeccion())
                {
                    elColeccion.ModificarColeccion(int.Parse(this.dtColeccion.Rows[0]["Coleccion_id"].ToString()), int.Parse(cbxMuseo.SelectedValue.ToString()), txtColeccion_nombre.Text, txtColeccion_siglo.Text, txtColeccion_observaciones.Text, "A");
                }
                CargarGridColeccion();
                txtColeccion_nombre.Clear(); txtFiltar_coleccion.Clear(); txtColeccion_siglo.Clear(); txtColeccion_observaciones.Clear();
                MessageBox.Show("Coleccion modificado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtColeccion = null;
                dsColeccion = null;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Coleccion no encontrado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnInactivar_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                using (GestorColeccion elColeccion = new GestorColeccion())
                {
                    if (int.Parse(this.dtColeccion.Rows[0]["Coleccion_id"].ToString()) != 0)
                        elColeccion.InactivarColeccion(int.Parse(this.dtColeccion.Rows[0]["Coleccion_id"].ToString()));
                }
                CargarGridColeccion();
                MessageBox.Show("Coleccion Inactivado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtColeccion = null;
                dsColeccion = null;
                txtColeccion_nombre.Clear(); txtColeccion_siglo.Clear(); txtColeccion_observaciones.Clear();
                txtFiltar_coleccion.Clear();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Museo no encontrado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //-----------------------------------------------------Parte de metodos--------------------------------------------------------------
        private int Validar()
        {

            if (txtColeccion_nombre.Text.Trim() == "")
            {
                epError.SetError(txtColeccion_nombre, "Insertar Nombre...");
                txtColeccion_nombre.Focus();
                return 1;
            }
            else if(txtColeccion_siglo.Text.Trim() == "")
            {
                epError.SetError(txtColeccion_siglo, "Insertar Siglo...");
                txtColeccion_siglo.Focus();
                return 1;
            }
            else
            {
                epError.Clear();
                return 0;
            }
        }

        private void CargarGridColeccion()
        {
            using (GestorColeccion elColeccion = new GestorColeccion())
            {
                dgvColeccion.DataSource = elColeccion.ListarColeccion();
                dgvColeccion.Columns["Coleccion_id"].Visible = false;
                dgvColeccion.Columns["Museo_id"].HeaderText = "Museo_id";
                dgvColeccion.Columns["Coleccion_nombre"].HeaderText = "Nombre";
                dgvColeccion.Columns["Coleccion_siglo"].HeaderText = "Siglo";
                dgvColeccion.Columns["Coleccion_observaciones"].HeaderText = "Observaciones";
                dgvColeccion.Columns["Coleccion_estado"].Visible = false;
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

        private void dgvColeccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numeroFila = dgvColeccion.CurrentCell.RowIndex;
                int Coleccion_id = int.Parse(this.dgvColeccion[0, numeroFila].Value.ToString());

                using (GestorColeccion Coleccion = new GestorColeccion())
                {
                    this.dsColeccion = Coleccion.ConsultarColeccion(Coleccion_id);
                    this.dtColeccion = this.dsColeccion.Tables[0];
                }
                cbxMuseo.SelectedValue = int.Parse(dtColeccion.Rows[0]["Museo_id"].ToString());
                txtColeccion_nombre.Text = this.dtColeccion.Rows[0]["Coleccion_nombre"].ToString();
                txtColeccion_siglo.Text = this.dtColeccion.Rows[0]["Coleccion_siglo"].ToString();
                txtColeccion_observaciones.Text = this.dtColeccion.Rows[0]["Coleccion_observaciones"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Base de datos vacía", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lbxBuscarColeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (iniciandoColeccion) return;

                // Al hacer clic, mostrar el dato
                this.txtFiltar_coleccion.Text = this.lbxBuscarColeccion.SelectedItem.ToString();

                // Eliminar las selecciones anteriores
                this.dgvColeccion.ClearSelection();

                // Recorrer las filas para buscar 
                foreach (DataGridViewRow fila in this.dgvColeccion.Rows)
                {

                    if (fila.Cells["Coleccion_nombre"].Value == null || fila.Cells == null)
                    {
                        break;
                    }

                    int i = this.txtFiltar_coleccion.Text.IndexOf(",");

                    if (i > -1)
                    {

                        string nombre, descripcion;
                        nombre = this.txtFiltar_coleccion.Text.Substring(0, i).TrimEnd();
                        descripcion = this.txtFiltar_coleccion.Text.Substring(i + 1).TrimStart();

                        if (nombre == fila.Cells["Coleccion_nombre"].Value.ToString())
                        {

                            this.dgvColeccion.Rows[fila.Index].Selected = true;

                            this.dgvColeccion.FirstDisplayedScrollingRowIndex = fila.Index;
                            break;
                        }
                    }
                    else
                    {
                        if (this.txtFiltar_coleccion.Text == fila.Cells["Coleccion_nombre"].Value.ToString())
                        {
                            this.dgvColeccion.Rows[fila.Index].Selected = true;

                            this.dgvColeccion.FirstDisplayedScrollingRowIndex = fila.Index;
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

        private void txtFiltar_coleccion_TextChanged(object sender, EventArgs e)
        {
            if (iniciandoColeccion)
                return;

            DataRow[] filas;

            using (GestorColeccion elColeccion = new GestorColeccion())
            {
                dgvColeccion.DataSource = elColeccion.ListarColeccion();
                filas = elColeccion.ListarColeccion().Select("Coleccion_nombre LIKE '%" + txtFiltar_coleccion.Text + "%'");

                this.lbxBuscarColeccion.Items.Clear();

                if (filas.Length > 0)
                {
                    foreach (DataRow dr in filas)
                    {
                        this.lbxBuscarColeccion.Items.Add(dr["Coleccion_nombre"].ToString() + " , " +
                            dr["Coleccion_id"].ToString());
                    }

                }
            }
        }
    }
}
