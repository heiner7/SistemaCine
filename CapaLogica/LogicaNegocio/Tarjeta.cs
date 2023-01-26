using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatricula.CapaLogica.LogicaNegocio
{
    public class Tarjeta
    {

        #region ATRIBUTOS
        protected int tarjeta_id;
        protected string tarjeta_nombre;
        protected string tarjeta_porcentaje;
        protected string tarjeta_estado;
        #endregion

        #region CONSTRUCTOR
        public Tarjeta()
        {

        }
        public Tarjeta(string Ptarjeta_nombre, string Ptarjeta_porcentaje ,string Ptarjeta_estado)
        {
            Tarjeta_id = 0;
            Tarjeta_nombre = Ptarjeta_nombre;
            Tarjeta_porcentaje = Ptarjeta_porcentaje;
            Tarjeta_estado = Ptarjeta_estado;
        }

        public Tarjeta(int Ptarjeta_id, string Ptarjeta_nombre, string Ptarjeta_porcentaje, string Ptarjeta_estado)
        {
            Tarjeta_id = Ptarjeta_id;
            Tarjeta_nombre = Ptarjeta_nombre;
            Tarjeta_porcentaje = Ptarjeta_porcentaje;
            Tarjeta_estado = Ptarjeta_estado;
        }

        #endregion

        #region SET's Y GET's
        public int Tarjeta_id { get => tarjeta_id; set => tarjeta_id = value; }
        public string Tarjeta_nombre { get => tarjeta_nombre; set => tarjeta_nombre = value; }
        public string Tarjeta_porcentaje { get => tarjeta_porcentaje; set => tarjeta_porcentaje = value; }
        public string Tarjeta_estado { get => tarjeta_estado; set => tarjeta_estado = value; }

        #endregion

    }
}
