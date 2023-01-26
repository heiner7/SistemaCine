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
    public class ServicioEntrada : servicio, IDisposable//para liberar memoria
    {

        private string respuesta;
        private SqlCommand miComando;

        public ServicioEntrada()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public void Dispose()
        {

        }


        //Metodo para el SP InsertarEntrada
        public string InsertarEntrada(Entrada elEntrada)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Entrada");

            miComando.CommandText = "InsertarEntrada";

            miComando.Parameters.Add("@Museo_id", SqlDbType.Int);
            miComando.Parameters["@Museo_id"].Value = elEntrada.Museo_id;

            miComando.Parameters.Add("@Precio_id", SqlDbType.Int);
            miComando.Parameters["@Precio_id"].Value = elEntrada.Precio_id;

            miComando.Parameters.Add("@Tarjeta_id", SqlDbType.Int);
            miComando.Parameters["@Tarjeta_id"].Value = elEntrada.Tarjeta_id;

            miComando.Parameters.Add("@Entrada_nombreVisitante", SqlDbType.VarChar);
            miComando.Parameters["@Entrada_nombreVisitante"].Value = elEntrada.Entrada_nombreVisitante;

            miComando.Parameters.Add("@Entrada_fecha", SqlDbType.VarChar);
            miComando.Parameters["@Entrada_fecha"].Value = elEntrada.Entrada_fecha;

            miComando.Parameters.Add("@Entrada_cantidad", SqlDbType.Int);
            miComando.Parameters["@Entrada_cantidad"].Value = elEntrada.Entrada_cantidad;

            miComando.Parameters.Add("@Entrada_subtotal", SqlDbType.Float);
            miComando.Parameters["@Entrada_subtotal"].Value = elEntrada.Entrada_subtotal;

            miComando.Parameters.Add("@Entrada_comision", SqlDbType.Float);
            miComando.Parameters["@Entrada_comision"].Value = elEntrada.Entrada_comision;

            miComando.Parameters.Add("@Entrada_total", SqlDbType.Float);
            miComando.Parameters["@Entrada_total"].Value = elEntrada.Entrada_total;

            miComando.Parameters.Add("@Entrada_estado", SqlDbType.VarChar);
            miComando.Parameters["@Entrada_estado"].Value = elEntrada.Entrada_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Insertar Entrada");

            return respuesta;

        }

        //Metodo para el SP ModificarEntrada
        public string ModificarEntrada(Entrada elEntrada)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Entrada");

            miComando.CommandText = "ModificarEntrada";

            miComando.Parameters.Add("@Museo_id", SqlDbType.Int);
            miComando.Parameters["@Museo_id"].Value = elEntrada.Museo_id;

            miComando.Parameters.Add("@Precio_id", SqlDbType.Int);
            miComando.Parameters["@Precio_id"].Value = elEntrada.Precio_id;

            miComando.Parameters.Add("@Entrada_id", SqlDbType.Int);
            miComando.Parameters["@Entrada_id"].Value = elEntrada.Entrada_id;

            miComando.Parameters.Add("@Entrada_nombreVisitante", SqlDbType.VarChar);
            miComando.Parameters["@Entrada_nombreVisitante"].Value = elEntrada.Entrada_nombreVisitante;

            miComando.Parameters.Add("@Entrada_fecha", SqlDbType.VarChar);
            miComando.Parameters["@Entrada_fecha"].Value = elEntrada.Entrada_fecha;

            miComando.Parameters.Add("@Entrada_cantidad", SqlDbType.VarChar);
            miComando.Parameters["@Entrada_cantidad"].Value = elEntrada.Entrada_cantidad;

            miComando.Parameters.Add("@Entrada_subtotal", SqlDbType.VarChar);
            miComando.Parameters["@Entrada_subtotal"].Value = elEntrada.Entrada_subtotal;

            miComando.Parameters.Add("@Entrada_comision", SqlDbType.VarChar);
            miComando.Parameters["@Entrada_comision"].Value = elEntrada.Entrada_comision;

            miComando.Parameters.Add("@Entrada_total", SqlDbType.VarChar);
            miComando.Parameters["@Entrada_total"].Value = elEntrada.Entrada_total;

            miComando.Parameters.Add("@Entrada_estado", SqlDbType.VarChar);
            miComando.Parameters["@Entrada_estado"].Value = elEntrada.Entrada_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Modificar Entrada");

            return respuesta;

        }

        public DataTable ListarEntrada()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ListarEntrada");

            miComando.CommandText = "ListarEntrada";

            DataSet elEntrada = new DataSet();
            this.abrirConexion();
            elEntrada = this.seleccionarInformacion(miComando);
            DataTable miDataTable = elEntrada.Tables[0];
            this.cerrarConexion();

            return miDataTable;
        }

        public DataTable ListarEntradaInactivo()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ListarEntradaInactivo");

            miComando.CommandText = "ListarEntradaInactivo";

            DataSet elEntrada = new DataSet();
            this.abrirConexion();
            elEntrada = this.seleccionarInformacion(miComando);
            DataTable miDataTable = elEntrada.Tables[0];
            this.cerrarConexion();

            return miDataTable;
        }

        public DataSet ConsultarEntrada(int Entrada_id)
        {
            miComando.CommandText = "ConsultarEntrada";

            miComando.Parameters.AddWithValue("@Entrada_id", SqlDbType.Int);
            miComando.Parameters["@Entrada_id"].Value = Entrada_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public string InactivarEntrada(int Entrada_id)
        {
            miComando = new SqlCommand();

            Console.WriteLine("Gestor InactivarEntrada");

            miComando.CommandText = "InactivarEntrada";

            miComando.Parameters.AddWithValue("@Entrada_id", SqlDbType.Int);
            miComando.Parameters["@Entrada_id"].Value = Entrada_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Inactivar Entrada");

            return respuesta;
        }

        public string ActivarEntrada(int Entrada_id)
        {
            miComando = new SqlCommand();

            Console.WriteLine("Gestor ActivarEntrada");

            miComando.CommandText = "ActivarEntrada";

            miComando.Parameters.AddWithValue("@Entrada_id", SqlDbType.Int);
            miComando.Parameters["@Entrada_id"].Value = Entrada_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Activar Entrada");

            return respuesta;
        }

    }
}
