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


      
        public UserHistorial()
        {
            InitializeComponent();
            cnPagos = new CNHistorial();
        }

        private void dataGridViewHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CNHistorial tablaDatos = new CNHistorial();
                DataTable dtHistorialPagos = tablaDatos.ObtenerHistorial();

                // Mostrar los datos en el DataGridView
                dataGridViewHistorial.DataSource = dtHistorialPagos;
            }
            catch (Exception ex)
            {
                // Mostrar el mensaje de error en una ventana de diálogo
                MessageBox.Show($"Error al obtener los datos: {ex.Message}");
            }
        }



        private void CargarTablaPagos()
        {
            try
            {
                DataTable dtPagos = cnPagos.ObtenerHistorial();

                dataGridViewHistorial.DataSource = dtPagos;
                dataGridViewHistorial.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                // Personalizar la tabla para mostrar los datos de forma más presentable
                dataGridViewHistorial.Columns["id"].HeaderText = "ID";
                dataGridViewHistorial.Columns["Documento"].HeaderText = "N. documento";
                dataGridViewHistorial.Columns["Nombre"].HeaderText = "Nombre completo";
                dataGridViewHistorial.Columns["monto_cancelado"].HeaderText = "Monto cacelado";
                dataGridViewHistorial.Columns["fecha_cancelacion"].HeaderText = "Fecha cancelada";

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el historial de montos cancelados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      


        private void UserHistorial_Load(object sender, EventArgs e)
        {
            CargarTablaPagos();
        }

        private void buttonFactura_Click(object sender, EventArgs e)
        {

        }
    }
}
