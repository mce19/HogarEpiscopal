using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class conexiònBD

    {
        //public string connectionString = "Data Source=DESKTOP-AP0JBJ6\\NUCLEUS;Initial Catalog=hogar_episcopal;Integrated Security=True;";
        public string connectionString = "Data Source=LOCAL;Initial Catalog=hogar_episcopal;Integrated Security=True;";
        private SqlConnection connection;

        public conexiònBD()
        {
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



/*RECORDATORIO
 
- VALIDAR EL CAMPO DE LA EDAD PAR QUE SOLO PERMITA NUMEROS Y NO SE CAIGA
 - CONFIGURAR EL BOTON ELIMINAR PARA LA TABLA GRUPOS POR FILA
 
 
 
 */