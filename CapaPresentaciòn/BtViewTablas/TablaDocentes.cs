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
    public partial class TablaDocentes : Form
    {
        CNDocente objeto = new CNDocente();
        public TablaDocentes()
        {
            InitializeComponent();
        }

        private string _Id;
        public string Id
        {
            get { return _Id; }
            set { _Id = value; textBoxNunDocente.Text = _Id; }
        }

        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; textBoxNombreDocente.Text = _Nombre; }
        }


        private string _Direccion;
        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; TextBoxDireccionDocente.Text = _Direccion; }
        }

        private string _Telefono;
        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; textBoxTelefonoDocente.Text = _Telefono; }
        }

        private string _IdGrupo;
        public string IdGrupo
        {
            get { return _IdGrupo; }
            set { _IdGrupo = value; textBoxGrupoDocente.Text = _IdGrupo; }
        }

        private string _Titulo;
        public string Titulo
        {
            get { return _Titulo; }
            set { _Titulo = value; textTitulo.Text = _Titulo; }
        }
        private void textBoxNunDocente_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombreDocente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxDireccionDocente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBoxTelefonoDocente_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGrupoDocente_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardaDocente_Click(object sender, EventArgs e)
        {
            //agreggar nuevo 
            // Validar datos de entrada
            if (!string.IsNullOrEmpty(textBoxNunDocente.Text) && !string.IsNullOrEmpty(textBoxNombreDocente.Text))
            {

                // Crear objeto padre
                int numeroDocumento;
                if (!int.TryParse(textBoxNunDocente.Text, out numeroDocumento))
                {
                    MessageBox.Show("El número de documento debe ser un valor numérico y no mayor de 9 digitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(TextBoxDireccionDocente.Text))
                {
                    MessageBox.Show("Por favor, ingresa la dirección del docente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBoxTelefonoDocente.Text) || !long.TryParse(textBoxTelefonoDocente.Text, out long telefono) || textBoxTelefonoDocente.Text.Length != 8)
                {
                    MessageBox.Show("Por favor, ingresa un número de teléfono válido (8 dígitos)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                int id = numeroDocumento;
                string nombre = textBoxNombreDocente.Text;
                string direccion = TextBoxDireccionDocente.Text;
               // string  telefono = textBoxTelefonoDocente.Text;
                int grupo = int.Parse(textBoxGrupoDocente.Text);




                if (Titulo == "Editar docente")
                {

                   objeto.ActualizarDocente(id, nombre, direccion, telefono.ToString(), grupo);
                    // Mensaje de éxito
         

                }
                else
                {
                    objeto.InsertarDocente(id, nombre, direccion, telefono.ToString(), grupo);
                    // Mensaje de éxito
                    MessageBox.Show("Docente guardado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TablaDocentes_Load(object sender, EventArgs e)
        {

        }

        private void textTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
