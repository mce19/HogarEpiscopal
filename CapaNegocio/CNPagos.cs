using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNPagos
    {
        private CDPagos cdPagos;

        public CNPagos()
        {
            cdPagos = new CDPagos();
        }

        public bool InsertarPago(int id, int padreId, decimal montoMensual, decimal montoAbonado, decimal saldoActual, DateTime fecha, string detalles)
        {
            return cdPagos.InsertarPago(id, padreId, montoMensual, montoAbonado, saldoActual, fecha, detalles);
        }


        public DataTable ObtenerPagos()
        {
            try
            {
                return cdPagos.ObtenerPagos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los pagos con los nombres de los padres.", ex);
            }
        }

        public DataTable BuscarPorId(int id)
        {
            return cdPagos.BuscarPorId(id);
        }

        public bool InsertarPagoEnHistorial(int id, int padreId, decimal montoCancelado, DateTime fechaCancelacion, string mesCancelacion)
        {
            return cdPagos.InsertarPagoEnHistorial(id, padreId, montoCancelado, fechaCancelacion, mesCancelacion);
        }


        public void ActualizarPago(int id, int padreId, decimal montoAbonado, decimal saldoActual, DateTime fecha, string concepto)
        {
            CDPagos capaDatos = new CDPagos();
            capaDatos.ActualizarPago(id, montoAbonado, saldoActual, fecha, concepto);
        }



    }

}
