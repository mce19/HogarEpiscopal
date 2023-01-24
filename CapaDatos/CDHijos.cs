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
        private string connectionString = "Data Source=DESKTOP-AP0JBJ6\\NUCLEUS;Initial Catalog=hogar_episcopal;Integrated Security=True;";
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

    }
}
