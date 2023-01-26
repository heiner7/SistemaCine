using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatricula.CapaLogica.LogicaNegocio
{
    public class Obra
    {

        #region ATRIBUTOS
        protected int obra_id;
        protected int artista_id;
        protected int coleccion_id;
        protected int tipoObra_id;
        protected string obra_nombre;
        protected string obra_descripcion;
        protected string obra_cultura;
        protected string obra_estado;
        #endregion

        #region CONSTRUCTOR
        public Obra()
        {

        }
        public Obra(int Partista_id, int Pcoleccion_id, int PtipoObra_id, string Pobra_nombre, string Pobra_descripcion, string Pobra_cultura, string Pobra_estado)
        {
            Obra_id = 0;
            Artista_id = Partista_id;
            Coleccion_id = Pcoleccion_id;
            TipoObra_id = PtipoObra_id;
            Obra_nombre = Pobra_nombre;
            Obra_descripcion = Pobra_descripcion;
            Obra_cultura = Pobra_cultura;
            Obra_estado = Pobra_estado;
        }

        public Obra(int Pobra_id, int Partista_id, int Pcoleccion_id, int PtipoObra_id, string Pobra_nombre, string Pobra_descripcion, string Pobra_cultura, string Pobra_estado)
        {
            Obra_id = Pobra_id;
            Artista_id = Partista_id;
            Coleccion_id = Pcoleccion_id;
            TipoObra_id = PtipoObra_id;
            Obra_nombre = Pobra_nombre;
            Obra_descripcion = Pobra_descripcion;
            Obra_cultura = Pobra_cultura;
            Obra_estado = Pobra_estado;
        }

        #endregion

        #region SET's Y GET's
        public int Obra_id { get => obra_id; set => obra_id = value; }
        public int Artista_id { get => artista_id; set => artista_id = value; }
        public int Coleccion_id { get => coleccion_id; set => coleccion_id = value; }
        public int TipoObra_id { get => tipoObra_id; set => tipoObra_id = value; }
        public string Obra_nombre { get => obra_nombre; set => obra_nombre = value; }
        public string Obra_descripcion { get => obra_descripcion; set => obra_descripcion = value; }
        public string Obra_cultura { get => obra_cultura; set => obra_cultura = value; }
        public string Obra_estado { get => obra_estado; set => obra_estado = value; }
        #endregion

    }
}
