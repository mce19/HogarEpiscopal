using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class conexiònBD

    {
        public string connectionString;
        // public string connectionString = "Data Source=DESKTOP-AP0JBJ6\\NUCLEUS;Initial Catalog=hogar_episcopal;Integrated Security=True;";
        public SqlConnection connection;
        public conexiònBD()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }

    }
}
