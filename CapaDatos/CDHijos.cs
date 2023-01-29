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

                    // Consultar si el padre existe en la base de datos
                    SqlCommand commandPadre = new SqlCommand("SELECT COUNT(*) FROM padres WHERE numero_documento = @padre_id", connection);
                    commandPadre.Parameters.AddWithValue("@padre_id", hijo.PadreId);
                    int padreExiste = (int)commandPadre.ExecuteScalar();

                    // Si el padre existe en la base de datos, agregar el hijo
                    if (padreExiste > 0)
                    {
                        SqlCommand command = new SqlCommand("INSERT INTO hijos (numero_documento, nombre_completo, fecha_nacimiento, edad, genero, segun_inec, subsidio, padre_id) VALUES (@numero_documento, @nombre_completo, @fecha_nacimiento, @edad, @genero, @segun_inec, @subsidio, @padre_id)", connection);
                        command.Parameters.AddWithValue("@numero_documento", hijo.NumeroDocumento);
                        command.Parameters.AddWithValue("@nombre_completo", hijo.NombreCompleto);
                        command.Parameters.AddWithValue("@fecha_nacimiento", hijo.FechaNacimiento);
                        command.Parameters.AddWithValue("@edad", hijo.Edad);
                        command.Parameters.AddWithValue("@genero", hijo.Genero);
                        command.Parameters.AddWithValue("@segun_inec", hijo.SegunInec);
                        command.Parameters.AddWithValue("@subsidio", hijo.Subsidio);
                        command.Parameters.AddWithValue("@padre_id", hijo.PadreId);
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        throw new Exception("El padre con ID " + hijo.PadreId + " no existe en la base de datos.");
                    }
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
                if (string.IsNullOrEmpty(hijo.NumeroDocumento.ToString()))
                    throw new Exception("El número de documento es requerido");

                if (string.IsNullOrEmpty(hijo.NombreCompleto))
                    throw new Exception("El nombre es requerido");

                if (string.IsNullOrEmpty(hijo.FechaNacimiento.ToString()))
                    throw new Exception("La fecha de nacimiento es requerida");

                if (string.IsNullOrEmpty(hijo.Edad))
                    throw new Exception("La edad es requerida");

                if (string.IsNullOrEmpty(hijo.Genero))
                    throw new Exception("El género es requerido");

                if (string.IsNullOrEmpty(hijo.SegunInec))
                    throw new Exception("La clasificación según INEC es requerida");

                if (string.IsNullOrEmpty(hijo.Subsidio))
                    throw new Exception("El subsidio es requerido");

                if (string.IsNullOrEmpty(hijo.PadreId.ToString()))
                    throw new Exception("El ID del padre es requerido");

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
                    command.Parameters.AddWithValue("@padre_id", hijo.PadreId);

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
