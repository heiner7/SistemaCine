using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Biblioteca SQL
using System.Data;
//Bibliotecas del sistema
using SistemaMatricula.CapaConexion;
using SistemaMatricula.CapaLogica.LogicaNegocio;
using SistemaMatricula.CapaLogica.Servicio;

namespace SistemaMatricula.CapaIntegracion
{
    public class GestorObra : servicio, IDisposable
    {

        public GestorObra()
        {

        }
        public void Dispose()
        {

        }

        //Metodo para Insertar Obra
        public string InsertarObra(int Artista_id, int Coleccion_id, int TipoObra_id, string Obra_nombre, string Obra_descripcion, string Obra_cultura, string Obra_estado)
        {
            Obra nuevoObra = new Obra(Artista_id, Coleccion_id, TipoObra_id, Obra_nombre, Obra_descripcion, Obra_cultura, Obra_estado);
            using (ServicioObra elObra = new ServicioObra())
            {
                return elObra.InsertarObra(nuevoObra);
            }
        }

        //Metodo para Modificar Obra
        public string ModificarObra(int Obra_id, int Artista_id, int Coleccion_id, int TipoObra_id, string Obra_nombre, string Obra_descripcion, string Obra_cultura, string Obra_estado)
        {
            Obra nuevoObra = new Obra(Obra_id, Artista_id, Coleccion_id, TipoObra_id, Obra_nombre, Obra_descripcion, Obra_cultura, Obra_estado);
            using (ServicioObra elObra = new ServicioObra())
            {
                return elObra.ModificarObra(nuevoObra);
            }
        }

        public DataSet ConsultarObra(int Obra_id)
        {
            using (ServicioObra elObra = new ServicioObra())
            {
                return elObra.ConsultarObra(Obra_id);
            }
        }

        public DataTable ListarObra()
        {
            using (ServicioObra elObra = new ServicioObra())
            {
                return elObra.ListarObra();
            }
        }

        public DataTable ListarObraInactivo()
        {
            using (ServicioObra elObra = new ServicioObra())
            {
                return elObra.ListarObraInactivo();
            }
        }

        public string InactivarObra(int Obra_id)
        {
            using (ServicioObra elObra = new ServicioObra())
            {
                return elObra.InactivarObra(Obra_id);
            }
        }

        public string ActivarObra(int Obra_id)
        {
            using (ServicioObra elObra = new ServicioObra())
            {
                return elObra.ActivarObra(Obra_id);
            }
        }
    }
}
