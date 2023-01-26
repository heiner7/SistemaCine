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
    public class GestorImagen : servicio, IDisposable
    {

        public GestorImagen()
        {

        }
        public void Dispose()
        {

        }

        //Metodo para Insertar Imagen
        public string InsertarImagen(int Obras_id, byte[] Imagen_ubicacion, string Imagen_estado)
        {
            Imagen nuevoImagen = new Imagen(Obras_id, Imagen_ubicacion, Imagen_estado);
            using (ServicioImagen elImagen = new ServicioImagen())
            {
                return elImagen.InsertarImagen(nuevoImagen);
            }
        }

        //Metodo para Modificar Imagen
        public string ModificarImagen(int Imagen_id, int Obras_id, byte[] Imagen_ubicacion, string Imagen_estado)
        {
            Imagen nuevoImagen = new Imagen(Imagen_id, Obras_id, Imagen_ubicacion, Imagen_estado);
            using (ServicioImagen elImagen = new ServicioImagen())
            {
                return elImagen.ModificarImagen(nuevoImagen);
            }
        }

        public DataSet ConsultarImagen(int Imagen_id)
        {
            using (ServicioImagen elImagen = new ServicioImagen())
            {
                return elImagen.ConsultarImagen(Imagen_id);
            }
        }

        public DataTable ListarImagen()
        {
            using (ServicioImagen elImagen = new ServicioImagen())
            {
                return elImagen.ListarImagen();
            }
        }

        public DataTable ListarImagenInactivo()
        {
            using (ServicioImagen elImagen = new ServicioImagen())
            {
                return elImagen.ListarImagenInactivo();
            }
        }

        public string InactivarImagen(int Imagen_id)
        {
            using (ServicioImagen elImagen = new ServicioImagen())
            {
                return elImagen.InactivarImagen(Imagen_id);
            }
        }

        public string ActivarImagen(int Imagen_id)
        {
            using (ServicioImagen elImagen = new ServicioImagen())
            {
                return elImagen.ActivarImagen(Imagen_id);
            }
        }
    }
}
