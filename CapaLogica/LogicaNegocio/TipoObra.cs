using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatricula.CapaLogica.LogicaNegocio
{
    public class TipoObra
    {

        #region ATRIBUTOS
        protected int tipoObra_id;
        protected string tipoObra_tipoObra;
        protected string tipoObra_descripcion;
        protected string tipoObra_estado;
        #endregion

        #region CONSTRUCTOR
        public TipoObra()
        {

        }
        public TipoObra(string PtipoObra_tipoObra, string PtipoObra_descripcion, string PtipoObra_estado)
        {
            TipoObra_id = 0;
            tipoObra_tipoObra = PtipoObra_tipoObra;
            TipoObra_descripcion = PtipoObra_descripcion;
            TipoObra_estado = PtipoObra_estado;
        }

        public TipoObra(int PtipoObra_id, string PtipoObra_tipoObra, string PtipoObra_descripcion, string PtipoObra_estado)
        {
            TipoObra_id = PtipoObra_id;
            tipoObra_tipoObra = PtipoObra_tipoObra;
            TipoObra_descripcion = PtipoObra_descripcion;
            TipoObra_estado = PtipoObra_estado;
        }
        #endregion

        #region SET's Y GET's
        public int TipoObra_id { get => tipoObra_id; set => tipoObra_id = value; }
        public string TipoObra_tipoObra { get => tipoObra_tipoObra; set => tipoObra_tipoObra = value; }
        public string TipoObra_descripcion { get => tipoObra_descripcion; set => tipoObra_descripcion = value; }
        public string TipoObra_estado { get => tipoObra_estado; set => tipoObra_estado = value; }
        #endregion
    }
}
