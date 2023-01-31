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

        public DataTable MostrarGrupos()
        {
            return datos.MostrarGrupos();
        }

        public DataTable MostrarDocentePorGrupo(int idGrupo)
        {
            return datos.MostrarDocentePorGrupo(idGrupo);
        }
    }
}
