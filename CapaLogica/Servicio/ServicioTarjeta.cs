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
    public class ServicioTarjeta : servicio, IDisposable//para liberar memoria
    {

        private string respuesta;
        private SqlCommand miComando;

        public ServicioTarjeta()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public void Dispose()
        {

        }


        //Metodo para el SP InsertarTarjeta
        public string InsertarTarjeta(Tarjeta elTarjeta)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Tarjeta");

            miComando.CommandText = "InsertarTarjeta";

            miComando.Parameters.Add("@Tarjeta_nombre", SqlDbType.VarChar);
            miComando.Parameters["@Tarjeta_nombre"].Value = elTarjeta.Tarjeta_nombre;

            miComando.Parameters.Add("@Tarjeta_porcentaje", SqlDbType.VarChar);
            miComando.Parameters["@Tarjeta_porcentaje"].Value = elTarjeta.Tarjeta_porcentaje;

            miComando.Parameters.Add("@Tarjeta_estado", SqlDbType.VarChar);
            miComando.Parameters["@Tarjeta_estado"].Value = elTarjeta.Tarjeta_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Insertar Tarjeta");

            return respuesta;

        }

        //Metodo para el SP ModificarTarjeta
        public string ModificarTarjeta(Tarjeta elTarjeta)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Tarjeta");

            miComando.CommandText = "ModificarTarjeta";

            miComando.Parameters.Add("@Tarjeta_id", SqlDbType.Int);
            miComando.Parameters["@Tarjeta_id"].Value = elTarjeta.Tarjeta_id;

            miComando.Parameters.Add("@Tarjeta_nombre", SqlDbType.VarChar);
            miComando.Parameters["@Tarjeta_nombre"].Value = elTarjeta.Tarjeta_nombre;

            miComando.Parameters.Add("@Tarjeta_porcentaje", SqlDbType.VarChar);
            miComando.Parameters["@Tarjeta_porcentaje"].Value = elTarjeta.Tarjeta_porcentaje;

            miComando.Parameters.Add("@Tarjeta_estado", SqlDbType.VarChar);
            miComando.Parameters["@Tarjeta_estado"].Value = elTarjeta.Tarjeta_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Modificar Tarjeta");

            return respuesta;

        }

        public DataTable ListarTarjeta()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ListarTarjeta");

            miComando.CommandText = "ListarTarjeta";

            DataSet elTarjeta = new DataSet();
            this.abrirConexion();
            elTarjeta = this.seleccionarInformacion(miComando);
            DataTable miDataTable = elTarjeta.Tables[0];
            this.cerrarConexion();

            return miDataTable;
        }

        public DataTable ListarTarjetaInactivo()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ListarTarjetaInactivo");

            miComando.CommandText = "ListarTarjetaInactivo";

            DataSet elTarjeta = new DataSet();
            this.abrirConexion();
            elTarjeta = this.seleccionarInformacion(miComando);
            DataTable miDataTable = elTarjeta.Tables[0];
            this.cerrarConexion();

            return miDataTable;
        }

        public DataSet ConsultarTarjeta(int Tarjeta_id)
        {
            miComando.CommandText = "ConsultarTarjeta";

            miComando.Parameters.AddWithValue("@Tarjeta_id", SqlDbType.Int);
            miComando.Parameters["@Tarjeta_id"].Value = Tarjeta_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public string InactivarTarjeta(int Museo_id)
        {
            miComando = new SqlCommand();

            Console.WriteLine("Gestor InactivarTarjeta");

            miComando.CommandText = "InactivarTarjeta";

            miComando.Parameters.AddWithValue("@Tarjeta_id", SqlDbType.Int);
            miComando.Parameters["@Tarjeta_id"].Value = Museo_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Inactivar Tarjeta");

            return respuesta;
        }

        public string ActivarTarjeta(int Tarjeta_id)
        {
            miComando = new SqlCommand();

            Console.WriteLine("Gestor ActivarTarjeta");

            miComando.CommandText = "ActivarTarjeta";

            miComando.Parameters.AddWithValue("@Tarjeta_id", SqlDbType.Int);
            miComando.Parameters["@Tarjeta_id"].Value = Tarjeta_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Activar Tarjeta");

            return respuesta;
        }

    }
}
