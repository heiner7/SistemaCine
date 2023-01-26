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
    public partial class frmActivar : Form
    {
        DataSet dsActivar;
        DataTable dtActivar;
        private bool iniciandoActivar = true;

        public frmActivar()
        {
            InitializeComponent();
        }

        private void frmActivar_Load(object sender, EventArgs e)
        {
            iniciandoActivar = false;
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 0)
                {
                    using (GestorMuseo elMuseo = new GestorMuseo())
                    {
                        elMuseo.ActivarMuseo(int.Parse(this.dtActivar.Rows[0]["Museo_id"].ToString()));
                    }
                    MessageBox.Show("Museo activado exitosamente en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGridMuseo();
                    

                }else if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 1)
                {
                    using (GestorArtista elArtista = new GestorArtista())
                    {
                        elArtista.ActivarArtista(int.Parse(this.dtActivar.Rows[0]["Artista_id"].ToString()));
                    }
                    MessageBox.Show("Artista activado exitosamente en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGridArtista();

                }
                else if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 2)
                {
                    using (GestorObra elObra = new GestorObra())
                    {
                        elObra.ActivarObra(int.Parse(this.dtActivar.Rows[0]["Obra_id"].ToString()));
                    }
                    MessageBox.Show("Obra activado exitosamente en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGridObra();
                    
                }
                else if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 3)
                {
                    using (GestorImagen elImagen = new GestorImagen())
                    {
                        elImagen.ActivarImagen(int.Parse(this.dtActivar.Rows[0]["Imagen_id"].ToString()));
                    }
                    MessageBox.Show("Imagen activado exitosamente en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGridImagen();

                }
                else if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 4)
                {
                    using (GestorTipoObra elTipoObra = new GestorTipoObra())
                    {
                        elTipoObra.ActivarTipoObra(int.Parse(this.dtActivar.Rows[0]["TipoObra_id"].ToString()));
                    }
                    MessageBox.Show("TipoObra activado exitosamente en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGridTipoObra();

                }
                else if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 5)
                {
                    using (GestorColeccion elColeccion = new GestorColeccion())
                    {
                        elColeccion.ActivarColeccion(int.Parse(this.dtActivar.Rows[0]["Coleccion_id"].ToString()));
                    }
                    MessageBox.Show("Coleccion activado exitosamente en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGridColeccion();

                }
                else if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 6)
                {
                    using (GestorTipoMuseo elTipoMuseo = new GestorTipoMuseo())
                    {
                        elTipoMuseo.ActivarTipoMuseo(int.Parse(this.dtActivar.Rows[0]["TipoMuseo_id"].ToString()));
                    }
                    MessageBox.Show("TipoMuseo activado exitosamente en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGridTipoMuseo();

                }
                else if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 7)
                {
                    using (GestorEntrada elEntrada = new GestorEntrada())
                    {
                        elEntrada.ActivarEntrada(int.Parse(this.dtActivar.Rows[0]["Entrada_id"].ToString()));
                    }
                    MessageBox.Show("Entrada activado exitosamente en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGridEntrada();

                }
                else if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 8)
                {
                    using (GestorPrecio elPrecio = new GestorPrecio())
                    {
                        elPrecio.ActivarPrecio(int.Parse(this.dtActivar.Rows[0]["Precio_id"].ToString()));
                    }
                    MessageBox.Show("Precio activado exitosamente en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGridPrecio();

                }
                else if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 9)
                {
                    using (GestorTarjeta elTarjeta = new GestorTarjeta())
                    {
                        elTarjeta.ActivarTarjeta(int.Parse(this.dtActivar.Rows[0]["Tarjeta_id"].ToString()));
                    }
                    MessageBox.Show("Tarjeta activado exitosamente en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGridTarjeta();

                }

                dtActivar = null;
                dsActivar = null;
                txtFiltar_activar.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Dato no encontrado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 0)

            {
                CargarGridMuseo();
            }
            else if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 1)
            {
                CargarGridArtista();
            }
            else if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 2)
            {
                CargarGridObra();
            }
            else if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 3)
            {
                CargarGridImagen();
            }
            else if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 4)
            {
                CargarGridTipoObra();
            }
            else if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 5)
            {
                CargarGridColeccion();
            }
            else if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 6)
            {
                CargarGridTipoMuseo();
            }
            else if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 7)
            {
                CargarGridEntrada();
            }
            else if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 8)
            {
                CargarGridPrecio();
            }
            else if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 9)
            {
                CargarGridTarjeta();
            }
        }


        //-----------------------------------------------------Parte de metodos----------------------------------------------------------------------------------

        //-----------------------------------------------------Parte de CargarGrid----------------------------------------------------------------------------------

        private void CargarGridMuseo()
        {
            using (GestorMuseo elMuseo = new GestorMuseo())
            {
                dgvMuseo.DataSource = elMuseo.ListarMuseoInactivo();
                dgvMuseo.Columns["Museo_id"].Visible = false;
                dgvMuseo.Columns["Museo_nombre"].HeaderText = "Nombre";
                dgvMuseo.Columns["Museo_instalacion"].HeaderText = "Instalación";
                dgvMuseo.Columns["Museo_estado"].Visible = false;
            }

        }

        private void CargarGridArtista()
        {
            using (GestorArtista elArtista = new GestorArtista())
            {
                dgvMuseo.DataSource = elArtista.ListarArtistaInactivo();
                dgvMuseo.Columns["Artista_id"].Visible = false;
                dgvMuseo.Columns["Artista_nacionalidad"].HeaderText = "Nacionalidad";
                dgvMuseo.Columns["Artista_nombre"].HeaderText = "Nombre";
                dgvMuseo.Columns["Artista_biografia"].HeaderText = "Biografía";
                dgvMuseo.Columns["Artista_estado"].Visible = false;
            }
        }

        private void CargarGridImagen()
        {
            using (GestorImagen elImagen = new GestorImagen())
            {
                dgvMuseo.DataSource = elImagen.ListarImagenInactivo();
                dgvMuseo.Columns["Imagen_id"].Visible = false;
                dgvMuseo.Columns["Obra_id"].HeaderText = "Obra_id";
                dgvMuseo.Columns["Imagen_ubicacion"].HeaderText = "Ubicación";
                dgvMuseo.Columns["Imagen_estado"].Visible = false;
            }
        }

        private void CargarGridObra()
        {
            using (GestorObra elObra = new GestorObra())
            {
                dgvMuseo.DataSource = elObra.ListarObraInactivo();
                dgvMuseo.Columns["Obra_id"].Visible = false;
                dgvMuseo.Columns["Artista_id"].HeaderText = "Artista_id";
                dgvMuseo.Columns["Coleccion_id"].HeaderText = "Colección_id";
                dgvMuseo.Columns["TipoObra_id"].HeaderText = "TipoObra_id";
                dgvMuseo.Columns["Obra_nombre"].HeaderText = "Nombre";
                dgvMuseo.Columns["Obra_descripcion"].HeaderText = "Descripción";
                dgvMuseo.Columns["Obra_cultura"].HeaderText = "Cultura";
                dgvMuseo.Columns["Obra_estado"].Visible = false;
            }
        }

        private void CargarGridTipoObra()
        {
            using (GestorTipoObra elTipoObra = new GestorTipoObra())
            {
                dgvMuseo.DataSource = elTipoObra.ListarTipoObraInactivo();
                dgvMuseo.Columns["TipoObra_id"].Visible = false;
                dgvMuseo.Columns["TipoObra_tipoObra"].HeaderText = "Tipo Obra";
                dgvMuseo.Columns["TipoObra_descripcion"].HeaderText = "Descripción";
                dgvMuseo.Columns["TipoObra_estado"].Visible = false;
            }
        }

        private void CargarGridColeccion()
        {
            using (GestorColeccion elColeccion = new GestorColeccion())
            {
                dgvMuseo.DataSource = elColeccion.ListarColeccionInactivo();
                dgvMuseo.Columns["Coleccion_id"].Visible = false;
                dgvMuseo.Columns["Museo_id"].HeaderText = "Museo_id";
                dgvMuseo.Columns["Coleccion_nombre"].HeaderText = "Nombre";
                dgvMuseo.Columns["Coleccion_siglo"].HeaderText = "Siglo";
                dgvMuseo.Columns["Coleccion_observaciones"].HeaderText = "Observaciones";
                dgvMuseo.Columns["Coleccion_estado"].Visible = false;
            }
        }

        private void CargarGridTipoMuseo()
        {
            using (GestorTipoMuseo elTipoMuseo = new GestorTipoMuseo())
            {
                dgvMuseo.DataSource = elTipoMuseo.ListarTipoMuseoInactivo();
                dgvMuseo.Columns["TipoMuseo_id"].Visible = false;
                dgvMuseo.Columns["TipoMuseo_tipo"].HeaderText = "Tipo Museo";
                dgvMuseo.Columns["TipoMuseo_descripcion"].HeaderText = "Descripción";
                dgvMuseo.Columns["TipoMuseo_estado"].Visible = false;
            }
        }
        private void CargarGridEntrada()
        {
            using (GestorEntrada elEntrada = new GestorEntrada())
            {
                dgvMuseo.DataSource = elEntrada.ListarEntradaInactivo();
                dgvMuseo.Columns["Entrada_id"].Visible = false;
                dgvMuseo.Columns["Museo_id"].HeaderText = "Museo_id";
                dgvMuseo.Columns["Precio_id"].HeaderText = "Precio_id";
                dgvMuseo.Columns["Tarjeta_id"].HeaderText = "Tarjeta_id";
                dgvMuseo.Columns["Entrada_nombreVisitante"].HeaderText = "Nombre Visitante";
                dgvMuseo.Columns["Entrada_fecha"].HeaderText = "Fecha de Entrada";
                dgvMuseo.Columns["Entrada_cantidad"].HeaderText = "Cantidad de Entrada";
                dgvMuseo.Columns["Entrada_subtotal"].HeaderText = "Subtotal";
                dgvMuseo.Columns["Entrada_comision"].HeaderText = "Comisión";
                dgvMuseo.Columns["Entrada_total"].HeaderText = "Total";
                dgvMuseo.Columns["Entrada_estado"].Visible = false;
            }
        }

        private void CargarGridPrecio()
        {
            using (GestorPrecio elPrecio = new GestorPrecio())
            {
                dgvMuseo.DataSource = elPrecio.ListarPrecioInactivo();
                dgvMuseo.Columns["Precio_id"].Visible = false;
                dgvMuseo.Columns["Museo_id"].HeaderText = "Museo_id";
                dgvMuseo.Columns["Precio_modalidad"].HeaderText = "Modalidad";
                dgvMuseo.Columns["Precio_monto"].HeaderText = "Monto";
                dgvMuseo.Columns["Precio_estado"].Visible = false;
            }
        }
        private void CargarGridTarjeta()
        {
            using (GestorTarjeta elTarjeta = new GestorTarjeta())
            {
                dgvMuseo.DataSource = elTarjeta.ListarTarjetaInactivo();
                dgvMuseo.Columns["Tarjeta_id"].Visible = false;
                dgvMuseo.Columns["Tarjeta_nombre"].HeaderText = "Tipo Tarjeta";
                dgvMuseo.Columns["Tarjeta_porcentaje"].HeaderText = "Porcentaje";
                dgvMuseo.Columns["Tarjeta_estado"].Visible = false;
            }
        }
        //-----------------------------------------------------Fin----------------------------------------------------------------------------------


        //-----------------------------------------------------Parte de Tabla----------------------------------------------------------------------------------

        private void dgvMuseo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numeroFila = dgvMuseo.CurrentCell.RowIndex;
                if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 0)
                {
                    int Museo_id = int.Parse(this.dgvMuseo[0, numeroFila].Value.ToString());
                    using (GestorMuseo Museo = new GestorMuseo())
                    {
                        this.dsActivar = Museo.ConsultarMuseo(Museo_id);
                        this.dtActivar = this.dsActivar.Tables[0];
                    }
                }
                else if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 1)
                {
                    int Artista_id = int.Parse(this.dgvMuseo[0, numeroFila].Value.ToString());
                    using (GestorArtista Artista = new GestorArtista())
                    {
                        this.dsActivar = Artista.ConsultarArtista(Artista_id);
                        this.dtActivar = this.dsActivar.Tables[0];
                    }
                }
                else if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 2)
                {
                    int Obra_id = int.Parse(this.dgvMuseo[0, numeroFila].Value.ToString());
                    using (GestorObra Obra = new GestorObra())
                    {
                        this.dsActivar = Obra.ConsultarObra(Obra_id);
                        this.dtActivar = this.dsActivar.Tables[0];
                    }
                }
                else if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 3)
                {
                    int Imagen_id = int.Parse(this.dgvMuseo[0, numeroFila].Value.ToString());
                    using (GestorImagen Imagen = new GestorImagen())
                    {
                        this.dsActivar = Imagen.ConsultarImagen(Imagen_id);
                        this.dtActivar = this.dsActivar.Tables[0];
                    }
                }
                else if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 4)
                {
                    int TipoObra_id = int.Parse(this.dgvMuseo[0, numeroFila].Value.ToString());
                    using (GestorTipoObra TipoObra = new GestorTipoObra())
                    {
                        this.dsActivar = TipoObra.ConsultarTipoObra(TipoObra_id);
                        this.dtActivar = this.dsActivar.Tables[0];
                    }
                }
                else if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 5)
                {
                    int Coleccion_id = int.Parse(this.dgvMuseo[0, numeroFila].Value.ToString());
                    using (GestorColeccion Coleccion = new GestorColeccion())
                    {
                        this.dsActivar = Coleccion.ConsultarColeccion(Coleccion_id);
                        this.dtActivar = this.dsActivar.Tables[0];
                    }
                }
                else if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 6)
                {
                    int TipoMuseo_id = int.Parse(this.dgvMuseo[0, numeroFila].Value.ToString());
                    using (GestorTipoMuseo TipoMuseo = new GestorTipoMuseo())
                    {
                        this.dsActivar = TipoMuseo.ConsultarTipoMuseo(TipoMuseo_id);
                        this.dtActivar = this.dsActivar.Tables[0];
                    }
                }
                else if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 7)
                {
                    int Entrada_id = int.Parse(this.dgvMuseo[0, numeroFila].Value.ToString());
                    using (GestorEntrada Entrada = new GestorEntrada())
                    {
                        this.dsActivar = Entrada.ConsultarEntrada(Entrada_id);
                        this.dtActivar = this.dsActivar.Tables[0];
                    }
                }
                else if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 8)
                {
                    int Precio_id = int.Parse(this.dgvMuseo[0, numeroFila].Value.ToString());
                    using (GestorPrecio Precio = new GestorPrecio())
                    {
                        this.dsActivar = Precio.ConsultarPrecio(Precio_id);
                        this.dtActivar = this.dsActivar.Tables[0];
                    }
                }
                else if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 9)
                {
                    int Tarjeta_id = int.Parse(this.dgvMuseo[0, numeroFila].Value.ToString());
                    using (GestorTarjeta Tarjeta = new GestorTarjeta())
                    {
                        this.dsActivar = Tarjeta.ConsultarTarjeta(Tarjeta_id);
                        this.dtActivar = this.dsActivar.Tables[0];
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Base de datos vacía", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //-----------------------------------------------------Fin----------------------------------------------------------------------------------
       

        private void lbxBuscarMuseo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtFiltar_museo_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        
    }
}
