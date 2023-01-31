using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDMatricula
    {
        private string connectionString;

        public CDMatricula()
        {
            conexiònBD conexionBD = new conexiònBD();
            connectionString = conexionBD.connectionString;
        }



        public DataTable ListarMatriculados()
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            conexion.Open();
            SqlCommand cmd = new SqlCommand("ConsultaRegistro", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();

            return dt;
        }
    }
}
