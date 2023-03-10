using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDHistorial
    {
        private string connectionString;

        public CDHistorial()
        {
            conexiònBD conexionBD = new conexiònBD();
            connectionString = conexionBD.connectionString;
        }
        public DataTable ObtenerHistorial()
        {
            DataTable dtPagos = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("Historial", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    dtPagos.Load(rdr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el historial de los meses cancelados.", ex);
            }
            return dtPagos;
        }

    }
}
