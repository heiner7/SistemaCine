using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatricula.CapaLogica.LogicaNegocio
{
    public class Precio
    {

        #region ATRIBUTOS
        protected int precio_id;
        protected int museo_id;
        protected string precio_modalidad;
        protected float precio_monto;
        protected string precio_estado;

        #endregion

        #region CONSTRUCTOR
        public Precio()
        {

        }
        public Precio(int Pmuseo_id, string Pprecio_modalidad, float Pprecio_monto, string Pprecio_estado)
        {
            Precio_id = 0;
            Museo_id = Pmuseo_id;
            Precio_modalidad = Pprecio_modalidad;
            Precio_monto = Pprecio_monto;
            Precio_estado = Pprecio_estado;
        }

        public Precio(int Pprecio_id, int Pmuseo_id, string Pprecio_modalidad, float Pprecio_monto, string Pprecio_estado)
        {
            Precio_id = Pprecio_id;
            Museo_id = Pmuseo_id;
            Precio_modalidad = Pprecio_modalidad;
            Precio_monto = Pprecio_monto;
            Precio_estado = Pprecio_estado;
        }

        #endregion

        #region SET's Y GET's
        public int Precio_id { get => precio_id; set => precio_id = value; }
        public int Museo_id { get => museo_id; set => museo_id = value; }
        public string Precio_modalidad { get => precio_modalidad; set => precio_modalidad = value; }     
        public string Precio_estado { get => precio_estado; set => precio_estado = value; }
        public float Precio_monto { get => precio_monto; set => precio_monto = value; }
        #endregion
    }
}
