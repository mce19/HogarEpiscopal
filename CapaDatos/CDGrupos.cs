using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDGrupos
    {
        private string connectionString;

        public CDGrupos()
        {
            conexiònBD conexionBD = new conexiònBD();
            connectionString = conexionBD.connectionString;
        }

   

        public DataTable MostrarGrupos()
        {

            DataTable dt = new DataTable();
            try
            {
                SqlConnection conexion = new SqlConnection(connectionString);
                conexion.Open();
                cmd = new SqlCommand("SELECT id, nombre, docente_id FROM grupos", conexion);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                conexion.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public DataTable MostrarDocentePorGrupo(int idGrupo)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection conexion = new SqlConnection(connectionString);
                conexion.Open();
                cmd = new SqlCommand("SELECT numero_documento, nombre_completo FROM docentes WHERE id = (SELECT docente_id FROM grupos WHERE id = @idGrupo)", conexion);
                cmd.Parameters.AddWithValue("@idGrupo", idGrupo);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                conexion.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
    }

}

