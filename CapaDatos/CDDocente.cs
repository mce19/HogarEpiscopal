using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDDocente
    {
        private string connectionString;

        public CDDocente()
        {
            conexiònBD conexionBD = new conexiònBD();
            connectionString = conexionBD.connectionString;
        }

        public DataTable ObtenerDocentes()
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand("SELECT id, nombre FROM docentes", conexion))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                    {
                        DataTable tabla = new DataTable();
                        adapter.Fill(tabla);
                        return tabla;
                    }
                }
            }
        }

        public int ObtenerIdGrupoPorDocente(int idDocente)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand("SELECT idGrupo FROM docentes WHERE id = @idDocente", conexion))
                {
                    comando.Parameters.AddWithValue("@idDocente", idDocente);
                    int idGrupo = (int)comando.ExecuteScalar();
                    return idGrupo;
                }
            }
        }

        public string ObtenerNombreGrupoPorId(int idGrupo)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand("SELECT nombre FROM grupos WHERE id = @idGrupo", conexion))
                {
                    comando.Parameters.AddWithValue("@idGrupo", idGrupo);
                    string nombreGrupo = (string)comando.ExecuteScalar();
                    return nombreGrupo;
                }
            }
        }


        public bool InsertarDocente(int id, string nombre, string direccion, string telefono, int grupo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("InsertarDocente", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@numero_documento", id);
                        cmd.Parameters.AddWithValue("@nombre_completo", nombre);
                        cmd.Parameters.AddWithValue("@direccion", direccion);
                        cmd.Parameters.AddWithValue("@telefono", telefono);
                        cmd.Parameters.AddWithValue("@grupo_id", grupo);

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
                Console.WriteLine("Error al ingresar un nuevo profesor al sistema: " + ex.Message);
                return false;
            }
        }

        public bool ActualizarDocente(int numeroDocumento, string nombreCompleto, string direccion, string telefono, int grupoId)
        {
            bool resultado = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    using (SqlCommand comando = new SqlCommand("ActualizarDocente", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        comando.Parameters.AddWithValue("@numero_documento", numeroDocumento);
                        comando.Parameters.AddWithValue("@nombre_completo", nombreCompleto);
                        comando.Parameters.AddWithValue("@direccion", direccion);
                        comando.Parameters.AddWithValue("@telefono", telefono);
                        comando.Parameters.AddWithValue("@grupo_id", grupoId);

                        conexion.Open();
                        int filasAfectadas = comando.ExecuteNonQuery();
                        resultado = (filasAfectadas > 0);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MessageBox.Show("Se produjo un error al actualizar el docente: " + ex.Message, "Error al actualizar docente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;
        }


    }
}
