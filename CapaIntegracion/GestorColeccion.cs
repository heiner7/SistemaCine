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
    public class GestorColeccion : servicio, IDisposable
    {

        public GestorColeccion()
        {

        }
        public void Dispose()
        {

        }

        //Metodo para Insertar Coleccion
        public string InsertarColeccion(int Museo_id, string Coleccion_nombre, string Coleccion_siglo, string Coleccion_observaciones, string Coleccion_estado)
        {
            Coleccion nuevoColeccion = new Coleccion(Museo_id, Coleccion_nombre, Coleccion_siglo, Coleccion_observaciones, Coleccion_estado);
            using (ServicioColeccion elColeccion = new ServicioColeccion())
            {
                return elColeccion.InsertarColeccion(nuevoColeccion);
            }
        }

        //Metodo para Modificar Coleccion
        public string ModificarColeccion(int Coleccion_id, int Museo_id, string Coleccion_nombre, string Coleccion_siglo, string Coleccion_observaciones, string Coleccion_estado)
        {
            Coleccion nuevoColeccion = new Coleccion(Coleccion_id, Museo_id, Coleccion_nombre, Coleccion_siglo, Coleccion_observaciones, Coleccion_estado);
            using (ServicioColeccion elColeccion = new ServicioColeccion())
            {
                return elColeccion.ModificarColeccion(nuevoColeccion);
            }
        }

        public DataSet ConsultarColeccion(int Coleccion_id)
        {
            using (ServicioColeccion elColeccion = new ServicioColeccion())
            {
                return elColeccion.ConsultarColeccion(Coleccion_id);
            }
        }

        public DataTable ListarColeccion()
        {
            using (ServicioColeccion elColeccion = new ServicioColeccion())
            {
                return elColeccion.ListarColeccion();
            }
        }

        public DataTable ListarColeccionInactivo()
        {
            using (ServicioColeccion elColeccion = new ServicioColeccion())
            {
                return elColeccion.ListarColeccionInactivo();
            }
        }

        public string InactivarColeccion(int Coleccion_id)
        {
            using (ServicioColeccion elColeccion = new ServicioColeccion())
            {
                return elColeccion.InactivarColeccion(Coleccion_id);
            }
        }

        public string ActivarColeccion(int Coleccion_id)
        {
            using (ServicioColeccion elColeccion = new ServicioColeccion())
            {
                return elColeccion.ActivarColeccion(Coleccion_id);
            }
        }

    }
}
