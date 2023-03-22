using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentaciòn.BtViewTablas
{
    public partial class TablaPadre : Form
    {
        private string _tituloTabla;
        public string TituloTabla
        {
            get { return _tituloTabla; }
            set
            {
                _tituloTabla = value;
                TxtTitTablaPadre.Text = _tituloTabla;
            }
        }

        private string _tipoDocumento;
        public string TipoDocumento
        {
            get { return _tipoDocumento; }
            set { _tipoDocumento = value; textBoxTipoDucumento.Text = value; }
        }

        private string _numeroDocumento;
        public string NumeroDocumento
        {
            get { return _numeroDocumento; }
            set { _numeroDocumento = value; textBoxNunDocumento.Text = value; }
        }

        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; textBoxNombre.Text = value; }
        }

        private string _telefono;
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; textBoxTelefono.Text = value; }
        }

        private string _direccion;
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; maskedTextBoxDireccion.Text = value; }
        }

        public TablaPadre()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TablaPadre_Load(object sender, EventArgs e)
        {

        }

        public void textBoxNunDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardarPadre_Click(object sender, EventArgs e)
        {

            // Validar datos de entrada
            if (!string.IsNullOrEmpty(textBoxTipoDucumento.Text) && !string.IsNullOrEmpty(textBoxNunDocumento.Text) && !string.IsNullOrEmpty(textBoxNombre.Text) && !string.IsNullOrEmpty(maskedTextBoxDireccion.Text) && !string.IsNullOrEmpty(textBoxTelefono.Text))
            {
                // Validar que el tipo de documento solo contenga letras
                if (!Regex.IsMatch(textBoxTipoDucumento.Text, @"^[a-zA-Z]+$"))
                {
                    MessageBox.Show("El tipo de documento solo debe contener letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar que el teléfono solo contenga números
                if (!Regex.IsMatch(textBoxTelefono.Text, @"^[0-9]+$"))
                {
                    MessageBox.Show("El teléfono solo debe contener números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear objeto padre
                int numeroDocumento;
                if (!int.TryParse(textBoxNunDocumento.Text, out numeroDocumento))
                {
                    MessageBox.Show("El número de documento debe ser un valor numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Padres padre = new Padres
                {
                    TipoDocumento = textBoxTipoDucumento.Text,
                    NumeroDocumento = numeroDocumento,
                    NombreCompleto = textBoxNombre.Text,
                    Direccion = maskedTextBoxDireccion.Text,
                    Telefono = textBoxTelefono.Text
                };
                // Validar inyección SQL
                if (padre.TipoDocumento.Contains("'") || padre.TipoDocumento.Contains("--") || padre.NombreCompleto.Contains("'") || padre.NombreCompleto.Contains("--") || padre.Direccion.Contains("'") || padre.Direccion.Contains("--") || padre.Telefono.Contains("'") || padre.Telefono.Contains("--"))
                {
                    MessageBox.Show("No se permiten caracteres especiales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Guardar datos en la base de datos
                CNPadres objeto = new CNPadres();
                if (TxtTitTablaPadre.Text == "Editar Padre")
                {
                    objeto.EditarPadre(padre);
                    MessageBox.Show("El padre a sido actualizado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    objeto.AgregarPadre(padre);

                    // Mensaje de éxito
                    MessageBox.Show("Padre guardado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Preguntar si desea agregar un hijo
                    DialogResult result = MessageBox.Show("¿Desea agregar un hijo?", "Agregar hijo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Si el usuario hace clic en "Sí"
                    if (result == DialogResult.Yes)
                    {
                        TablaHijocs formHijos = new TablaHijocs();
                        formHijos.Show();
                        formHijos.PadreId = numeroDocumento;
                        formHijos.TituloTabla = "Agregar un nuevo hijo";
                    }

                }

                // Cerrar formulario
                this.Close();
            }
            else
            {
                // Mostrar mensaje de error
                MessageBox.Show("Por favor, ingresa todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

                public void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        public void maskedTextBoxDireccion_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        public void TxtTitTablaPadre_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelarPago_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
