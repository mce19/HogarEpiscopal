using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNGrupos
    {
       CDGrupos datos = new CDGrupos(); 
       CDGrupos oCDGrupos;

        public CNGrupos()
        {
            oCDGrupos = new CDGrupos();
        }

        public DataTable ListarNombresGrupos()
        {
            return oCDGrupos.ListarNombresGrupos();
        }

        public DataTable ListarInformacionPorGrupo(string groupName)
        {
            return oCDGrupos.ListarInformacionPorGrupo(groupName);
        }

    }

}
