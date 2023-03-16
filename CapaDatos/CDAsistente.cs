using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDAsistente
    {

        private string connectionString;

        public CDAsistente()
        {
            conexiònBD conexionBD = new conexiònBD();
            connectionString = conexionBD.connectionString;
        }

        public void AgregarAsistente(int numero_documento, string nombre_completo, int docente_id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    // Crear el objeto SqlCommand para llamar al procedimiento almacenado "agregar_asistente"
                    SqlCommand comando = new SqlCommand("Adsistente", conexion);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    // Definir los parámetros de entrada del procedimiento almacenado
                    comando.Parameters.AddWithValue("@numero_documento", numero_documento);
                    comando.Parameters.AddWithValue("@nombre_completo", nombre_completo);
                    comando.Parameters.AddWithValue("@docente_id", docente_id);

                    // Abrir la conexión a la base de datos y ejecutar el procedimiento almacenado
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción mostrando un mensaje de error
                throw new Exception("Error al agregar asistente a la base de datos: " + ex.Message);
            }

        }


        public void ActualizarAsistente(int id, int numero_documento, string nombre_completo, int docente_id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    // Crear el objeto SqlCommand para llamar al procedimiento almacenado "Updateasistente"
                    SqlCommand comando = new SqlCommand("Updateasistente", conexion);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    // Definir los parámetros de entrada del procedimiento almacenado
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@numero_documento", numero_documento);
                    comando.Parameters.AddWithValue("@nombre_completo", nombre_completo);
                    comando.Parameters.AddWithValue("@docente_id", docente_id);

                    // Abrir la conexión a la base de datos y ejecutar el procedimiento almacenado
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción mostrando un mensaje de error
                throw new Exception("Error al actualizar asistente en la base de datos: " + ex.Message);
            }
        }


        public bool ExisteAsistente(int numero_documento)
        {
            bool existe = false;

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    // Crear el objeto SqlCommand para llamar al procedimiento almacenado "verificar_asistente"
                    SqlCommand comando = new SqlCommand("VerificarAsistente", conexion);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    // Definir el parámetro de entrada del procedimiento almacenado
                    comando.Parameters.AddWithValue("@numero_documento", numero_documento);

                    // Abrir la conexión a la base de datos y ejecutar el procedimiento almacenado
                    conexion.Open();
                    existe = (bool)comando.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción mostrando un mensaje de error
                throw new Exception("Error al verificar si existe asistente: " + ex.Message);
            }

            return existe;
        }


    }
}
