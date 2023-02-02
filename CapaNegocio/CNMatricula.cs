using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNMatricula
    {

        private CDMatricula objCDMatricula;

        public CNMatricula()
        {
            objCDMatricula = new CDMatricula();
        }

        public DataTable ListarMatriculados()
        {
            return objCDMatricula.ListarMatriculados();
        }

        public DataTable ListarDocenteGrupos()
        {
            return objCDMatricula.ListarDocenteGrupos();
        }
    }
   
}
