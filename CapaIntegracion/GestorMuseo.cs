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
    public class GestorMuseo : servicio, IDisposable
    {

        public GestorMuseo()
        {

        }
        public void Dispose()
        {

        }

        //Metodo para Insertar Aula
        public string InsertarMuseo(int TipoMuseo_id, string Museo_nombre,string Museo_instalacion, string Museo_estado)
        {
            Museo nuevoMuseo = new Museo(TipoMuseo_id, Museo_nombre,Museo_instalacion, Museo_estado);
            using (ServicioMuseo elMuseo = new ServicioMuseo())
            {
                return elMuseo.InsertarMuseo(nuevoMuseo);
            }
        }

        //Metodo para Modificar Aula
        public string ModificarMuseo(int Museo_id, int TipoMuseo_id, string Museo_nombre,string Museo_instalacion, string Museo_estado)
        {
            Museo nuevoMuseo = new Museo(Museo_id, TipoMuseo_id, Museo_nombre, Museo_instalacion, Museo_estado);
            using (ServicioMuseo elMuseo = new ServicioMuseo())
            {
                return elMuseo.ModificarMuseo(nuevoMuseo);
            }
        }

        public DataSet ConsultarMuseo(int Museo_id)
        {
            using (ServicioMuseo elMuseo = new ServicioMuseo())
            {
                return elMuseo.ConsultarMuseo(Museo_id);
            }
        }

        public DataTable ListarMuseo()
        {
            using (ServicioMuseo elMuseo = new ServicioMuseo())
            {
                return elMuseo.ListarMuseo();
            }
        }

        public DataTable ListarMuseoInactivo()
        {
            using (ServicioMuseo elMuseo = new ServicioMuseo())
            {
                return elMuseo.ListarMuseoInactivo();
            }
        }

        public string InactivarMuseo(int Museo_id)
        {
            using (ServicioMuseo elMuseo = new ServicioMuseo())
            {
                return elMuseo.InactivarMuseo(Museo_id);
            }
        }

        public string ActivarMuseo(int Museo_id)
        {
            using (ServicioMuseo elMuseo = new ServicioMuseo())
            {
                return elMuseo.ActivarMuseo(Museo_id);
            }
        }
    }

}

