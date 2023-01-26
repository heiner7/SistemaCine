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
    public class ServicioTipoObra : servicio, IDisposable//para liberar memoria
    {

        private string respuesta;
        private SqlCommand miComando;

        public ServicioTipoObra()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public void Dispose()
        {

        }

        //Metodo para el SP InsertarTipoObra
        public string InsertarTipoObra(TipoObra elTipoObra)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar TipoObra");

            miComando.CommandText = "InsertarTipoObra";

            miComando.Parameters.Add("@TipoObra_tipoObra", SqlDbType.VarChar);
            miComando.Parameters["@TipoObra_tipoObra"].Value = elTipoObra.TipoObra_tipoObra;

            miComando.Parameters.Add("@TipoObra_descripcion", SqlDbType.VarChar);
            miComando.Parameters["@TipoObra_descripcion"].Value = elTipoObra.TipoObra_descripcion;

            miComando.Parameters.Add("@TipoObra_estado", SqlDbType.VarChar);
            miComando.Parameters["@TipoObra_estado"].Value = elTipoObra.TipoObra_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Insertar TipoObra");

            return respuesta;

        }

        //Metodo para el SP ModificarTipoObra
        public string ModificarTipoObra(TipoObra elTipoObra)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar TipoObra");

            miComando.CommandText = "ModificarTipoObra";

            miComando.Parameters.Add("@TipoObra_id", SqlDbType.Int);
            miComando.Parameters["@TipoObra_id"].Value = elTipoObra.TipoObra_id;

            miComando.Parameters.Add("@TipoObra_tipoObra", SqlDbType.VarChar);
            miComando.Parameters["@TipoObra_tipoObra"].Value = elTipoObra.TipoObra_tipoObra;

            miComando.Parameters.Add("@TipoObra_descripcion", SqlDbType.VarChar);
            miComando.Parameters["@TipoObra_descripcion"].Value = elTipoObra.TipoObra_descripcion;

            miComando.Parameters.Add("@TipoObra_estado", SqlDbType.VarChar);
            miComando.Parameters["@TipoObra_estado"].Value = elTipoObra.TipoObra_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Modificar TipoObra");

            return respuesta;

        }

        public DataTable ListarTipoObra()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ListarTipoObra");

            miComando.CommandText = "ListarTipoObra";

            DataSet elTipoObra = new DataSet();
            this.abrirConexion();
            elTipoObra = this.seleccionarInformacion(miComando);
            DataTable miDataTable = elTipoObra.Tables[0];
            this.cerrarConexion();

            return miDataTable;
        }
        public DataTable ListarTipoObraInactivo()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ListarTipoObraInactivo");

            miComando.CommandText = "ListarTipoObraInactivo";

            DataSet elTipoObra = new DataSet();
            this.abrirConexion();
            elTipoObra = this.seleccionarInformacion(miComando);
            DataTable miDataTable = elTipoObra.Tables[0];
            this.cerrarConexion();

            return miDataTable;
        }

        public DataSet ConsultarTipoObra(int TipoObra_id)
        {
            miComando.CommandText = "ConsultarTipoObra";

            miComando.Parameters.AddWithValue("@TipoObra_id", SqlDbType.Int);
            miComando.Parameters["@TipoObra_id"].Value = TipoObra_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public string InactivarTipoObra(int TipoObra_id)
        {
            miComando = new SqlCommand();

            Console.WriteLine("Gestor InactivarTipoObra");

            miComando.CommandText = "InactivarTipoObra";

            miComando.Parameters.AddWithValue("@TipoObra_id", SqlDbType.Int);
            miComando.Parameters["@TipoObra_id"].Value = TipoObra_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Inactivar TipoObra");

            return respuesta;
        }

        public string ActivarTipoObra(int TipoObra_id)
        {
            miComando = new SqlCommand();

            Console.WriteLine("Gestor ActivarTipoObra");

            miComando.CommandText = "ActivarTipoObra";

            miComando.Parameters.AddWithValue("@TipoObra_id", SqlDbType.Int);
            miComando.Parameters["@TipoObra_id"].Value = TipoObra_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Activar TipoObra");

            return respuesta;
        }
    }
}

