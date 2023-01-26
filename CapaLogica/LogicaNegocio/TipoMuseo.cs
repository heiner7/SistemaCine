using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatricula.CapaLogica.LogicaNegocio
{
    public class TipoMuseo
    {

        #region ATRIBUTOS
        protected int tipoMuseo_id;
        protected string tipoMuseo_tipo;
        protected string tipoMuseo_descripcion;
        protected string tipoMuseo_estado;

        #endregion

        #region CONSTRUCTOR
        public TipoMuseo()
        {

        }
        public TipoMuseo(string PtipoMuseo_tipo, string PtipoMuseo_descripcion, string PtipoMuseo_estado)
        {
            TipoMuseo_id = 0;
            TipoMuseo_tipo = PtipoMuseo_tipo;
            TipoMuseo_descripcion = PtipoMuseo_descripcion;
            TipoMuseo_estado = PtipoMuseo_estado;
        }

        public TipoMuseo(int PtipoMuseo_id, string PtipoMuseo_tipo, string PtipoMuseo_descripcion, string PtipoMuseo_estado)
        {
            TipoMuseo_id = PtipoMuseo_id;
            TipoMuseo_tipo = PtipoMuseo_tipo;
            TipoMuseo_descripcion = PtipoMuseo_descripcion;
            TipoMuseo_estado = PtipoMuseo_estado;
        }

        #endregion

        #region SET's Y GET's
        public int TipoMuseo_id { get => tipoMuseo_id; set => tipoMuseo_id = value; }
        public string TipoMuseo_descripcion { get => tipoMuseo_descripcion; set => tipoMuseo_descripcion = value; }
        public string TipoMuseo_estado { get => tipoMuseo_estado; set => tipoMuseo_estado = value; }
        public string TipoMuseo_tipo { get => tipoMuseo_tipo; set => tipoMuseo_tipo = value; }
        #endregion
    }
}
