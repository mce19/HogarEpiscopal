using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNTablasDatos
    {

        private TablasDatos tablasDatos = new TablasDatos();

        private readonly Dictionary<string, string[]> _diccionarioTitulos = new Dictionary<string, string[]>
    {
        {"padres", new[] { "Número Documento", "Nombre Completo", "Dirección", "Teléfono" } },
        {"hijos", new[] { "Número Documento", "Nombre Completo", "Fecha Nacimiento", "Edad", "Género", "Según INEC", "Subsidio", "N. Documento del padre" } },
        {"docentes", new[] { "Docente ID","Número Documento", "Nombre", "Apellido", "Direcciòn", "Tèlefono" } },
        {"asistentes", new[] { "ID", "Número Documento", "Nombre", "Apellido", "Docente ID" } }
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
            var columnasNoPermitidas = new string[] { "tipo_documento" };
            var columnasPermitidas = datosTabla.Columns.Cast<DataColumn>().Where(col => !columnasNoPermitidas.Contains(col.ColumnName)).Select(col => col.ColumnName).ToArray();
            DataTable dt = datosTabla.DefaultView.ToTable(false, columnasPermitidas);
            dataGridView.DataSource = dt;
        } 

        public string[] ObtenerDiccionario(string tabla)
        {
            return _diccionarioTitulos[tabla];
        }


    }
}
