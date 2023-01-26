using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bibliotecas SQL
using System.Data;
using System.Data.SqlClient;
//Bibliotecas del sistema
using SistemaMatricula.CapaConexion;
using SistemaMatricula.CapaLogica.LogicaNegocio;

namespace SistemaMatricula.CapaLogica.Servicio
{
    public class ServicioTipoMuseo : servicio, IDisposable//para liberar memoria
    {

        private string respuesta;
        private SqlCommand miComando;

        public ServicioTipoMuseo()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public void Dispose()
        {

        }


        //Metodo para el SP InsertarAula
        public string InsertarTipoMuseo(TipoMuseo elTipoMuseo)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar TipoMuseo");

            miComando.CommandText = "InsertarTipoMuseo";

            miComando.Parameters.Add("@TipoMuseo_tipo", SqlDbType.VarChar);
            miComando.Parameters["@TipoMuseo_tipo"].Value = elTipoMuseo.TipoMuseo_tipo;

            miComando.Parameters.Add("@TipoMuseo_descripcion", SqlDbType.VarChar);
            miComando.Parameters["@TipoMuseo_descripcion"].Value = elTipoMuseo.TipoMuseo_descripcion;

            miComando.Parameters.Add("@TipoMuseo_estado", SqlDbType.VarChar);
            miComando.Parameters["@TipoMuseo_estado"].Value = elTipoMuseo.TipoMuseo_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Insertar TipoMuseo");

            return respuesta;

        }

        //Metodo para el SP ModificarAula
        public string ModificarTipoMuseo(TipoMuseo elTipoMuseo)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar TipoMuseo");

            miComando.CommandText = "ModificarTipoMuseo";

            miComando.Parameters.Add("@TipoMuseo_id", SqlDbType.Int);
            miComando.Parameters["@TipoMuseo_id"].Value = elTipoMuseo.TipoMuseo_id;

            miComando.Parameters.Add("@TipoMuseo_tipo", SqlDbType.VarChar);
            miComando.Parameters["@TipoMuseo_tipo"].Value = elTipoMuseo.TipoMuseo_tipo;

            miComando.Parameters.Add("@TipoMuseo_descripcion", SqlDbType.VarChar);
            miComando.Parameters["@TipoMuseo_descripcion"].Value = elTipoMuseo.TipoMuseo_descripcion;

            miComando.Parameters.Add("@TipoMuseo_estado", SqlDbType.VarChar);
            miComando.Parameters["@TipoMuseo_estado"].Value = elTipoMuseo.TipoMuseo_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Insertar TipoMuseo");

            return respuesta;
        }

        public DataTable ListarTipoMuseo()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ListarTipoMuseo");

            miComando.CommandText = "ListarTipoMuseo";

            DataSet elTipoMuseo = new DataSet();
            this.abrirConexion();
            elTipoMuseo = this.seleccionarInformacion(miComando);
            DataTable miDataTable = elTipoMuseo.Tables[0];
            this.cerrarConexion();

            return miDataTable;
        }

        public DataTable ListarTipoMuseoInactivo()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ListarTipoMuseoInactivo");

            miComando.CommandText = "ListarTipoMuseoInactivo";

            DataSet elTipoMuseo = new DataSet();
            this.abrirConexion();
            elTipoMuseo = this.seleccionarInformacion(miComando);
            DataTable miDataTable = elTipoMuseo.Tables[0];
            this.cerrarConexion();

            return miDataTable;
        }

        public DataSet ConsultarTipoMuseo(int TipoMuseo_id)
        {
            miComando.CommandText = "ConsultarTipoMuseo";

            miComando.Parameters.AddWithValue("@TipoMuseo_id", SqlDbType.Int);
            miComando.Parameters["@TipoMuseo_id"].Value = TipoMuseo_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public string InactivarTipoMuseo(int TipoMuseo_id)
        {
            miComando = new SqlCommand();

            Console.WriteLine("Gestor InactivarTipoMuseo");

            miComando.CommandText = "InactivarTipoMuseo";

            miComando.Parameters.AddWithValue("@TipoMuseo_id", SqlDbType.Int);
            miComando.Parameters["@TipoMuseo_id"].Value = TipoMuseo_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Inactivar TipoMuseo");

            return respuesta;
        }

        public string ActivarTipoMuseo(int TipoMuseo_id)
        {
            miComando = new SqlCommand();

            Console.WriteLine("Gestor ActivarTipoMuseo");

            miComando.CommandText = "ActivarTipoMuseo";

            miComando.Parameters.AddWithValue("@TipoMuseo_id", SqlDbType.Int);
            miComando.Parameters["@TipoMuseo_id"].Value = TipoMuseo_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Activar TipoMuseo");

            return respuesta;
        }
    }
}
