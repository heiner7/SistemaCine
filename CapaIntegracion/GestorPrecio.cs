using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Biblioteca SQL
using System.Data;
//Bibliotecas del sistema
using SistemaMatricula.CapaConexion;
using SistemaMatricula.CapaLogica.LogicaNegocio;
using SistemaMatricula.CapaLogica.Servicio;

namespace SistemaMatricula.CapaIntegracion
{
    public class GestorPrecio : servicio, IDisposable
    {

        public GestorPrecio()
        {

        }
        public void Dispose()
        {

        }

        //Metodo para Insertar Aula
        public string InsertarPrecio(int Museo_id, string Precio_modalidad, float Precio_monto, string Precio_estado)
        {
            Precio nuevoPrecio = new Precio(Museo_id, Precio_modalidad, Precio_monto, Precio_estado);
            using (ServicioPrecio elPrecio = new ServicioPrecio())
            {
                return elPrecio.InsertarPrecio(nuevoPrecio);
            }
        }

        //Metodo para Modificar Aula
        public string ModificarPrecio(int Precio_id, int Museo_id, string Precio_modalidad, float Precio_monto, string Precio_estado)
        {
            Precio nuevoPrecio = new Precio(Precio_id,  Museo_id, Precio_modalidad, Precio_monto, Precio_estado);
            using (ServicioPrecio elPrecio = new ServicioPrecio())
            {
                return elPrecio.ModificarPrecio(nuevoPrecio);
            }
        }

        public DataSet ConsultarPrecio(int Precio_id)
        {
            using (ServicioPrecio elPrecio = new ServicioPrecio())
            {
                return elPrecio.ConsultarPrecio(Precio_id);
            }
        }

        public DataTable ListarPrecio()
        {
            using (ServicioPrecio elPrecio = new ServicioPrecio())
            {
                return elPrecio.ListarPrecio();
            }
        }

        public DataTable ListarPrecioInactivo()
        {
            using (ServicioPrecio elPrecio = new ServicioPrecio())
            {
                return elPrecio.ListarPrecioInactivo();
            }
        }

        public string InactivarPrecio(int Precio_id)
        {
            using (ServicioPrecio elPrecio = new ServicioPrecio())
            {
                return elPrecio.InactivarPrecio(Precio_id);
            }
        }

        public string ActivarPrecio(int Precio_id)
        {
            using (ServicioPrecio elPrecio = new ServicioPrecio())
            {
                return elPrecio.ActivarPrecio(Precio_id);
            }
        }

    }
}
