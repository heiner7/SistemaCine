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
    public class ServicioArtista : servicio, IDisposable//para liberar memoria
    {

        private string respuesta;
        private SqlCommand miComando;

        public ServicioArtista()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public void Dispose()
        {

        }

        //Metodo para el SP InsertarAula
        public string InsertarArtista(Artista elArtista)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Artista");

            miComando.CommandText = "InsertarArtista";

            miComando.Parameters.Add("@Artista_nacionalidad", SqlDbType.VarChar);
            miComando.Parameters["@Artista_nacionalidad"].Value = elArtista.Artista_nacionalidad;

            miComando.Parameters.Add("@Artista_nombre", SqlDbType.VarChar);
            miComando.Parameters["@Artista_nombre"].Value = elArtista.Artista_nombre;

            miComando.Parameters.Add("@Artista_biografia", SqlDbType.VarChar);
            miComando.Parameters["@Artista_biografia"].Value = elArtista.Artista_biografia;

            miComando.Parameters.Add("@Artista_estado", SqlDbType.VarChar);
            miComando.Parameters["@Artista_estado"].Value = elArtista.Artista_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Insertar Obra");

            return respuesta;

        }

        //Metodo para el SP ModificarArtista
        public string ModificarArtista(Artista elArtista)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Artista");

            miComando.CommandText = "ModificarArtista";

            miComando.Parameters.Add("@Artista_id", SqlDbType.Int);
            miComando.Parameters["@Artista_id"].Value = elArtista.Artista_id;

            miComando.Parameters.Add("@Artista_nacionalidad", SqlDbType.VarChar);
            miComando.Parameters["@Artista_nacionalidad"].Value = elArtista.Artista_nacionalidad;

            miComando.Parameters.Add("@Artista_nombre", SqlDbType.VarChar);
            miComando.Parameters["@Artista_nombre"].Value = elArtista.Artista_nombre;

            miComando.Parameters.Add("@Artista_biografia", SqlDbType.VarChar);
            miComando.Parameters["@Artista_biografia"].Value = elArtista.Artista_biografia;

            miComando.Parameters.Add("@Artista_estado", SqlDbType.VarChar);
            miComando.Parameters["@Artista_estado"].Value = elArtista.Artista_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Modificar Obra");

            return respuesta;

        }

        public DataTable ListarArtista()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ListarArtista");

            miComando.CommandText = "ListarArtista";

            DataSet elArtista = new DataSet();
            this.abrirConexion();
            elArtista = this.seleccionarInformacion(miComando);
            DataTable miDataTable = elArtista.Tables[0];
            this.cerrarConexion();

            return miDataTable;
        }

        public DataTable ListarArtistaInactivo()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ListarArtistaInactivo");

            miComando.CommandText = "ListarArtistaInactivo";

            DataSet elArtista = new DataSet();
            this.abrirConexion();
            elArtista = this.seleccionarInformacion(miComando);
            DataTable miDataTable = elArtista.Tables[0];
            this.cerrarConexion();

            return miDataTable;
        }

        public DataSet ConsultarArtista(int Artista_id)
        {
            miComando.CommandText = "ConsultarArtista";

            miComando.Parameters.AddWithValue("@Artista_id", SqlDbType.Int);
            miComando.Parameters["@Artista_id"].Value = Artista_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public string InactivarArtista(int Artista_id)
        {
            miComando = new SqlCommand();

            Console.WriteLine("Gestor InactivarArtista");

            miComando.CommandText = "InactivarArtista";

            miComando.Parameters.AddWithValue("@Artista_id", SqlDbType.Int);
            miComando.Parameters["@Artista_id"].Value = Artista_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Inactivar Artista");

            return respuesta;
        }

        public string ActivarArtista(int Artista_id)
        {
            miComando = new SqlCommand();

            Console.WriteLine("Gestor ActivarArtista");

            miComando.CommandText = "ActivarArtista";

            miComando.Parameters.AddWithValue("@Artista_id", SqlDbType.Int);
            miComando.Parameters["@Artista_id"].Value = Artista_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Activar Artista");

            return respuesta;
        }
    }

}

