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

        private string _montoMensual;
        public string montoMensual
        {
            get { return _montoMensual; }
            set { _montoMensual = value; textBoxnMensual.Text = value; }
        }

        private string _montoAbonado;
        public string montoAbonado
        {
            get { return _montoAbonado; }
            set { _montoAbonado = value; textBoxAbono.Text = value; }
        }

        private string _saldoActual;
        public string saldoActual
        {
            get { return _saldoActual; }
            set { _saldoActual = value; textBoxSaldo.Text = value; }
        }

        private string _fecha;
        public string fecha
        {
            get { return _fecha; }
            set { _fecha = value; dateTimeFecha.Value = Convert.ToDateTime(value); }
        }

        private string _concepto;
        public string concepto
        {
            get { return _concepto; }
            set { _concepto = value; textBoxDetalles.Text = value; }
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

        public void textBoxSaldo_TextChanged(object sender, EventArgs e)
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
        decimal montoAbonado;

        if (!decimal.TryParse(textBoxAbono.Text, out montoAbonado))
        {
            montoAbonado = 0;
        }

        decimal saldoActual = montoMensual - montoAbonado;

        if (montoAbonado == 0)
        {
            saldoActual = montoMensual;
        }
        else if (montoAbonado == montoMensual)
        {
            saldoActual = 0;
        }

        DateTime fecha = dateTimeFecha.Value;
        string detalles = textBoxDetalles.Text;

        // Si se cancela todo, se guarda el pago en ambas tablas
        if (saldoActual == 0)
        {
                    decimal saldo = montoMensual;
                    DateTime siguienteMes = fecha.AddMonths(1);
                    // Insertar pago en tabla Pagos
                    bool insertarPago = cnPagos.InsertarPago(id, padreId, montoMensual, 0, saldo, siguienteMes, detalles);
            if (!insertarPago)
            {
                MessageBox.Show("Error al ingresar el pago en la tabla Pagos.");
                return;
            }

                    // Insertar pago en tabla Historial_Pagos

                    string nombreMes = fecha.ToString("MMMM");
                    bool insertarPagoEnHistorial = cnPagos.InsertarPagoEnHistorial( padreId, montoMensual, fecha);
            if (!insertarPagoEnHistorial)
            {
                MessageBox.Show("Error al ingresar el pago en la tabla Historial_Pagos.");
                return;
            }

            MessageBox.Show("Pago ingresado correctamente.");
            this.Close();
        }
        else // Si se abona, se guarda el pago solamente en tabla Pagos
        {
            decimal saldoPendiente = montoMensual - montoAbonado;
            bool insertarPago = cnPagos.InsertarPago(id, padreId, montoMensual, montoAbonado, saldoPendiente, fecha, detalles);

            if (insertarPago)
            {
                MessageBox.Show("Pago ingresado correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al ingresar el pago.");
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error: " + ex.Message);
    }

        }

        private void buttonCancelarPago_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
