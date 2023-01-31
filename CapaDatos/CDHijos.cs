using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDHijos
    {
        private string connectionString;

        public CDHijos()
        {
            conexiònBD conexionBD = new conexiònBD();
            connectionString = conexionBD.connectionString;
        }


        public void AgregarHijo(Hijos hijo)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    
                        SqlCommand command = new SqlCommand("INSERT INTO hijos (numero_documento, nombre_completo, fecha_nacimiento, edad, genero, segun_inec, subsidio, padre_id, fecha_registro) VALUES (@numero_documento, @nombre_completo, @fecha_nacimiento, @edad, @genero, @segun_inec, @subsidio, @padre_id, @fecha_registro)", connection);
                        command.Parameters.AddWithValue("@numero_documento", hijo.NumeroDocumento);
                        command.Parameters.AddWithValue("@nombre_completo", hijo.NombreCompleto);
                        command.Parameters.AddWithValue("@fecha_nacimiento", hijo.FechaNacimiento);
                        command.Parameters.AddWithValue("@edad", hijo.Edad);
                        command.Parameters.AddWithValue("@genero", hijo.Genero);
                        command.Parameters.AddWithValue("@segun_inec", hijo.SegunInec);
                        command.Parameters.AddWithValue("@subsidio", hijo.Subsidio);
                        command.Parameters.AddWithValue("@padre_id", hijo.PadreId);
                        command.Parameters.AddWithValue("@fecha_registro", DateTime.Now);
                    command.ExecuteNonQuery();
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
    }
 }
