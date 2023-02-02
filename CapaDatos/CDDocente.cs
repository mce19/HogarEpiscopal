using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDDocente
    {
        private string connectionString;

        public CDDocente()
        {
            conexiònBD conexionBD = new conexiònBD();
            connectionString = conexionBD.connectionString;
        }

        public DataTable ObtenerDocentes()
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand("SELECT id, nombre FROM docentes", conexion))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                    {
                        DataTable tabla = new DataTable();
                        adapter.Fill(tabla);
                        return tabla;
                    }
                }
            }
        }

        public int ObtenerIdGrupoPorDocente(int idDocente)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand("SELECT idGrupo FROM docentes WHERE id = @idDocente", conexion))
                {
                    comando.Parameters.AddWithValue("@idDocente", idDocente);
                    int idGrupo = (int)comando.ExecuteScalar();
                    return idGrupo;
                }
            }
        }

        public string ObtenerNombreGrupoPorId(int idGrupo)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand("SELECT nombre FROM grupos WHERE id = @idGrupo", conexion))
                {
                    comando.Parameters.AddWithValue("@idGrupo", idGrupo);
                    string nombreGrupo = (string)comando.ExecuteScalar();
                    return nombreGrupo;
                }
            }
        }
    }
}
