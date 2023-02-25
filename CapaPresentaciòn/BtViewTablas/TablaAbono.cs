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
    public partial class TablaAbono : Form
    {
        private string _nombrepa;
        public string nombrepadre
        {
            get { return _nombrepa; }
            set { _nombrepa = value; nombrepadres.Text = value; }
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

        private string _montoRestante;
        public string montoRestante
        {
            get { return _montoRestante; }
            set { _montoRestante = value; textBoxPendiente.Text = value; }
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
        private static bool formularioAbierto = false; // creamos al varibale
        private void namepadre_Load(object sender, EventArgs e)
        {
            formularioAbierto = true;//validamos que el formulario este abierto
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

        }

        private void buttonCancelarPago_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxnombre_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void nombrepadres_Click(object sender, EventArgs e)
        {

        }

        private void TablaAbono_FormClosing(object sender, FormClosingEventArgs e)
        {
            formularioAbierto = false;  //validamos si esta cerrado
        }

        public static bool FormularioAbierto()
        {
            return formularioAbierto;   //retornamos el formularioabierto
        }

    }
}
