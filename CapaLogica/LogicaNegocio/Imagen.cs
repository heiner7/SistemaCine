using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatricula.CapaLogica.LogicaNegocio
{
    public class Imagen
    {

        #region ATRIBUTOS
        protected int imagen_id;
        protected int obras_id;
        protected byte[] imagen_ubicacion;
        protected string imagen_estado;

        
        #endregion

        #region CONSTRUCTOR
        public Imagen()
        {

        }
        public Imagen(int Pobras_id, byte[] Pimagen_ubicacion, string Pimagen_estado)
        {
            Imagen_id = 0;
            Obras_id = Pobras_id;
            Imagen_ubicacion = Pimagen_ubicacion;
            Imagen_estado = Pimagen_estado;
        }

        public Imagen(int Pimagen_id, int Pobras_id, byte[] Pimagen_ubicacion, string Pimagen_estado)
        {
            Imagen_id = Pimagen_id;
            Obras_id = Pobras_id;
            Imagen_ubicacion = Pimagen_ubicacion;
            Imagen_estado = Pimagen_estado;
        }

        #endregion

        #region SET's Y GET's
        public int Imagen_id { get => imagen_id; set => imagen_id = value; }
        public int Obras_id { get => obras_id; set => obras_id = value; }
        public byte[] Imagen_ubicacion { get => imagen_ubicacion; set => imagen_ubicacion = value; }
        public string Imagen_estado { get => imagen_estado; set => imagen_estado = value; }
        #endregion
    }
}
