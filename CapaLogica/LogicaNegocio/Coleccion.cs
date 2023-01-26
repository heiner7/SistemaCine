using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatricula.CapaLogica.LogicaNegocio
{
    public class Coleccion
    {

        #region ATRIBUTOS
        protected int coleccion_id;
        protected int museo_id;
        protected string coleccion_nombre;
        protected string coleccion_siglo;
        protected string coleccion_observaciones;
        protected string coleccion_estado;

        #endregion

        #region CONSTRUCTOR
        public Coleccion()
        {

        }
        public Coleccion(int Pmuseo_id, string Pcoleccion_nombre, string Pcoleccion_siglo, string Pcoleccion_observaciones, string Pcoleccion_estado)
        {
            Coleccion_id = 0;
            Museo_id = Pmuseo_id;
            coleccion_nombre = Pcoleccion_nombre;
            Coleccion_siglo = Pcoleccion_siglo;
            Coleccion_observaciones = Pcoleccion_observaciones;
            Coleccion_estado = Pcoleccion_estado;
        }

        public Coleccion(int Pcoleccion_id, int Pmuseo_id, string Pcoleccion_nombre, string Pcoleccion_siglo, string Pcoleccion_observaciones, string Pcoleccion_estado)
        {
            Coleccion_id = Pcoleccion_id;
            Museo_id = Pmuseo_id;
            coleccion_nombre = Pcoleccion_nombre;
            Coleccion_siglo = Pcoleccion_siglo;
            Coleccion_observaciones = Pcoleccion_observaciones;
            Coleccion_estado = Pcoleccion_estado;
        }

        #endregion

        #region SET's Y GET's
        public int Coleccion_id { get => coleccion_id; set => coleccion_id = value; }
        public int Museo_id { get => museo_id; set => museo_id = value; }
        public string Coleccion_nombre { get => coleccion_nombre; set => coleccion_nombre = value; }
        public string Coleccion_siglo { get => coleccion_siglo; set => coleccion_siglo = value; }
        public string Coleccion_observaciones { get => coleccion_observaciones; set => coleccion_observaciones = value; }
        public string Coleccion_estado { get => coleccion_estado; set => coleccion_estado = value; }


        #endregion

    }
}
