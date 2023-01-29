using CapaEntidad;
using CapaNegocio;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentaciòn.BtViewTablas
{
    public partial class TablaHijocs : Form
    {

        private string _labelnombreHijos;
        public string TituloTabla
        {
            get { return _labelnombreHijos; }
            set
            {
                _labelnombreHijos = value;
                labelnombreHijos.Text = _labelnombreHijos;
            }
        }

        private string _numeroDocumento;
        public string NumeroDocumento
        {
            get { return _numeroDocumento; }
            set { _numeroDocumento = value; textBoxNumDocuHijo.Text = value; }
        }

        private string _nombreCompleto;
        public string NombreCompleto
        {
            get { return _nombreCompleto; }
            set { _nombreCompleto = value; textBoxnNombCompletoHijo.Text = _nombreCompleto; }
        }

        private DateTime _fechaNacimiento;
        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; dateTimePickerHijo.Value = _fechaNacimiento; }
        }

        private string _edad;
        public string Edad
        {
            get { return _edad; }
            set { _edad = value; textBoxEdadHijo.Text = value; }
        }

        private string _genero;
        public string Genero
        {
            get { return _genero; }
            set { _genero = value; comboBoxGeneroHijo.Text = _genero; }
        }

        private string _segunInec;
        public string SegúnInec
        {
            get { return _segunInec; }
            set { _segunInec = value; comboBoxSegInicHijo.Text = _segunInec; }
        }

        private string _subsidio;
        public string Subsidio
        {
            get { return _subsidio; }
            set { _subsidio = value; comboBoxSubsidHijos.Text = _subsidio; }
        }

        private int _padreId;
        public int PadreId
        {
            get { return _padreId; }
            set { _padreId = value; textBoxPadreId.Text = _padreId.ToString(); }
        }
        public TablaHijocs()
        {
            InitializeComponent();
            dateTimePickerHijo.ValueChanged += new EventHandler(dateTimePickerHijo_ValueChanged);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TablaHijocs_Load(object sender, EventArgs e)
        {

        }

        private void labelnombreHijos_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardarHijo_Click(object sender, EventArgs e)
        {
            // Validar datos de entrada
            if (!string.IsNullOrEmpty(textBoxnNombCompletoHijo.Text) && !string.IsNullOrEmpty(dateTimePickerHijo.Text) && !string.IsNullOrEmpty(textBoxEdadHijo.Text))
            {
                // Crear objeto hijo
                Hijos hijo = new Hijos
                {
                    NombreCompleto = textBoxnNombCompletoHijo.Text,
                    FechaNacimiento = dateTimePickerHijo.Value,
                    Edad = textBoxEdadHijo.Text
                };
                // Validar inyección SQL
                if (hijo.NombreCompleto.Contains("'") || hijo.NombreCompleto.Contains("--"))
                {
                    MessageBox.Show("No se permiten caracteres especiales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Guardar datos en la base de datos
                CNHijos objeto = new CNHijos();
                if (labelnombreHijos.Text == "Editar Hijo")
                {
                    objeto.EditarHijo(hijo);
                }
                else
                {
                    objeto.AgregarHijos(hijo);
                }

                // Mensaje de éxito
                MessageBox.Show("Hijo guardado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cerrar formulario
                this.Close();
            }
            else
            {
                // Mostrar mensaje de error
                MessageBox.Show("Por favor, ingresa todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNumDocuHijo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerHijo_ValueChanged(object sender, EventArgs e)
        {
            var fechaNacimiento = dateTimePickerHijo.Value;
            var hoy = DateTime.Today;
            var edad = hoy.Year - fechaNacimiento.Year;
            if (fechaNacimiento > hoy.AddYears(-edad)) edad--;
            textBoxEdadHijo.Text = edad.ToString();
        }
    }
}
