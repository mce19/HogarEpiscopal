using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Hijos
    {
        public int NumeroDocumento { get; set; }
        public string? NombreCompleto { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string? Edad { get; set; }
        public string? Genero { get; set; }
        public string? SegunInec { get; set; }
        public string? Subsidio { get; set; }
        public int PadreId { get; set; }

    }
}
