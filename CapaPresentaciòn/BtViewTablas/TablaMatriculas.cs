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
    public partial class TablaMatriculas : Form
    {

        CNMatricula objeto = new CNMatricula();
        public TablaMatriculas()
        {
            InitializeComponent();
        }

        private string _Titulo;
        public string Titulo
        {
            get { return _Titulo; }
            set { _Titulo = value; TxtTitTablaMatricula.Text = _Titulo; }
        }


        private string _Id;
        public string Id
        {
            get { return _Id; }
            set { _Id = value; textId.Text = _Id; }
        }


        private string _Hijo;
        public string IdHijo
        {
            get { return _Hijo; }
            set { _Hijo = value; textCedHijo.Text = _Hijo; }
        }

        private string _Padre;
        public string IdPadre
        {
            get { return _Padre; }
            set { _Padre = value; textCedPadre.Text = _Padre; }
        }

        private string _Docente;
        public string IdDocente
        {
            get { return _Docente; }
            set { _Docente = value; textCedDocente.Text = _Docente; }
        }

        private string _Grupo;
        public string IdGrupo
        {
            get { return _Grupo; }
            set { _Grupo = value; textIdGrpo.Text = _Grupo; }
        }
        private void textId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCedHijo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextCedPadre_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textCedDocente_TextChanged(object sender, EventArgs e)
        {

        }

        private void textIdGrupo_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TablaMatriculas_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuardaDocente_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(textId.Text) ||
                string.IsNullOrWhiteSpace(textCedHijo.Text) ||
                string.IsNullOrWhiteSpace(textCedPadre.Text) ||
                string.IsNullOrWhiteSpace(textCedDocente.Text) ||
                string.IsNullOrWhiteSpace(textIdGrpo.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Validar que los campos tengan valores numéricos
            int id, hijoId, padreId, docenteId, grupoId;
            if (!int.TryParse(textId.Text, out id) ||
                !int.TryParse(textCedHijo.Text, out hijoId) ||
                !int.TryParse(textCedPadre.Text, out padreId) ||
                !int.TryParse(textCedDocente.Text, out docenteId) ||
                !int.TryParse(textIdGrpo.Text, out grupoId))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
                return;
            }

            // Llamar al método de la capa de negocios para actualizar la matrícula
            bool resultado = false;
            try
            {
                resultado = objeto.ActualizarMatricula(id, hijoId, padreId, docenteId, grupoId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la matrícula: " + ex.Message);
                return;
            }

            if (resultado)
            {
                MessageBox.Show("Matrícula actualizada correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar la matrícula.");
            }
        }
    }
}
