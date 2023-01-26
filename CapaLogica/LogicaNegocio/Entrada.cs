using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatricula.CapaLogica.LogicaNegocio
{
    public class Entrada
    {

        #region ATRIBUTOS
        protected int entrada_id;
        protected int museo_id;
        protected int precio_id;
        protected int tarjeta_id;
        protected string entrada_nombreVisitante;
        protected string entrada_fecha;
        protected int entrada_cantidad;
        protected float entrada_subtotal;
        protected float entrada_comision;
        protected float entrada_total;
        protected string entrada_estado;        

        #endregion

        #region CONSTRUCTOR

        public Entrada()
        {

        }
        public Entrada(int Pmuseo_id, int Pprecio_id, int Ptarjeta_id, string Pentrada_nombreVisitante, string Pentrada_fecha,
                       int Pentrada_cantidad, float Pentrada_subtotal, float Pentrada_comision, float Pentrada_total, string Pentrada_estado)
        {
            Entrada_id = 0;
            Museo_id = Pmuseo_id;
            Precio_id = Pprecio_id;
            Tarjeta_id = Ptarjeta_id;
            Entrada_nombreVisitante = Pentrada_nombreVisitante;
            Entrada_fecha = Pentrada_fecha;
            Entrada_cantidad = Pentrada_cantidad;
            Entrada_subtotal = Pentrada_subtotal;
            Entrada_comision = Pentrada_comision;
            Entrada_total = Pentrada_total;
            Entrada_estado = Pentrada_estado;
        }

        public Entrada(int Pentrada_id, int Pmuseo_id, int Pprecio_id, int Ptarjeta_id, string Pentrada_nombreVisitante, string Pentrada_fecha,
                       int Pentrada_cantidad, float Pentrada_subtotal, float Pentrada_comision, float Pentrada_total, string Pentrada_estado)
        {
            Entrada_id = Pentrada_id;
            Museo_id = Pmuseo_id;
            Precio_id = Pprecio_id;
            Tarjeta_id = Ptarjeta_id;
            Entrada_nombreVisitante = Pentrada_nombreVisitante;
            Entrada_fecha = Pentrada_fecha;
            Entrada_cantidad = Pentrada_cantidad;
            Entrada_subtotal = Pentrada_subtotal;
            Entrada_comision = Pentrada_comision;
            Entrada_total = Pentrada_total;
            Entrada_estado = Pentrada_estado;
        }
        #endregion

        #region SET's Y GET's
        public int Entrada_id { get => entrada_id; set => entrada_id = value; }
        public int Museo_id { get => museo_id; set => museo_id = value; }
        public int Precio_id { get => precio_id; set => precio_id = value; }
        public int Tarjeta_id { get => tarjeta_id; set => tarjeta_id = value; }
        public string Entrada_nombreVisitante { get => entrada_nombreVisitante; set => entrada_nombreVisitante = value; }
        public string Entrada_fecha { get => entrada_fecha; set => entrada_fecha = value; }
        public string Entrada_estado { get => entrada_estado; set => entrada_estado = value; }
        public int Entrada_cantidad { get => entrada_cantidad; set => entrada_cantidad = value; }
        public float Entrada_subtotal { get => entrada_subtotal; set => entrada_subtotal = value; }
        public  float Entrada_comision { get => entrada_comision; set => entrada_comision = value; }
        public float Entrada_total { get => entrada_total; set => entrada_total = value; }
        #endregion
    }
}
