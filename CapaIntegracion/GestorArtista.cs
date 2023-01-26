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
    public class GestorArtista : servicio, IDisposable
    {

        public GestorArtista()
        {

        }
        public void Dispose()
        {

        }

        //Metodo para Insertar Artista
        public string InsertarArtista(string Artista_nacionalidad, string Artista_nombre, string Artista_biografia, string Artista_estado)
        {
            Artista nuevoArtista = new Artista(Artista_nacionalidad,Artista_nombre, Artista_biografia, Artista_estado);
            using (ServicioArtista elArtista = new ServicioArtista())
            {
                return elArtista.InsertarArtista(nuevoArtista);
            }
        }

        //Metodo para Modificar Artista
        public string ModificarArtista(int Artista_id, string Artista_nacionalidad, string Artista_nombre, string Artista_biografia, string Artista_estado)
        {
            Artista nuevoArtista = new Artista(Artista_id, Artista_nacionalidad, Artista_nombre, Artista_biografia, Artista_estado);
            using (ServicioArtista elArtista = new ServicioArtista())
            {
                return elArtista.ModificarArtista(nuevoArtista);
            }
        }

        public DataTable ListarArtista()
        {
            using (ServicioArtista elMuseo = new ServicioArtista())
            {
                return elMuseo.ListarArtista();
            }
        }

        public DataTable ListarArtistaInactivo()
        {
            using (ServicioArtista elArtista = new ServicioArtista())
            {
                return elArtista.ListarArtistaInactivo();
            }
        }

        public DataSet ConsultarArtista(int Artista_id)
        {
            using (ServicioArtista elArtista = new ServicioArtista())
            {
                return elArtista.ConsultarArtista(Artista_id);
            }
        }

        public string InactivarArtista(int Artista_id)
        {
            using (ServicioArtista elArtista = new ServicioArtista())
            {
                return elArtista.InactivarArtista(Artista_id);
            }
        }

        public string ActivarArtista(int Artista_id)
        {
            using (ServicioArtista elArtista = new ServicioArtista())
            {
                return elArtista.ActivarArtista(Artista_id);
            }
        }
    }
}
