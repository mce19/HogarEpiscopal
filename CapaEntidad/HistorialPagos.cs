﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class HistorialPagos
    {
        public int Id { get; set; }
        public int PadreId { get; set; }
        public int PagoId { get; set; }
    }
}
