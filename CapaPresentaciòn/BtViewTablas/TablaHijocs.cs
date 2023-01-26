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
        public TablaHijocs()
        {
            InitializeComponent();
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
            if (!string.IsNullOrEmpty(textBoxNumDocuHijo.Text) && !string.IsNullOrEmpty(textBoxnNombCompletoHijo.Text) && !string.IsNullOrEmpty(dateTimePickerHijo.Text) && !string.IsNullOrEmpty(textBoxEdadHijo.Text) && !string.IsNullOrEmpty(comboBoxGeneroHijo.Text) && !string.IsNullOrEmpty(comboBoxSegInicHijo.Text) && !string.IsNullOrEmpty(comboBoxSubsidHijos.Text) && !string.IsNullOrEmpty(textBoxPadreId.Text))
            {
              
                // Crear objeto padre
                int numeroDocumento;
                if (!int.TryParse(textBoxNumDocuHijo.Text, out numeroDocumento))
                {
                    MessageBox.Show("El número de documento debe ser un valor numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Hijos hijo = new Hijos
                {

                    NumeroDocumento = numeroDocumento,
                    NombreCompleto = textBoxnNombCompletoHijo.Text,
                    FechaNacimiento = dateTimePickerHijo.Value,
                    Edad = textBoxEdadHijo.Text,
                    Genero = comboBoxGeneroHijo.Text,
                    SegunInec = comboBoxSegInicHijo.Text,
                    Subsidio = comboBoxSubsidHijos.Text,
                    PadreId = textBoxPadreId.TabIndex,
                };

                //utilizando la función Regex.IsMatch() para buscar cualquier caracter que no sea una letra o un número en cada uno de los campos del formulario. 
                if (Regex.IsMatch(hijo.NumeroDocumento.ToString(), @"[^0-9]") || Regex.IsMatch(hijo.NombreCompleto, @"[^a-zA-Z\s]")
     || Regex.IsMatch(hijo.Edad, @"[^0-9]")
     || Regex.IsMatch(hijo.Genero, @"[^a-zA-Z\s]") || Regex.IsMatch(hijo.SegunInec, @"[^a-zA-Z\s]")
     || Regex.IsMatch(hijo.Subsidio, @"[^a-zA-Z\s]") || Regex.IsMatch(hijo.PadreId.ToString(), @"[^0-9]"))
                {
                    MessageBox.Show("No se permiten caracteres especiales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                /* Validar inyección SQL
                if (hijo.NumeroDocumento.ToString().Contains("'") || hijo.NombreCompleto.Contains("--") || hijo.NombreCompleto.Contains("'") || hijo.NombreCompleto.Contains("--") || hijo.Direccion.Contains("'") || hijo.Direccion.Contains("--") || hijo.Telefono.Contains("'") || hijo.Telefono.Contains("--"))
                {
                    MessageBox.Show("No se permiten caracteres especiales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                */
                // Guardar datos en la base de datos
                CNHijos objeto = new CNHijos();
                if (labelnombreHijos.Text == "Editar Hijo")
                {
                    //objeto.EditarHijos(hijo);
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
    }
}
