using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Matriculas
    {
        public int Id { get; set; }
        public int HijoId { get; set; }
        public int PadreId { get; set; }
        public int DocenteId { get; set; }
        public int GrupoId { get; set; }


        public string Tabla { get; set; }
        public string Nombre { get; set; }
        public string NumeroDocumento { get; set; }


    }
}
