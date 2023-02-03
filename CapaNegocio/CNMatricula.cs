using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNMatricula
    {

        private string connectionString;
        private CDMatricula objCDMatricula;

        public CNMatricula()
        {
            objCDMatricula = new CDMatricula();
            conexiònBD conexionBD = new conexiònBD();
            connectionString = conexionBD.connectionString;
        }

        public DataTable ListarMatriculados()
        {
            return objCDMatricula.ListarMatriculados();
        }

        public DataTable ListarDocenteGrupos()
        {
            return objCDMatricula.ListarDocenteGrupos();
        }


        public void AgregarMatricula(Matriculas matricula)
        {

            try
            {

                objCDMatricula.AgregarMatricula(matricula);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool ExisteMatricula(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM matricula WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

    }

}
   

