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

        public bool InsertarPago(int id, int padreId, decimal montoMensual, decimal montoAbonado, decimal montoRestante, decimal saldoActual, DateTime fecha, string detalles)
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
                        command.Parameters.AddWithValue("@monto_restante", montoRestante);
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

    }
}
