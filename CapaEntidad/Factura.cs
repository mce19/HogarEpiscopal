using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Factura
    {

        public int Id { get; set; }
        public int PadreId { get; set; }
        public decimal MontoMensual { get; set; }
        public decimal MontoAbonado { get; set; }
        public decimal SaldoActual { get; set; }
        public DateTime Fecha { get; set; }
        public string Detalles { get; set; }

    }
}
