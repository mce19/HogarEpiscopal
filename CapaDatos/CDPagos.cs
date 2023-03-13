using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDPagos
    {
        private string connectionString;

        public CDPagos()
        {
            conexiònBD conexionBD = new conexiònBD();
            connectionString = conexionBD.connectionString;
        }

        public bool InsertarPago(int id, int padreId, decimal montoMensual, decimal montoAbonado, decimal saldoActual, DateTime fecha, string detalles)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_InsertarPago", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@padre_id", padreId);
                        command.Parameters.AddWithValue("@monto_mensual", montoMensual);
                        command.Parameters.AddWithValue("@monto_abonado", montoAbonado);
                        command.Parameters.AddWithValue("@saldo_actual", saldoActual);
                        command.Parameters.AddWithValue("@fecha", fecha);
                        command.Parameters.AddWithValue("@concepto", detalles);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ObtenerPagos()
        {
            DataTable dtPagos = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("ObtenerPagosConNombresPadres", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    dtPagos.Load(rdr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los pagos con los nombres de los padres.", ex);
            }
            return dtPagos;
        }

        public DataTable BuscarPorId(int id)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM pagos WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);

                    con.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }

            return dt;
        }

        public bool InsertarPagoEnHistorial(int padreId, decimal monto, DateTime fecha)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("InsertarPagoEnHistorial", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@padre_id", padreId);
                        cmd.Parameters.AddWithValue("@monto_cancelado", monto);
                        cmd.Parameters.AddWithValue("@fecha_cancelacion", fecha);
                       

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar pago en historial: " + ex.Message);
                return false;
            }
        }


        public void ActualizarPago(int id, decimal montoAbonado, decimal saldoActual, DateTime fecha, string concepto)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand("usp_ActualizarPago", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@monto_abonado", montoAbonado);
                comando.Parameters.AddWithValue("@saldo_actual", saldoActual);
                comando.Parameters.AddWithValue("@fecha", fecha);
                comando.Parameters.AddWithValue("@concepto", concepto);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }


        public DataTable ObtenerNombresPagos(string nombre)
        {
            DataTable dtPagos = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("ObtenerNombresPagos", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dtPagos);
                }
            }
            catch (SqlException ex)
            {
                // Aquí puedes manejar la excepción de acuerdo a tus necesidades
                throw ex;
            }
            return dtPagos;
        }



    }
}
