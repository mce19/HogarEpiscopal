using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDGrupos
    {
        private string connectionString;

        public CDGrupos()
        {
            conexiònBD conexionBD = new conexiònBD();
            connectionString = conexionBD.connectionString;
        }


        public DataTable ListarNombresGrupos()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT nombre FROM grupos";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

                connection.Close();
            }

            return dt;
        }

        public DataTable ListarInformacionPorGrupo(string groupName)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("GetInfoByGroup", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@groupName", groupName);

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        sqlDataAdapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }


        public bool InsertarGrupo(int id, string nombre)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("InsertarGrupo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@nombre", nombre);



                        int rowsAffected = cmd.ExecuteNonQuery();//verificamos que se agrego una nueva fila
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

        public void ActualizarGrupo(int id, string nombre)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("ActualizarGrupo", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    int rowsAffected = comando.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // El grupo se actualizó correctamente
                    }
                    else
                    {
                        throw new Exception("No se pudo actualizar el grupo");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar grupo: " + ex.Message);
            }
        }

        /// <summary>
        /// Obtiene los detalles del grupo seleccionado.
        /// </summary>
        /// <param name="nombreGrupo">El nombre del grupo a consultar.</param>
        /// <returns>Un objeto DataTable con los detalles del grupo.</returns>

        public DataTable ObtenerGrupoDetalle(string nombreGrupo)
        {


            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {

                    conexion.Open();
                    SqlCommand comando = new SqlCommand("ObtenerGrupoDetalle", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@nombre_grupo", nombreGrupo);

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    return tabla;
                }

            }


            catch (Exception ex)
            {
                throw new Exception("Error al obtener detalle del grupo: " + ex.Message);
            }
         }

     }


    
}

