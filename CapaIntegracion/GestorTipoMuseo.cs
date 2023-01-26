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
    public class GestorTipoMuseo : servicio, IDisposable
    {

        public GestorTipoMuseo()
        {

        }
        public void Dispose()
        {

        }

        //Metodo para Insertar TipoMuseo
        public string InsertarTipoMuseo(string TipoMuseo_tipo, string TipoMuseo_descripcion, string TipoMuseo_estado)
        {
            TipoMuseo nuevoTipoMuseo = new TipoMuseo(TipoMuseo_tipo, TipoMuseo_descripcion, TipoMuseo_estado);
            using (ServicioTipoMuseo elTipoMuseo = new ServicioTipoMuseo())
            {
                return elTipoMuseo.InsertarTipoMuseo(nuevoTipoMuseo);
            }
        }

        //Metodo para Modificar TipoMuseo
        public string ModificarTipoMuseo(int TipoMuseo_id, string PtipoMuseo_tipo, string TipoMuseo_descripcion, string TipoMuseo_estado)
        {
            TipoMuseo nuevoTipoMuseo = new TipoMuseo(TipoMuseo_id, PtipoMuseo_tipo, TipoMuseo_descripcion, TipoMuseo_estado);
            using (ServicioTipoMuseo elTipoMuseo = new ServicioTipoMuseo())
            {
                return elTipoMuseo.ModificarTipoMuseo(nuevoTipoMuseo);
            }
        }

        public DataSet ConsultarTipoMuseo(int TipoMuseo_id)
        {
            using (ServicioTipoMuseo elTipoMuseo = new ServicioTipoMuseo())
            {
                return elTipoMuseo.ConsultarTipoMuseo(TipoMuseo_id);
            }
        }

        public DataTable ListarTipoMuseo()
        {
            using (ServicioTipoMuseo elTipoMuseo = new ServicioTipoMuseo())
            {
                return elTipoMuseo.ListarTipoMuseo();
            }
        }

        public DataTable ListarTipoMuseoInactivo()
        {
            using (ServicioTipoMuseo elTipoMuseo = new ServicioTipoMuseo())
            {
                return elTipoMuseo.ListarTipoMuseoInactivo();
            }
        }

        public string InactivarTipoMuseo(int TipoMuseo_id)
        {
            using (ServicioTipoMuseo elTipoMuseo = new ServicioTipoMuseo())
            {
                return elTipoMuseo.InactivarTipoMuseo(TipoMuseo_id);
            }
        }

        public string ActivarTipoMuseo(int TipoMuseo_id)
        {
            using (ServicioTipoMuseo elTipoMuseo = new ServicioTipoMuseo())
            {
                return elTipoMuseo.ActivarTipoMuseo(TipoMuseo_id);
            }
        }

    }
}
