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
    public class CDMatricula
    {
        private string connectionString;

        public CDMatricula()
        {
            conexiònBD conexionBD = new conexiònBD();
            connectionString = conexionBD.connectionString;
        }

        public void AgregarMatricula(Matriculas matricula)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    SqlCommand command = new SqlCommand("INSERT INTO matricula (id, hijo_id, padre_id, docente_id, grupo_id) VALUES (@id, @hijo_id, @padre_id, @docente_id, @grupo_id)", connection);
                    command.Parameters.AddWithValue("@id", matricula.Id);
                    command.Parameters.AddWithValue("@hijo_id", matricula.HijoId);
                    command.Parameters.AddWithValue("@padre_id", matricula.PadreId);
                    command.Parameters.AddWithValue("@docente_id", matricula.DocenteId);
                    command.Parameters.AddWithValue("@grupo_id", matricula.GrupoId);
                    command.ExecuteNonQuery();

                    // Cerrar la conexión
                    connection.Close();
                }

            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public void EditarHijo(Hijos hijo)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE hijos SET nombre_completo = @nombre, fecha_nacimiento = @fechaNacimiento, edad = @edad, genero = @genero, segun_inec = @segunInec, subsidio = @subsidio, padre_id = @padreId WHERE numero_documento = @numeroDocumento", connection);
                    command.Parameters.AddWithValue("@numeroDocumento", hijo.NumeroDocumento);
                    command.Parameters.AddWithValue("@nombre", hijo.NombreCompleto);
                    command.Parameters.AddWithValue("@fechaNacimiento", hijo.FechaNacimiento);
                    command.Parameters.AddWithValue("@edad", hijo.Edad);
                    command.Parameters.AddWithValue("@genero", hijo.Genero);
                    command.Parameters.AddWithValue("@segunInec", hijo.SegunInec);
                    command.Parameters.AddWithValue("@subsidio", hijo.Subsidio);
                    command.Parameters.AddWithValue("@padreId", hijo.PadreId);

                    // Ejecutar el comando
                    command.ExecuteNonQuery();

                    // Cerrar la conexión
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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


        public DataTable ListarDocenteGrupos()
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            conexion.Open();
            SqlCommand cmd = new SqlCommand("ConsultarDocentesConGrupo", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();

            return dt;
        }

        // Método para verificar si un padre y su hijo ya han sido matriculados previamente
        public bool VerificarMatricula(int padreId, int hijoId)
        {

            bool existeMatricula = false;

            // Conectar a la base de datos
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                string query = "SELECT COUNT(*) FROM matricula WHERE padre_id = @padreId AND hijo_id = @hijoId";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@padreId", padreId);
                comando.Parameters.AddWithValue("@hijoId", hijoId);

                int resultado = (int)comando.ExecuteScalar();

                existeMatricula = resultado > 0;

                conexion.Close();
            }

            return existeMatricula;
        }


    }
}
