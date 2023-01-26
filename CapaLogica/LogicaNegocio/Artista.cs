using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatricula.CapaLogica.LogicaNegocio
{
   public class Artista
    {

        #region ATRIBUTOS
        protected int artista_id;
        protected string artista_nacionalidad;
        protected string artista_nombre;
        protected string artista_biografia;
        protected string artista_estado;     
        #endregion

        #region CONSTRUCTOR
        public Artista()
        {

        }
        public Artista(string Partista_nacionalidad, string Partista_nombre, string Partista_biografia, string Partista_estado)
        {
            Artista_id = 0;
            Artista_nacionalidad = Partista_nacionalidad;
            Artista_nombre = Partista_nombre;
            Artista_biografia = Partista_biografia;
            Artista_estado = Partista_estado;
        }

        public Artista(int Partista_id, string Partista_nacionalidad, string Partista_nombre, string Partista_biografia, string Partista_estado)
        {
            Artista_id = Partista_id;
            Artista_nacionalidad = Partista_nacionalidad;
            Artista_nombre = Partista_nombre;
            Artista_biografia = Partista_biografia;
            Artista_estado = Partista_estado;
        }

        #endregion

        #region SET's Y GET's
        public int Artista_id { get => artista_id; set => artista_id = value; }
        public string Artista_nacionalidad { get => artista_nacionalidad; set => artista_nacionalidad = value; }
        public string Artista_biografia { get => artista_biografia; set => artista_biografia = value; }
        public string Artista_estado { get => artista_estado; set => artista_estado = value; }
        public string Artista_nombre { get => artista_nombre; set => artista_nombre = value; }
        #endregion
    }
}
