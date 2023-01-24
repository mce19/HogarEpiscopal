using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class TablasDatos
    {
       // public string connectionString = "Data Source=LOCAL;Initial Catalog=hogar_episcopal;Integrated Security=True;";
        public string connectionString = "Data Source=DESKTOP-AP0JBJ6\\NUCLEUS;Initial Catalog=hogar_episcopal;Integrated Security=True;";
        private List<string> tablasPermitidas = new List<string>() { "padres", "hijos", "docentes", "asistentes" };

        public DataTable ObtenerTablasPermitidas()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                DataTable dt = connection.GetSchema("Tables");
                connection.Close();
                return dt.AsEnumerable().Where(row => tablasPermitidas.Contains(row.Field<string>("TABLE_NAME"))).CopyToDataTable();
            }
        }

        public DataTable ObtenerDatosTabla(string tabla)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM " + tabla;
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                return dt;
            }
        }

        public bool GuardarPadre(string tipoDocumento, string numeroDocumento, string nombre, string direccion, string telefono)
        {
            bool guardadoExitoso = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO padres ( numero_documento, nombre, direccion, telefono) VALUES (@tipo_documento, @numeroDocumento, @nombre, @direccion, @telefono)", connection))
                {
                    //command.Parameters.AddWithValue("@tipoDocumento", tipoDocumento);
                    command.Parameters.AddWithValue("@numeroDocumento", numeroDocumento);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@telefono", telefono);

                    int filasAfectadas = command.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        guardadoExitoso = true;
                    }
                    connection.Close();
                }
            }
            return guardadoExitoso;
        }

    }
}
