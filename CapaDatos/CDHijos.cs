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
                }
            
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    
        /*  private string connectionString = "Data Source=DESKTOP-AP0JBJ6\\NUCLEUS;Initial Catalog=hogar_episcopal;Integrated Security=True;";
          public List<Hijos> ObtenerTodosHijos()
          {
              var hijos = new List<Hijos>();

              using (var connection = new SqlConnection(connectionString))
              {
                  connection.Open();

                  var query = "ListarHijos";
                  var command = new SqlCommand(query, connection);
                  command.CommandType = CommandType.StoredProcedure;

                  using (var reader = command.ExecuteReader())
                  {
                      while (reader.Read())
                      {
                          var hijo = new Hijos();
                          hijo.NumeroDocumento = reader.GetInt32("numero_documento");
                          hijo.NombreCompleto = reader.GetString("nombre_completo");
                          hijo.FechaNacimiento = reader.GetDateTime("fecha_nacimiento");
                          hijo.Edad = reader.GetString("edad");
                          hijo.Genero = reader.GetString("genero");
                          hijo.SegunInec = reader.GetString("segun_inec");
                          hijo.Subsidio = reader.GetString("subsidio");
                          hijo.PadreId = reader.GetInt32("padre_id");
                          hijos.Add(hijo);
                      }
                  }
              }
              return hijos; 
          }
        */
    }
}
