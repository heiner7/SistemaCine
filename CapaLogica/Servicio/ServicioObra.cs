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
    public class ServicioObra : servicio, IDisposable//para liberar memoria
    {

        private string respuesta;
        private SqlCommand miComando;

        public ServicioObra()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public void Dispose()
        {

        }

        //Metodo para el SP InsertarObra
        public string InsertarObra(Obra elObra)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Obra");

            miComando.CommandText = "InsertarObra";

            miComando.Parameters.Add("@Artista_id", SqlDbType.Int);
            miComando.Parameters["@Artista_id"].Value = elObra.Artista_id;

            miComando.Parameters.Add("@Coleccion_id", SqlDbType.Int);
            miComando.Parameters["@Coleccion_id"].Value = elObra.Coleccion_id;

            miComando.Parameters.Add("@TipoObra_id", SqlDbType.Int);
            miComando.Parameters["@TipoObra_id"].Value = elObra.TipoObra_id;

            miComando.Parameters.Add("@Obra_nombre", SqlDbType.VarChar);
            miComando.Parameters["@Obra_nombre"].Value = elObra.Obra_nombre;

            miComando.Parameters.Add("@Obra_descripcion", SqlDbType.VarChar);
            miComando.Parameters["@Obra_descripcion"].Value = elObra.Obra_descripcion;

            miComando.Parameters.Add("@Obra_cultura", SqlDbType.VarChar);
            miComando.Parameters["@Obra_cultura"].Value = elObra.Obra_cultura;

            miComando.Parameters.Add("@Obra_estado", SqlDbType.VarChar);
            miComando.Parameters["@Obra_estado"].Value = elObra.Obra_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Insertar Obra");

            return respuesta;

        }

        //Metodo para el SP ModificarObra
        public string ModificarObra(Obra elObra)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Obra");

            miComando.CommandText = "ModificarObra";

            miComando.Parameters.Add("@Obra_id", SqlDbType.Int);
            miComando.Parameters["@Obra_id"].Value = elObra.Obra_id;

            miComando.Parameters.Add("@Artista_id", SqlDbType.Int);
            miComando.Parameters["@Artista_id"].Value = elObra.Artista_id;

            miComando.Parameters.Add("@Coleccion_id", SqlDbType.Int);
            miComando.Parameters["@Coleccion_id"].Value = elObra.Coleccion_id;

            miComando.Parameters.Add("@TipoObra_id", SqlDbType.Int);
            miComando.Parameters["@TipoObra_id"].Value = elObra.TipoObra_id;

            miComando.Parameters.Add("@Obra_nombre", SqlDbType.VarChar);
            miComando.Parameters["@Obra_nombre"].Value = elObra.Obra_nombre;

            miComando.Parameters.Add("@Obra_descripcion", SqlDbType.VarChar);
            miComando.Parameters["@Obra_descripcion"].Value = elObra.Obra_descripcion;

            miComando.Parameters.Add("@Obra_cultura", SqlDbType.VarChar);
            miComando.Parameters["@Obra_cultura"].Value = elObra.Obra_cultura;

            miComando.Parameters.Add("@Obra_estado", SqlDbType.VarChar);
            miComando.Parameters["@Obra_estado"].Value = elObra.Obra_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Modificar Obra");

            return respuesta;

        }

        public DataTable ListarObra()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ListarObra");

            miComando.CommandText = "ListarObra";

            DataSet elObra = new DataSet();
            this.abrirConexion();
            elObra = this.seleccionarInformacion(miComando);
            DataTable miDataTable = elObra.Tables[0];
            this.cerrarConexion();

            return miDataTable;
        }

        public DataTable ListarObraInactivo()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ListarObraInactivo");

            miComando.CommandText = "ListarObraInactivo";

            DataSet elObra = new DataSet();
            this.abrirConexion();
            elObra = this.seleccionarInformacion(miComando);
            DataTable miDataTable = elObra.Tables[0];
            this.cerrarConexion();

            return miDataTable;
        }

        public DataSet ConsultarObra(int Obra_id)
        {
            miComando.CommandText = "ConsultarObra";

            miComando.Parameters.AddWithValue("@Obra_id", SqlDbType.Int);
            miComando.Parameters["@Obra_id"].Value = Obra_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public string InactivarObra(int Obra_id)
        {
            miComando = new SqlCommand();

            Console.WriteLine("Gestor InactivarObra");

            miComando.CommandText = "InactivarObra";

            miComando.Parameters.AddWithValue("@Obra_id", SqlDbType.Int);
            miComando.Parameters["@Obra_id"].Value = Obra_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Inactivar Obra");

            return respuesta;
        }

        public string ActivarObra(int Obra_id)
        {
            miComando = new SqlCommand();

            Console.WriteLine("Gestor ActivarObra");

            miComando.CommandText = "ActivarObra";

            miComando.Parameters.AddWithValue("@Obra_id", SqlDbType.Int);
            miComando.Parameters["@Obra_id"].Value = Obra_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Activar Obra");

            return respuesta;
        }
    }
}
