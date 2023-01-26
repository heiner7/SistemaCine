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
using System.Collections.Generic;

namespace CapaPresentacion
{
    public partial class frmImagen : Form
    {
        DataSet dsImagen;
        DataTable dtImagen;
        private bool iniciandoImagen = true;
        System.IO.MemoryStream ms = new System.IO.MemoryStream();

        public OpenFileDialog examinar = new OpenFileDialog();

        public frmImagen()
        {
            InitializeComponent();
        }

        private void frmImagen_Load(object sender, EventArgs e)
        {
            CargarGridImagen();
            CargarComboObra();
            iniciandoImagen = false;
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            examinar.Filter = "image files|*.jpg;*.png;*.gif;.*,";
            DialogResult dres1 = examinar.ShowDialog();
            if (dres1 == DialogResult.Abort)
                return;
            if (dres1 == DialogResult.Cancel)
                return;
            pbxImagen.Image = Image.FromFile(examinar.FileName);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                using (GestorImagen elImagen = new GestorImagen())
                {
                    
                    pbxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                    elImagen.InsertarImagen(int.Parse(cbxObra.SelectedValue.ToString()), ms.GetBuffer(), "A");
                }
                MessageBox.Show("Imagen agregado exitosamente en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGridImagen();
                dtImagen = null;
                dsImagen = null;
                ms = null;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Imagen no seleccionado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                using (GestorImagen elImagen = new GestorImagen())
                {
                    pbxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    elImagen.ModificarImagen(int.Parse(this.dtImagen.Rows[0]["Imagen_id"].ToString()), int.Parse(cbxObra.SelectedValue.ToString()), ms.GetBuffer(), "A");
                }
                CargarGridImagen();
                 txtFiltar_imagen.Clear();
                MessageBox.Show("Imagen modificado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtImagen = null;
                dsImagen = null;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Imagen no encontrado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnInactivar_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                using (GestorImagen elImagen = new GestorImagen())
                {
                    if (int.Parse(this.dtImagen.Rows[0]["Imagen_id"].ToString()) != 0)
                        elImagen.InactivarImagen(int.Parse(this.dtImagen.Rows[0]["Imagen_id"].ToString()));
                }
                CargarGridImagen();
                MessageBox.Show("Imagen Inactivado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtImagen = null;
                dsImagen = null;
                txtFiltar_imagen.Clear();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Imagen no encontrado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //-----------------------------------------------------Parte de metodos----------------------------------------------------------------------------------

        private void CargarComboObra()
        {
            using (GestorObra elObra = new GestorObra())
            {
                cbxObra.DataSource = elObra.ListarObra();
                cbxObra.ValueMember = "Obra_id";
                cbxObra.DisplayMember = "Obra_nombre";
            }
        }

        private void dgvImagen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
              int numeroFila = dgvImagen.CurrentCell.RowIndex;
                int Imagen_id = int.Parse(this.dgvImagen[0, numeroFila].Value.ToString());

                using (GestorImagen Imagen = new GestorImagen())
                {
                    this.dsImagen = Imagen.ConsultarImagen(Imagen_id);             
                    this.dtImagen = this.dsImagen.Tables[0];
                }
                cbxObra.SelectedValue = int.Parse(dtImagen.Rows[0]["Obra_id"].ToString());
            
            
        }

        private void CargarGridImagen()
        {
            using (GestorImagen elImagen = new GestorImagen())
            {
                dgvImagen.DataSource = elImagen.ListarImagen();
                dgvImagen.Columns["Imagen_id"].Visible = false;
                dgvImagen.Columns["Obra_id"].HeaderText = "Obras_id";
                dgvImagen.Columns["Imagen_ubicacion"].HeaderText = "Ubicación";
                dgvImagen.Columns["Imagen_estado"].Visible = false;
            }

        }

        private void lbxBuscarImagen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (iniciandoImagen) return;

                // Al hacer clic, mostrar el dato
                this.txtFiltar_imagen.Text = this.lbxBuscarImagen.SelectedItem.ToString();

                // Eliminar las selecciones anteriores
                this.dgvImagen.ClearSelection();

                // Recorrer las filas para buscar 
                foreach (DataGridViewRow fila in this.dgvImagen.Rows)
                {

                    if (fila.Cells["Obra_id"].Value == null || fila.Cells == null)
                    {
                        break;
                    }

                    int i = this.txtFiltar_imagen.Text.IndexOf(",");

                    if (i > -1)
                    {

                        string nombre, descripcion;
                        nombre = this.txtFiltar_imagen.Text.Substring(0, i).TrimEnd();
                        descripcion = this.txtFiltar_imagen.Text.Substring(i + 1).TrimStart();

                        if (nombre == fila.Cells["Obra_id"].Value.ToString())
                        {

                            this.dgvImagen.Rows[fila.Index].Selected = true;

                            this.dgvImagen.FirstDisplayedScrollingRowIndex = fila.Index;
                            break;
                        }
                    }
                    else
                    {
                        if (this.txtFiltar_imagen.Text == fila.Cells["Obra_id"].Value.ToString())
                        {
                            this.dgvImagen.Rows[fila.Index].Selected = true;

                            this.dgvImagen.FirstDisplayedScrollingRowIndex = fila.Index;
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

        private void txtFiltar_imagen_TextChanged(object sender, EventArgs e)
        {
            if (iniciandoImagen)
                return;

            DataRow[] filas;

            using (GestorImagen elImagen = new GestorImagen())
            {
                dgvImagen.DataSource = elImagen.ListarImagen();
                filas = elImagen.ListarImagen().Select("Obra_id LIKE '%" + txtFiltar_imagen.Text + "%'");

                this.lbxBuscarImagen.Items.Clear();

                if (filas.Length > 0)
                {
                    foreach (DataRow dr in filas)
                    {
                        this.lbxBuscarImagen.Items.Add(dr["Obra_id"].ToString() + " , " +
                            dr["Imagen_id"].ToString());
                    }

                }
            }
        }
    }
}
