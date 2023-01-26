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
    public class ServicioColeccion : servicio, IDisposable//para liberar memoria
    {

        private string respuesta;
        private SqlCommand miComando;

        public ServicioColeccion()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public void Dispose()
        {

        }

        //Metodo para el SP InsertarColeccion
        public string InsertarColeccion(Coleccion elColeccion)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Coleccion");

            miComando.CommandText = "InsertarColeccion";

            miComando.Parameters.Add("@Museo_id", SqlDbType.Int);
            miComando.Parameters["@Museo_id"].Value = elColeccion.Museo_id;

            miComando.Parameters.Add("@Coleccion_nombre", SqlDbType.VarChar);
            miComando.Parameters["@Coleccion_nombre"].Value = elColeccion.Coleccion_nombre;

            miComando.Parameters.Add("@Coleccion_siglo", SqlDbType.VarChar);
            miComando.Parameters["@Coleccion_siglo"].Value = elColeccion.Coleccion_siglo;

            miComando.Parameters.Add("@Coleccion_observaciones", SqlDbType.VarChar);
            miComando.Parameters["@Coleccion_observaciones"].Value = elColeccion.Coleccion_observaciones;

            miComando.Parameters.Add("@Coleccion_estado", SqlDbType.VarChar);
            miComando.Parameters["@Coleccion_estado"].Value = elColeccion.Coleccion_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Insertar Coleccion");

            return respuesta;

        }

        //Metodo para el SP ModificarColeccion
        public string ModificarColeccion(Coleccion elColeccion)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Coleccion");

            miComando.CommandText = "ModificarColeccion";

            miComando.Parameters.Add("@Coleccion_id", SqlDbType.Int);
            miComando.Parameters["@Coleccion_id"].Value = elColeccion.Coleccion_id;

            miComando.Parameters.Add("@Museo_id", SqlDbType.Int);
            miComando.Parameters["@Museo_id"].Value = elColeccion.Museo_id;

            miComando.Parameters.Add("@Coleccion_nombre", SqlDbType.VarChar);
            miComando.Parameters["@Coleccion_nombre"].Value = elColeccion.Coleccion_nombre;

            miComando.Parameters.Add("@Coleccion_siglo", SqlDbType.VarChar);
            miComando.Parameters["@Coleccion_siglo"].Value = elColeccion.Coleccion_siglo;

            miComando.Parameters.Add("@Coleccion_observaciones", SqlDbType.VarChar);
            miComando.Parameters["@Coleccion_observaciones"].Value = elColeccion.Coleccion_observaciones;

            miComando.Parameters.Add("@Coleccion_estado", SqlDbType.VarChar);
            miComando.Parameters["@Coleccion_estado"].Value = elColeccion.Coleccion_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Modificar Coleccion");

            return respuesta;

        }

        public DataTable ListarColeccion()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ListarColeccion");

            miComando.CommandText = "ListarColeccion";

            DataSet elColeccion = new DataSet();
            this.abrirConexion();
            elColeccion = this.seleccionarInformacion(miComando);
            DataTable miDataTable = elColeccion.Tables[0];
            this.cerrarConexion();

            return miDataTable;
        }

        public DataTable ListarColeccionInactivo()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ListarColeccionInactivo");

            miComando.CommandText = "ListarColeccionInactivo";

            DataSet elColeccion = new DataSet();
            this.abrirConexion();
            elColeccion = this.seleccionarInformacion(miComando);
            DataTable miDataTable = elColeccion.Tables[0];
            this.cerrarConexion();

            return miDataTable;
        }

        public DataSet ConsultarColeccion(int Coleccion_id)
        {
            miComando.CommandText = "ConsultarColeccion";

            miComando.Parameters.AddWithValue("@Coleccion_id", SqlDbType.Int);
            miComando.Parameters["@Coleccion_id"].Value = Coleccion_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public string InactivarColeccion(int Coleccion_id)
        {
            miComando = new SqlCommand();

            Console.WriteLine("Gestor InactivarColeccion");

            miComando.CommandText = "InactivarColeccion";

            miComando.Parameters.AddWithValue("@Coleccion_id", SqlDbType.Int);
            miComando.Parameters["@Coleccion_id"].Value = Coleccion_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Inactivar Coleccion");

            return respuesta;
        }

        public string ActivarColeccion(int Coleccion_id)
        {
            miComando = new SqlCommand();

            Console.WriteLine("Gestor ActivarColeccion");

            miComando.CommandText = "ActivarColeccion";

            miComando.Parameters.AddWithValue("@Coleccion_id", SqlDbType.Int);
            miComando.Parameters["@Coleccion_id"].Value = Coleccion_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Activar Coleccion");

            return respuesta;
        }

    }
}
