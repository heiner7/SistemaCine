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
    public class GestorTarjeta : servicio, IDisposable
    {

        public GestorTarjeta()
        {

        }
        public void Dispose()
        {

        }

        //Metodo para Insertar Tarjeta
        public string InsertarTarjeta(string Tarjeta_nombre, string Tarjeta_porcentaje, string Tarjeta_estado)
        {
            Tarjeta nuevoTarjeta = new Tarjeta(Tarjeta_nombre, Tarjeta_porcentaje, Tarjeta_estado);
            using (ServicioTarjeta elTarjeta = new ServicioTarjeta())
            {
                return elTarjeta.InsertarTarjeta(nuevoTarjeta);
            }
        }

        //Metodo para Modificar Tarjeta
        public string ModificarTarjeta(int Tarjeta_id, string Tarjeta_nombre, string Tarjeta_porcentaje, string Tarjeta_estado)
        {
            Tarjeta nuevoTarjeta = new Tarjeta(Tarjeta_id, Tarjeta_nombre, Tarjeta_porcentaje, Tarjeta_estado);
            using (ServicioTarjeta elTarjeta = new ServicioTarjeta())
            {
                return elTarjeta.ModificarTarjeta(nuevoTarjeta);
            }
        }

        public DataSet ConsultarTarjeta(int Tarjeta_id)
        {
            using (ServicioTarjeta elTarjeta = new ServicioTarjeta())
            {
                return elTarjeta.ConsultarTarjeta(Tarjeta_id);
            }
        }

        public DataTable ListarTarjeta()
        {
            using (ServicioTarjeta elTarjeta = new ServicioTarjeta())
            {
                return elTarjeta.ListarTarjeta();
            }
        }

        public DataTable ListarTarjetaInactivo()
        {
            using (ServicioTarjeta elTarjeta = new ServicioTarjeta())
            {
                return elTarjeta.ListarTarjetaInactivo();
            }
        }

        public string InactivarTarjeta(int Tarjeta_id)
        {
            using (ServicioTarjeta elTarjeta = new ServicioTarjeta())
            {
                return elTarjeta.InactivarTarjeta(Tarjeta_id);
            }
        }

        public string ActivarTarjeta(int Tarjeta_id)
        {
            using (ServicioTarjeta elTarjeta = new ServicioTarjeta())
            {
                return elTarjeta.ActivarTarjeta(Tarjeta_id);
            }
        }

    }
}
