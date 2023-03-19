using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentaciòn.BtViewTablas
{
    public partial class GuardarAistente : Form
    {
        public GuardarAistente()
        {
            InitializeComponent();
        }

        private string _Titulo;
        public string Titulo
        {
            get { return _Titulo; }
            set { _Titulo = value; textTitulo.Text = _Titulo; }
        }

        private string _NumDocumento;
        public string NumDocumento
        {
            get { return _NumDocumento; }
            set { _NumDocumento = value; textBoxNumAsistente.Text = _NumDocumento; }
        }

        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; textBoxNombreAsistente.Text = _Nombre; }
        }



        private string _Docente;
        public string IdDocente
        {
            get { return _Docente; }
            set { _Docente = value; txtIdDocente.Text = _Docente; }
        }

        private void textBoxNumAsistente_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombreAsistente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdDocente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de los controles de la interfaz de usuario
                int numerodocumento = int.Parse(textBoxNumAsistente.Text);
                string nombreCompleto = textBoxNombreAsistente.Text;
                int docenteId = 0;
                if (int.TryParse(txtIdDocente.Text, out int result))
                {
                    docenteId = result;
                }

                // Crear una instancia de la clase GestorAsistentes
                CNAsistente gestorAsistentes = new CNAsistente();

                // Llamar al método AgregarAsistente de la instancia gestorAsistentes
                if (Titulo == "Nuevo asistente")
                {
                    gestorAsistentes.AgregarAsistente(numerodocumento, nombreCompleto, docenteId);
                    MessageBox.Show("El asistente se ha guardado correctamente.", "Guardado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Cerrar el formulario
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
