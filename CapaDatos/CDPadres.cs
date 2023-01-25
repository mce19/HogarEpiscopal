using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidad;
using System.Data;

namespace CapaDatos
{


    public class CDPadres
    {
        
       //private string connectionString = "Data Source=LOCAL;Initial Catalog=hogar_episcopal;Integrated Security=True;";
       private string connectionString = "Data Source=DESKTOP-AP0JBJ6\\NUCLEUS;Initial Catalog=hogar_episcopal;Integrated Security=True;";

        public List<Padres> ObtenerTodosPadres()
        {
            var padres = new List<Padres>();


            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                //usamos un proceso de almancenamiento echo en slq y lo llamomos aqui
                var query = "MostrarPadres";
                var command = new SqlCommand(query, connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var padre = new Padres();
                        padre.TipoDocumento = reader.GetString("tipo_documento");
                        padre.NumeroDocumento = reader.GetInt32("numero_documento");
                        padre.NombreCompleto = reader.GetString("nombre_completo");
                        padre.Direccion = reader.GetString("direccion");
                        padre.Telefono = reader.GetString("telefono");
                        padres.Add(padre);
                    }
                }
            }

            return padres;
        }


        public void AgregarPadre(Padres padre)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("INSERT INTO padres (tipo_documento, numero_documento, nombre_completo, direccion, telefono) VALUES (@tipoDocumento, @numeroDocumento, @nombre, @direccion, @telefono)", connection);
                    command.Parameters.AddWithValue("@tipoDocumento", padre.TipoDocumento);
                    command.Parameters.AddWithValue("@numeroDocumento", padre.NumeroDocumento);
                    command.Parameters.AddWithValue("@nombre", padre.NombreCompleto);
                    command.Parameters.AddWithValue("@direccion", padre.Direccion);
                    command.Parameters.AddWithValue("@telefono", padre.Telefono);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void EditarPadre(Padres padre)
        {
            try
            {
                if (string.IsNullOrEmpty(padre.TipoDocumento))
                    throw new Exception("El tipo de documento es requerido");
               
                if (string.IsNullOrEmpty(padre.NumeroDocumento.ToString()))
                    throw new Exception("El número de documento es requerido");

                if (string.IsNullOrEmpty(padre.NombreCompleto))
                    throw new Exception("El nombre es requerido");

                if (string.IsNullOrEmpty(padre.Direccion))
                    throw new Exception("La dirección es requerida");

                if (string.IsNullOrEmpty(padre.Telefono))
                    throw new Exception("El teléfono es requerido");

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE padres SET tipo_documento = @tipoDocumento,  nombre_completo = @nombre, direccion = @direccion, telefono = @telefono WHERE numero_documento = @numeroDocumento", connection);
                    command.Parameters.AddWithValue("@tipoDocumento", padre.TipoDocumento);
                    command.Parameters.AddWithValue("@numeroDocumento", padre.NumeroDocumento);
                    command.Parameters.AddWithValue("@nombre", padre.NombreCompleto);
                    command.Parameters.AddWithValue("@direccion", padre.Direccion);
                    command.Parameters.AddWithValue("@telefono", padre.Telefono);

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




