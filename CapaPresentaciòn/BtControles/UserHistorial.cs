using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentaciòn.BtControles
{
    public partial class UserHistorial : UserControl
    {

        private CNHistorial cnPagos;

        List<string> meses = new List<string>
       {
    "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
    "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
         };

        public UserHistorial()
        {
            InitializeComponent();
            cnPagos = new CNHistorial();
            BoxMes.DataSource = meses;

        }

        private void dataGridViewHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserHistorial_Load(object sender, EventArgs e)
        {

        }

        private void buttonFactura_Click(object sender, EventArgs e)
        {

        }

        private void textBoxBuscador_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoxMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Obtener el índice del mes seleccionado
                int indiceMes = BoxMes.SelectedIndex;

                // Crear un array con los nombres de los meses en orden correspondiente
                string[] meses = new string[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

                // Obtener el nombre del mes seleccionado y su equivalente numérico
                string mesSeleccionado = meses[indiceMes];
                int mesNumerico = indiceMes + 1; // Se suma 1 porque el mes 1 corresponde a enero, el 2 a febrero, etc.

                // Obtener los datos correspondientes al mes seleccionado y mostrarlos en el DataGridView
                DataTable dtPagos = cnPagos.ObtenerHistorialPorMes(mesNumerico);

                dataGridViewHistorial.DataSource = dtPagos;
                dataGridViewHistorial.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridViewHistorial.Columns["id"].HeaderText = "ID";
                dataGridViewHistorial.Columns["Documento"].HeaderText = "N. documento";
                dataGridViewHistorial.Columns["Nombre"].HeaderText = "Nombre completo";
                dataGridViewHistorial.Columns["monto_cancelado"].HeaderText = "Monto cacelado";
                dataGridViewHistorial.Columns["fecha_cancelacion"].HeaderText = "Fecha cancelada";


                decimal totalMes = 0;
                foreach (DataRow row in dtPagos.Rows)
                {
                    totalMes += Convert.ToDecimal(row["monto_cancelado"]);
                }
                NumExtranjero.Text = "Total: " + ((int)totalMes).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el historial de montos cancelados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NumExtranjero_Click(object sender, EventArgs e)
        {

        }
    }
}
