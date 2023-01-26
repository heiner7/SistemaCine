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
    public class ServicioMuseo : servicio, IDisposable//para liberar memoria
    {

        private string respuesta;
        private SqlCommand miComando;

        public ServicioMuseo()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public void Dispose()
        {

        }


        //Metodo para el SP InsertarAula
        public string InsertarMuseo(Museo elMuseo)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Museo");

            miComando.CommandText = "InsertarMuseo";

            miComando.Parameters.Add("@TipoMuseo_id", SqlDbType.Int);
            miComando.Parameters["@TipoMuseo_id"].Value = elMuseo.TipoMuseo_id;

            miComando.Parameters.Add("@Museo_nombre", SqlDbType.VarChar);
            miComando.Parameters["@Museo_nombre"].Value = elMuseo.Museo_nombre;

            miComando.Parameters.Add("@Museo_instalacion", SqlDbType.VarChar);
            miComando.Parameters["@Museo_instalacion"].Value = elMuseo.Museo_instalacion;

            miComando.Parameters.Add("@Museo_estado", SqlDbType.VarChar);
            miComando.Parameters["@Museo_estado"].Value = elMuseo.Museo_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Insertar Museo");

            return respuesta;

        }

        //Metodo para el SP ModificarAula
        public string ModificarMuseo(Museo elMuseo)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Museo");

            miComando.CommandText = "ModificarMuseo";

            miComando.Parameters.Add("@Museo_id", SqlDbType.Int);
            miComando.Parameters["@Museo_id"].Value = elMuseo.Museo_id;

            miComando.Parameters.Add("@TipoMuseo_id", SqlDbType.Int);
            miComando.Parameters["@TipoMuseo_id"].Value = elMuseo.TipoMuseo_id;

            miComando.Parameters.Add("@Museo_nombre", SqlDbType.VarChar);
            miComando.Parameters["@Museo_nombre"].Value = elMuseo.Museo_nombre;

            miComando.Parameters.Add("@Museo_instalacion", SqlDbType.VarChar);
            miComando.Parameters["@Museo_instalacion"].Value = elMuseo.Museo_instalacion;

            miComando.Parameters.Add("@Museo_estado", SqlDbType.VarChar);
            miComando.Parameters["@Museo_estado"].Value = elMuseo.Museo_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Modificar Museo");

            return respuesta;

        }

        public DataTable ListarMuseo()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ListarMuseo");

            miComando.CommandText = "ListarMuseo";

            DataSet elAula = new DataSet();
            this.abrirConexion();
            elAula = this.seleccionarInformacion(miComando);
            DataTable miDataTable = elAula.Tables[0];
            this.cerrarConexion();

            return miDataTable;
        }

        public DataTable ListarMuseoInactivo()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ListarMuseoInactivo");

            miComando.CommandText = "ListarMuseoInactivo";

            DataSet elMuseo = new DataSet();
            this.abrirConexion();
            elMuseo = this.seleccionarInformacion(miComando);
            DataTable miDataTable = elMuseo.Tables[0];
            this.cerrarConexion();

            return miDataTable;
        }

        public DataSet ConsultarMuseo(int Museo_id)
        {
            miComando.CommandText = "ConsultarMuseo";

            miComando.Parameters.AddWithValue("@Museo_id", SqlDbType.Int);
            miComando.Parameters["@Museo_id"].Value = Museo_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public string InactivarMuseo(int Museo_id)
        {
            miComando = new SqlCommand();

            Console.WriteLine("Gestor InactivarMuseo");

            miComando.CommandText = "InactivarMuseo";

            miComando.Parameters.AddWithValue("@Museo_id", SqlDbType.Int);
            miComando.Parameters["@Museo_id"].Value = Museo_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Inactivar Museo");

            return respuesta;
        }

        public string ActivarMuseo(int Museo_id)
        {
            miComando = new SqlCommand();

            Console.WriteLine("Gestor ActivarMuseo");

            miComando.CommandText = "ActivarMuseo";

            miComando.Parameters.AddWithValue("@Museo_id", SqlDbType.Int);
            miComando.Parameters["@Museo_id"].Value = Museo_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Activar Museo");

            return respuesta;
        }
    }

}

