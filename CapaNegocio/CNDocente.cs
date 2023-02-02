using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNDocente
    {
        private CDDocente objCDDocente;

        public CNDocente()
        {
            objCDDocente = new CDDocente();
        }

        public DataTable ObtenerDocentes()
        {
            return objCDDocente.ObtenerDocentes();
        }

        public string ObtenerNombreGrupoPorIdDocente(int idDocente)
        {
            int idGrupo = objCDDocente.ObtenerIdGrupoPorDocente(idDocente);
            string nombreGrupo = objCDDocente.ObtenerNombreGrupoPorId(idGrupo);
            return nombreGrupo;
        }
    }
}
