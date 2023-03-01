using CapaEntidad;
using CapaNegocio;
using CapaPresentaciòn.BtViewTablas;
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
    public partial class Bienvenida : UserControl
    {
        private CNPagos cnPagos;
      

        public Bienvenida()
        {
            InitializeComponent();
            cnPagos = new CNPagos();
        }

        private void dataGridViewPágos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private TablaAbono formPadre; //instancia para evitar multiples ventanas
        private void buttonNewAbono_Click(object sender, EventArgs e)
        {
           

            if (formPadre == null || formPadre.IsDisposed)
            {
                formPadre = new TablaAbono();
                formPadre.FormClosed += (s, args) => formPadre = null; // establecer formPadre en null cuando se cierre el formulario
            }

            if (dataGridViewPágos.SelectedRows.Count > 0)
            {
                try
                {

                    formPadre.nombrepadre = dataGridViewPágos.SelectedRows[0].Cells["nombre_completo"].Value.ToString();
                    formPadre.Id = dataGridViewPágos.SelectedRows[0].Cells["Id"].Value.ToString();
                    formPadre.padreId = dataGridViewPágos.SelectedRows[0].Cells["padre_id"].Value.ToString();
                    formPadre.nombre = dataGridViewPágos.SelectedRows[0].Cells["nombre_completo"].Value.ToString();
                    formPadre.montoMensual = dataGridViewPágos.SelectedRows[0].Cells["monto_mensual"].Value.ToString();
                    formPadre.saldoActual = dataGridViewPágos.SelectedRows[0].Cells["saldo_actual"].Value.ToString();
                    formPadre.fecha = dataGridViewPágos.SelectedRows[0].Cells["fecha"].Value.ToString();
                    formPadre.concepto = dataGridViewPágos.SelectedRows[0].Cells["concepto"].Value.ToString();
                    formPadre.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al asignar valores de fila seleccionada: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila antes de continuar con el proceso de edición");
            }

        }
                        

        private void CargarTablaPagos()
        {
            try
            {
                DataTable dtPagos = cnPagos.ObtenerPagos();

                dataGridViewPágos.DataSource = dtPagos;
                dataGridViewPágos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                // Personalizar la tabla para mostrar los datos de forma más presentable
                dataGridViewPágos.Columns["id"].HeaderText = "ID";
                dataGridViewPágos.Columns["padre_id"].HeaderText = "N. documento";
                dataGridViewPágos.Columns["nombre_completo"].HeaderText = "Nombre";
                dataGridViewPágos.Columns["monto_mensual"].HeaderText = "Monto Mensual";
                dataGridViewPágos.Columns["monto_abonado"].HeaderText = "Monto Abonado";
                dataGridViewPágos.Columns["saldo_actual"].HeaderText = "Saldo Actual";
                dataGridViewPágos.Columns["fecha"].HeaderText = "Fecha";
                dataGridViewPágos.Columns["concepto"].HeaderText = "Detalles";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla de pagos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {
            CargarTablaPagos();
        }


    }
}
