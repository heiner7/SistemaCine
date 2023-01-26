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
    public class ServicioImagen : servicio, IDisposable//para liberar memoria
    {

        private string respuesta;
        private SqlCommand miComando;

        public ServicioImagen()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public void Dispose()
        {

        }

        //Metodo para el SP InsertarAula
        public string InsertarImagen(Imagen elImagen)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Imagen");

            miComando.CommandText = "InsertarImagen";

            miComando.Parameters.Add("@Obra_id", SqlDbType.Int);
            miComando.Parameters["@Obra_id"].Value = elImagen.Obras_id;

            miComando.Parameters.Add("@Imagen_ubicacion", SqlDbType.Image);
            miComando.Parameters["@Imagen_ubicacion"].Value = elImagen.Imagen_ubicacion;

            miComando.Parameters.Add("@Imagen_estado", SqlDbType.VarChar);
            miComando.Parameters["@Imagen_estado"].Value = elImagen.Imagen_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Insertar Imagen");

            return respuesta;

        }

        //Metodo para el SP InsertarAula
        public string ModificarImagen(Imagen elImagen)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Imagen");

            miComando.CommandText = "ModificarImagen";

            miComando.Parameters.Add("@Imagen_id", SqlDbType.Int);
            miComando.Parameters["@Imagen_id"].Value = elImagen.Imagen_id;

            miComando.Parameters.Add("@Obra_id", SqlDbType.Int);
            miComando.Parameters["@Obra_id"].Value = elImagen.Obras_id;

            miComando.Parameters.Add("@Imagen_ubicacion", SqlDbType.Image);
            miComando.Parameters["@Imagen_ubicacion"].Value = elImagen.Imagen_ubicacion;

            miComando.Parameters.Add("@Imagen_estado", SqlDbType.VarChar);
            miComando.Parameters["@Imagen_estado"].Value = elImagen.Imagen_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Modicicar Imagen");

            return respuesta;

        }

        public DataSet ConsultarImagen(int Imagen_id)
        {
            miComando.CommandText = "ConsultarImagen";

            miComando.Parameters.AddWithValue("@Imagen_id", SqlDbType.Int);
            miComando.Parameters["@Imagen_id"].Value = Imagen_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public DataTable ListarImagen()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ListarImagen");

            miComando.CommandText = "ListarImagen";

            DataSet elImagen = new DataSet();
            this.abrirConexion();
            elImagen = this.seleccionarInformacion(miComando);
            DataTable miDataTable = elImagen.Tables[0];
            this.cerrarConexion();

            return miDataTable;
        }

        public DataTable ListarImagenInactivo()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ListarImagenInactivo");

            miComando.CommandText = "ListarImagenInactivo";

            DataSet elImagen = new DataSet();
            this.abrirConexion();
            elImagen = this.seleccionarInformacion(miComando);
            DataTable miDataTable = elImagen.Tables[0];
            this.cerrarConexion();

            return miDataTable;
        }


        public string InactivarImagen(int Imagen_id)
        {
            miComando = new SqlCommand();

            Console.WriteLine("Gestor InactivarImagen");

            miComando.CommandText = "InactivarImagen";

            miComando.Parameters.AddWithValue("@Imagen_id", SqlDbType.Int);
            miComando.Parameters["@Imagen_id"].Value = Imagen_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Inactivar Imagen");

            return respuesta;
        }

        public string ActivarImagen(int Imagen_id)
        {
            miComando = new SqlCommand();

            Console.WriteLine("Gestor ActivarImagen");

            miComando.CommandText = "ActivarImagen";

            miComando.Parameters.AddWithValue("@Imagen_id", SqlDbType.Int);
            miComando.Parameters["@Imagen_id"].Value = Imagen_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")

                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Activar Imagen");

            return respuesta;
        }
    }
}
