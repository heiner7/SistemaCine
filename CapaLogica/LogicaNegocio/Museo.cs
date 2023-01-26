using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatricula.CapaLogica.LogicaNegocio
{
    public class Museo
    {
        #region ATRIBUTOS
        protected int museo_id;
        protected int tipoMuseo_id;
        protected string museo_nombre;
        protected string museo_instalacion;
        protected string museo_estado;

        #endregion

        #region CONSTRUCTOR
        public Museo()
        {

        }
        public Museo(int PtipoMuseo_id, string Pmuseo_nombre,string Pmuseo_instalacion, string Pmuseo_estado)
        {
            Museo_id = 0;
            TipoMuseo_id = PtipoMuseo_id;
            Museo_nombre = Pmuseo_nombre;
            Museo_instalacion = Pmuseo_instalacion;
            Museo_estado = Pmuseo_estado;
        }

        public Museo(int Pmuseo_id, int PtipoMuseo_id, string Pmuseo_nombre, string Pmuseo_instalacion, string Pmuseo_estado)
        {
            Museo_id = Pmuseo_id;
            TipoMuseo_id = PtipoMuseo_id;
            Museo_nombre = Pmuseo_nombre;
            museo_instalacion = Pmuseo_instalacion;
            Museo_estado = Pmuseo_estado;
        }

        #endregion

        #region SET's Y GET's
        public int Museo_id { get => museo_id; set => museo_id = value; }
        public int TipoMuseo_id { get => tipoMuseo_id; set => tipoMuseo_id = value; }
        public string Museo_nombre { get => museo_nombre; set => museo_nombre = value; }
        public string Museo_estado { get => museo_estado; set => museo_estado = value; }
        public string Museo_instalacion { get => museo_instalacion; set => museo_instalacion = value; }
        #endregion
    }
}
