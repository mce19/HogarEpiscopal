using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Pagos
    {
        public int Id { get; set; }
        public int PadreId { get; set; }
        public string SegúnInec { get; set; }
        public decimal Monto { get; set; }
        public decimal SaldoActual { get; set; }
        public DateTime Fecha { get; set; }
    }
}
