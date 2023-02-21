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

namespace CapaPresentaciòn.BtViewTablas
{
    public partial class TablaPagos : Form
    {

        private CNPagos cnPagos = new CNPagos();

        private string _id;
        public string Id
        {
            get { return _id; }
            set { _id = value; textBoxId.Text = value; }
        }

        private string _idPadre;
        public string idPadre
        {
            get { return _idPadre; }
            set { _idPadre = value; textBoxPadre.Text = value; }
        }
        public TablaPagos()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TablaPagos_Load(object sender, EventArgs e)
        {

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPadre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxnMensual_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAbono_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPendiente_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDetalles_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardarPago_Click(object sender, EventArgs e)
        {

            try
            {
                int id = int.Parse(textBoxId.Text);
                int padreId = int.Parse(textBoxPadre.Text);
                decimal montoMensual = decimal.Parse(textBoxnMensual.Text);
                decimal montoAbonado = decimal.Parse(textBoxAbono.Text);
                decimal montoRestante = montoMensual - montoAbonado;
                decimal saldoActual = 0;

                if (montoAbonado == 0)
                {
                    saldoActual = montoMensual;
                }
                else if (montoAbonado > 0 && montoAbonado < montoMensual)
                {
                    saldoActual = montoRestante;
                }
                else if (montoAbonado == montoMensual)
                {
                    saldoActual = 0;
                }

                DateTime fecha = dateTimeFecha.Value;
                string detalles = textBoxDetalles.Text;

                bool insertarPago = cnPagos.InsertarPago(id, padreId, montoMensual, montoAbonado, montoRestante, saldoActual, fecha, detalles);

                if (insertarPago)
                {
                    MessageBox.Show("Pago ingresado correctamente.");
                }
                else

                    MessageBox.Show("Error al ingresar el pago.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private void buttonCancelarPago_Click(object sender, EventArgs e)
        {

        }
    }
}
