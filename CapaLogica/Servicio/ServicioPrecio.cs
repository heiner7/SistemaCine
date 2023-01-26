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
    public class ServicioPrecio : servicio, IDisposable//para liberar memoria
    {

        private string respuesta;
        private SqlCommand miComando;

        public ServicioPrecio()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public void Dispose()
        {

        }


        //Metodo para el SP InsertarAula
        public string InsertarPrecio(Precio elPrecio)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Precio");

            miComando.CommandText = "InsertarPrecio";

            miComando.Parameters.Add("@Museo_id", SqlDbType.Int);
            miComando.Parameters["@Museo_id"].Value = elPrecio.Museo_id;

            miComando.Parameters.Add("@Precio_modalidad", SqlDbType.VarChar);
            miComando.Parameters["@Precio_modalidad"].Value = elPrecio.Precio_modalidad;

            miComando.Parameters.Add("@Precio_monto", SqlDbType.VarChar);
            miComando.Parameters["@Precio_monto"].Value = elPrecio.Precio_monto;

            miComando.Parameters.Add("@Precio_estado", SqlDbType.VarChar);
            miComando.Parameters["@Precio_estado"].Value = elPrecio.Precio_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Insertar Precio");

            return respuesta;

        }

        //Metodo para el SP ModificarAula
        public string ModificarPrecio(Precio elPrecio)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Precio");

            miComando.CommandText = "ModificarPrecio";

            miComando.Parameters.Add("@Precio_id", SqlDbType.Int);
            miComando.Parameters["@Precio_id"].Value = elPrecio.Precio_id;

            miComando.Parameters.Add("@Museo_id", SqlDbType.Int);
            miComando.Parameters["@Museo_id"].Value = elPrecio.Museo_id;

            miComando.Parameters.Add("@Precio_modalidad", SqlDbType.VarChar);
            miComando.Parameters["@Precio_modalidad"].Value = elPrecio.Precio_modalidad;

            miComando.Parameters.Add("@Precio_monto", SqlDbType.VarChar);
            miComando.Parameters["@Precio_monto"].Value = elPrecio.Precio_monto;

            miComando.Parameters.Add("@Precio_estado", SqlDbType.VarChar);
            miComando.Parameters["@Precio_estado"].Value = elPrecio.Precio_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Modificar Precio");

            return respuesta;

        }

        public DataTable ListarPrecio()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ListarPrecio");

            miComando.CommandText = "ListarPrecio";

            DataSet elPrecio = new DataSet();
            this.abrirConexion();
            elPrecio = this.seleccionarInformacion(miComando);
            DataTable miDataTable = elPrecio.Tables[0];
            this.cerrarConexion();

            return miDataTable;
        }

        public DataTable ListarPrecioInactivo()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ListarPrecioInactivo");

            miComando.CommandText = "ListarPrecioInactivo";

            DataSet elPrecio = new DataSet();
            this.abrirConexion();
            elPrecio = this.seleccionarInformacion(miComando);
            DataTable miDataTable = elPrecio.Tables[0];
            this.cerrarConexion();

            return miDataTable;
        }

        public DataSet ConsultarPrecio(int Precio_id)
        {
            miComando.CommandText = "ConsultarPrecio";

            miComando.Parameters.AddWithValue("@Precio_id", SqlDbType.Int);
            miComando.Parameters["@Precio_id"].Value = Precio_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public string InactivarPrecio(int Precio_id)
        {
            miComando = new SqlCommand();

            Console.WriteLine("Gestor InactivarPrecio");

            miComando.CommandText = "InactivarPrecio";

            miComando.Parameters.AddWithValue("@Precio_id", SqlDbType.Int);
            miComando.Parameters["@Precio_id"].Value = Precio_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Inactivar Precio");

            return respuesta;
        }

        public string ActivarPrecio(int Precio_id)
        {
            miComando = new SqlCommand();

            Console.WriteLine("Gestor ActivarPrecio");

            miComando.CommandText = "ActivarPrecio";

            miComando.Parameters.AddWithValue("@Precio_id", SqlDbType.Int);
            miComando.Parameters["@Precio_id"].Value = Precio_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Activar Precio");

            return respuesta;
        }

    }
}
