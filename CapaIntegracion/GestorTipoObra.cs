using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Biblioteca SQL
using System.Data;
//Bibliotecas del sistema
using SistemaMatricula.CapaConexion;
using SistemaMatricula.CapaLogica.LogicaNegocio;
using SistemaMatricula.CapaLogica.Servicio;

namespace SistemaMatricula.CapaIntegracion
{
    public class GestorTipoObra : servicio, IDisposable
    {

        public GestorTipoObra()
        {

        }
        public void Dispose()
        {

        }

        //Metodo para Insertar 
        public string InsertarTipoObra(string TipoObra_tipoObra, string TipoObra_descripcion, string TipoObra_estado)
        {
            TipoObra nuevoTipoObra = new TipoObra(TipoObra_tipoObra, TipoObra_descripcion, TipoObra_estado);
            using (ServicioTipoObra elTipoObra = new ServicioTipoObra())
            {
                return elTipoObra.InsertarTipoObra(nuevoTipoObra);
            }
        }

        //Metodo para Modificar
        public string ModificarTipoObra(int TipoObra_id, string TipoObra_tipoObra, string TipoObra_descripcion, string TipoObra_estado)
        {
            TipoObra nuevoTipoObra = new TipoObra(TipoObra_id, TipoObra_tipoObra, TipoObra_descripcion, TipoObra_estado);
            using (ServicioTipoObra elTipoObra = new ServicioTipoObra())
            {
                return elTipoObra.ModificarTipoObra(nuevoTipoObra);
            }
        }

        public DataSet ConsultarTipoObra(int TipoObra_id)
        {
            using (ServicioTipoObra elTipoObra = new ServicioTipoObra())
            {
                return elTipoObra.ConsultarTipoObra(TipoObra_id);
            }
        }

        public DataTable ListarTipoObra()
        {
            using (ServicioTipoObra elTipoObra = new ServicioTipoObra())
            {
                return elTipoObra.ListarTipoObra();
            }
        }

        public DataTable ListarTipoObraInactivo()
        {
            using (ServicioTipoObra elTipoObra = new ServicioTipoObra())
            {
                return elTipoObra.ListarTipoObraInactivo();
            }
        }

        public string InactivarTipoObra(int TipoObra_id)
        {
            using (ServicioTipoObra elTipoObra = new ServicioTipoObra())
            {
                return elTipoObra.InactivarTipoObra(TipoObra_id);
            }
        }

        public string ActivarTipoObra(int TipoObra_id)
        {
            using (ServicioTipoObra elTipoObra = new ServicioTipoObra())
            {
                return elTipoObra.ActivarTipoObra(TipoObra_id);
            }
        }
    }
}

