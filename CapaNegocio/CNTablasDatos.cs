using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNTablasDatos
    {
      //PARA LA CONEXION A LA BASE DATOS
        private string connectionString;

        public CNTablasDatos()
        {
            conexiònBD conexionBD = new conexiònBD();
            connectionString = conexionBD.connectionString;
        }

        private TablasDatos tablasDatos = new TablasDatos();

        private readonly Dictionary<string, string[]> _diccionarioTitulos = new Dictionary<string, string[]>
    {
        {"padres", new[] {"Tipo de documento", "Número Documento", "Nombre Completo", "Dirección", "Teléfono" } },
        {"hijos", new[] { "Número Documento", "Nombre Completo", "Fecha Nacimiento", "Edad", "Género", "Según INEC", "Subsidio", "N. Documento del padre" } },
        {"docentes", new[] { "Docente ID","Número Documento", "Nombre Completo", "Direcciòn", "Tèlefono", "Grugo asignado"} },
        {"asistentes", new[] { "ID", "Número Documento", "Nombre Completo", "Docente ID" } },
         {"grupos", new[] { "ID", "Nombre" } }
    };

      
        public void CargarTablasPermitidas(ComboBox cmbTablas)
        {
            DataTable dt = tablasDatos.ObtenerTablasPermitidas();
            cmbTablas.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                cmbTablas.Items.Add(row["TABLE_NAME"].ToString());
            }
        }

        public void CargarDatosTabla(string tabla, DataGridView dataGridView)
        {
            // dataGridView.DataSource = tablasDatos.ObtenerDatosTabla(tabla);
            DataTable datosTabla = tablasDatos.ObtenerDatosTabla(tabla);
            var columnasNoPermitidas = new string[] { "" };
            var columnasPermitidas = datosTabla.Columns.Cast<DataColumn>().Where(col => !columnasNoPermitidas.Contains(col.ColumnName)).Select(col => col.ColumnName).ToArray();
            DataTable dt = datosTabla.DefaultView.ToTable(false, columnasPermitidas);
            dataGridView.DataSource = dt;
        } 

        public string[] ObtenerDiccionario(string tabla)
        {
            return _diccionarioTitulos[tabla];
        }

        public void BuscarPorNombre(string tabla, string nombre, DataGridView dataGridView)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM " + tabla + " WHERE nombre_completo LIKE @nombre";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView.DataSource = dt;
                connection.Close();
            }
        }


    }
}
