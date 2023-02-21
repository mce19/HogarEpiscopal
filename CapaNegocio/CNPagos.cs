using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNPagos
    {
        private CDPagos cdPagos = new CDPagos();

        public bool InsertarPago(int id, int padreId, decimal montoMensual, decimal montoAbonado, decimal montoRestante, decimal saldoActual, DateTime fecha, string detalles)
        {
            return cdPagos.InsertarPago(id, padreId, montoMensual, montoAbonado, montoRestante, saldoActual, fecha, detalles);
        }
    }
}
