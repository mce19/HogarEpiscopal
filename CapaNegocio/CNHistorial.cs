using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNHistorial
    {
        private CDHistorial cdPagos;
        public CNHistorial()
        {
            cdPagos = new CDHistorial();
        }
        public DataTable ObtenerHistorial()
        {
            try
            {
                return cdPagos.ObtenerHistorial();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el hostorial.", ex);
            }
        }
    }
}
