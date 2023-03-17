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
    public partial class TablaAsistentes : Form
    {
        public TablaAsistentes()
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

        private string _Id;
        public string Id
        {
            get { return _Id; }
            set { _Id = value; textId.Text = _Id; }
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



        private void buttonGuardarAsistente_Click(object sender, EventArgs e)
        {

            // Obtener los valores de los controles de la interfaz de usuario
            int id = int.Parse(textId.Text);
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

            // Llamar al método AgregarAsistente de la instancia gestorAsistentes
            if (Titulo == "Editar asistente")
            {
                gestorAsistentes.ActualizarAsistente(id, numerodocumento, nombreCompleto, docenteId);
                MessageBox.Show("El asistente se ha actualizado correctamente.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                gestorAsistentes.AgregarAsistente(numerodocumento, nombreCompleto, docenteId);
                MessageBox.Show("El asistente se ha guardado correctamente.", "Guardado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Cerrar el formulario
            this.Close();


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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TablaAsistentes_Load(object sender, EventArgs e)
        {

        }

        private void textTitulo_Click(object sender, EventArgs e)
        {

        }

      

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
