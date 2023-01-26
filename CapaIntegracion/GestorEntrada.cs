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
    public class GestorEntrada : servicio, IDisposable
    {

        public GestorEntrada()
        {

        }
        public void Dispose()
        {

        }

        //Metodo para Insertar Entrada
        public string InsertarEntrada(int Museo_id, int Precio_id, int Tarjeta_id, string Entrada_nombreVisitante, string Entrada_fecha, int Entrada_cantidad, 
                                      float Entrada_subtotal, float Entrada_comision, float Entrada_total, string Entrada_estado)
        {
            Entrada nuevoEntrada = new Entrada(Museo_id, Precio_id, Tarjeta_id, Entrada_nombreVisitante, Entrada_fecha, Entrada_cantidad, Entrada_subtotal,
                                    Entrada_comision, Entrada_total, Entrada_estado);
            using (ServicioEntrada elEntrada = new ServicioEntrada())
            {
                return elEntrada.InsertarEntrada(nuevoEntrada);
            }
        }

        //Metodo para Modificar Entrada
        public string ModificarEntrada(int Entrada_id, int Museo_id, int Precio_id, int Tarjeta_id, string Entrada_nombreVisitante, string Entrada_fecha, int Entrada_cantidad,
                                      float Entrada_subtotal, float Entrada_comision, float Entrada_total, string Entrada_estado)
        {
            Entrada nuevoEntrada = new Entrada(Entrada_id, Museo_id, Precio_id, Tarjeta_id, Entrada_nombreVisitante, Entrada_fecha, Entrada_cantidad, Entrada_subtotal,
                                    Entrada_comision, Entrada_total, Entrada_estado);
            using (ServicioEntrada elEntrada = new ServicioEntrada())
            {
                return elEntrada.ModificarEntrada(nuevoEntrada);
            }
        }

        public DataSet ConsultarEntrada(int Entrada_id)
        {
            using (ServicioEntrada elEntrada = new ServicioEntrada())
            {
                return elEntrada.ConsultarEntrada(Entrada_id);
            }
        }

        public DataTable ListarEntrada()
        {
            using (ServicioEntrada elEntrada = new ServicioEntrada())
            {
                return elEntrada.ListarEntrada();
            }
        }

        public DataTable ListarEntradaInactivo()
        {
            using (ServicioEntrada elEntrada = new ServicioEntrada())
            {
                return elEntrada.ListarEntradaInactivo();
            }
        }

        public string InactivarEntrada(int Entrada_id)
        {
            using (ServicioEntrada elEntrada = new ServicioEntrada())
            {
                return elEntrada.InactivarEntrada(Entrada_id);
            }
        }

        public string ActivarEntrada(int Entrada_id)
        {
            using (ServicioEntrada elEntrada = new ServicioEntrada())
            {
                return elEntrada.ActivarEntrada(Entrada_id);
            }
        }

    }
}
