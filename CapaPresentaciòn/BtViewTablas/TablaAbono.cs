using CapaEntidad;
using CapaNegocio;
using CapaPresentaciòn.BtControles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentaciòn.BtViewTablas
{
    public partial class TablaAbono : Form
    {
        private Bienvenida formPadre;
        private string _nombrepa;
        public string nombrepadre
        {
            get { return _nombrepa; }
            set { _nombrepa = value; nombrepadres.Text = value; }
        }

        private string _padreId;
        public string padreId
        {
            get { return _padreId; }
            set { _padreId = value; textBoxPadreId.Text = value; }
        }

        private string _id;
        public string Id
        {
            get { return _id; }
            set { _id = value; textBoxId.Text = value; }
        }


        private string _nombre;
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; textBoxnombre.Text = value; }
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

        public TablaAbono()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
      
        private void namepadre_Load(object sender, EventArgs e)
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

        private void dateTimeFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDetalles_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardarPago_Click(object sender, EventArgs e)
        {
            CNPagos pagosNegocio = new CNPagos();

            try
            {
                int id = int.Parse(textBoxId.Text);
                int padreId = int.Parse(textBoxPadreId.Text);
                
                decimal montoMensual = decimal.Parse(textBoxnMensual.Text);
                decimal montoAbonado = decimal.Parse(textBoxAbono.Text);
                decimal saldoActual = decimal.Parse(textBoxSaldo.Text);
                DateTime fecha = dateTimeFecha.Value;
                string detalles = textBoxDetalles.Text;

                int ids = int.Parse(textBoxId.Text);
                int padreIds = int.Parse(textBoxPadreId.Text);
                string nombrePadres = textBoxnombre.Text;
                decimal montoMensuals = decimal.Parse(textBoxnMensual.Text);
                decimal montoAbonados = decimal.Parse(textBoxAbono.Text);
                decimal saldoActuals = decimal.Parse(textBoxSaldo.Text);
                DateTime fechas = dateTimeFecha.Value;
                string detalless = textBoxDetalles.Text;

                // Validación de los datos para prevenir inyecciones SQL
                if (detalles.Contains("'"))
                {
                    throw new Exception("El campo 'Detalles' no puede contener el carácter '");
                }

                if (montoAbonado < 0)
                {
                    throw new Exception("El monto abonado no puede ser negativo");
                }

                if (montoAbonado > saldoActual && montoAbonado != montoMensual)
                {
                    throw new Exception("El monto abonado no puede ser mayor al saldo actual, a menos que se abone el total del mes");
                }

                if (saldoActual - montoAbonado < 0 && montoAbonado != montoMensual)
                {
                    throw new Exception("El saldo actual no puede ser negativo, a menos que se abone el total del mes");
                }

                // Cálculo de los nuevos valores según si se abona el total o no
                decimal saldoNuevo = saldoActual - montoAbonado;
                decimal saldoNuevos = saldoActuals - montoAbonados;
                decimal saldoabono = saldoActuals;

               

                if (saldoNuevo == 0)
                {
                    decimal saldo = montoMensual;
                    montoAbonado = 0; // El monto abonado es cero cuando se cancela el total
                    DateTime siguienteMes = fecha.AddMonths(1);
                    DateTime mes = fecha.AddMonths(0);
                    pagosNegocio.ActualizarPago(id, padreId, montoAbonado, saldo, siguienteMes, detalles);
                    pagosNegocio.InsertarPagoEnHistorial( padreId, montoMensual, fecha);
                    // Llamada al método para generar la factura
                    GenerarFactura(ids, padreIds, nombrePadres, montoMensuals, saldoabono, montoAbonados, fechas, detalless);
                }
                else {

                    // Actualización de los datos en la base de datos
                    pagosNegocio.ActualizarPago(id, padreId, montoAbonado, saldoNuevo, fecha, detalles);
                    GenerarFacturaAbono(ids, padreIds, nombrePadres, montoMensuals, saldoabono, montoAbonados, saldoNuevos, fechas, detalless);

                }

              

                MessageBox.Show("Pago guardado correctamente");

              
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el pago: " + ex.Message);
            }
        }

        private void buttonCancelarPago_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ImprimirFactura(string factura)
        {
            // Aquí puedes implementar la lógica para imprimir la factura
            // Puedes usar la clase PrinterSettings y PrintDocument de C# para imprimir

            // Mostrar el diálogo de impresión
            PrintDialog printDialog = new PrintDialog();
            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Configurar la impresora y el documento
                PrinterSettings printerSettings = printDialog.PrinterSettings;
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrinterSettings = printerSettings;
                printDocument.PrintPage += (sender, e) => {
                    e.Graphics.DrawString(factura, new Font("Arial Bold", 10), Brushes.Black, new PointF(0, 0));
                };

                // Imprimir el documento
                printDocument.Print();
            }
        }


        private void GenerarFactura(int ids, int padreIds, string nombrePadres, decimal montoMensuals, decimal saldoabono,  decimal montoAbonados, DateTime fechas, string detalless)
        {
           
            StringBuilder factura = new StringBuilder();
           
           
            factura.AppendLine("FACTURA\n");
            factura.AppendLine("Hogar Escuela Episcopal\n");
            factura.AppendLine("-------------------\n");
            factura.AppendLine("Codigo del abonado: " + "\n" + ids.ToString()+ "\n");
            factura.AppendLine("N. documento del padre: " + "\n" + padreIds.ToString() + "\n");
            factura.AppendLine("Nombre del familiar: " + "\n" + nombrePadres + "\n");
            factura.AppendLine("Monto mensual: " + "\n" + montoMensuals.ToString("F2") + "\n");
            factura.AppendLine("Saldo actual pendiente: " + "\n" + saldoabono.ToString("F2") + "\n");
            factura.AppendLine("Monto abonado: " + "\n" + montoAbonados.ToString("F2") + "\n");
            factura.AppendLine("Cancélo la fecha de : " + "\n" + fechas.ToString("dd/MM/yyyy") + "\n");
            factura.AppendLine("Detalles: " + "\n" +  detalless + "\n");
            factura.AppendLine("\n");
            factura.AppendLine("Gracias");

            // Mostrar la factura en un cuadro de diálogo antes de imprimir
            DialogResult result = MessageBox.Show(factura.ToString(), "Factura", MessageBoxButtons.OK);

            // Llamada a un método para imprimir la factura
            if (result == DialogResult.OK)
            {
                // Llamada a un método para imprimir la factura
                ImprimirFactura(factura.ToString());
            }
            else
            {
                // El usuario canceló la impresión
            }
        }




        private void GenerarFacturaAbono(int ids, int padreIds, string nombrePadres, decimal montoMensuals, decimal saldoabono,  decimal montoAbonados, decimal saldoActuals, DateTime fechas, string detalless)
        {
            StringBuilder factura = new StringBuilder();
            
            factura.AppendLine("FACTURA\n");
            factura.AppendLine("Hogar Escuela Episcopal\n");
            factura.AppendLine("------------------\n");
            factura.AppendLine("Codigo del abonado: " + "\n" + ids.ToString() + "\n");
            factura.AppendLine("N. documento del padre: " + "\n" + padreIds.ToString() + "\n");
            factura.AppendLine("Nombre del familiar: " + "\n" + nombrePadres + "\n");
            factura.AppendLine("Monto mensual: " + "\n" + montoMensuals.ToString("F2") + "\n");
            factura.AppendLine("Saldo actual pendiente: " + "\n" + saldoabono.ToString("F2") + "\n");
            factura.AppendLine("Monto abonado: " + "\n" + montoAbonados.ToString("F2") + "\n");
            factura.AppendLine("Saldo actual: " + "\n" + saldoActuals.ToString("F2") + "\n");
            factura.AppendLine("Abono en la fecha de : " + "\n" + fechas.ToString("dd/MM/yyyy") + "\n");
            factura.AppendLine("Detalles: " + "\n" + detalless + "\n");
            factura.AppendLine("\n");
            factura.AppendLine("Gracias");

            // Mostrar la factura en un cuadro de diálogo antes de imprimir
            DialogResult result = MessageBox.Show(factura.ToString(), "Factura", MessageBoxButtons.OK);

            // Llamada a un método para imprimir la factura
            if (result == DialogResult.OK)
            {
                // Llamada a un método para imprimir la factura
                ImprimirFactura(factura.ToString());
            }
            else
            {
                // El usuario canceló la impresión
            }

        }

        private void textBoxnombre_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void nombrepadres_Click(object sender, EventArgs e)
        {

        }

        private void TablaAbono_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void textBoxPadreId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
