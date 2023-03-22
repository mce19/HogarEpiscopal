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
        //public DataTable ObtenerHistorial()
        //{
        //    DataTable dtPagos = new DataTable();
        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(connectionString))
        //        {
        //            SqlCommand cmd = new SqlCommand("Historial", con);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            con.Open();
        //            SqlDataReader rdr = cmd.ExecuteReader();
        //            dtPagos.Load(rdr);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error al obtener el historial de los meses cancelados.", ex);
        //    }
        //    return dtPagos;
        //}

        //public DataTable BuscarPorNombre(string nombre)
        //{
        //    using (SqlConnection con = new SqlConnection(connectionString))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("BuscarNombreHistorial", con))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@nombre", nombre);
        //            con.Open();
        //            SqlDataReader reader = cmd.ExecuteReader();
        //            DataTable dataTable = new DataTable();
        //            dataTable.Load(reader);
        //            con.Close();
        //            return dataTable;
        //        }
        //    }

        //}


        public DataTable ObtenerHistorialPorMes(int mes)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("HistorialPorMes", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mes", mes);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el historial de pagos por mes: " + ex.Message);
            }
            return dt;
        }

    }
}