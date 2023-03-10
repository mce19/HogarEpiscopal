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
    public partial class TablaGrupos : Form
    {
        CNGrupos objeto = new CNGrupos();
        public TablaGrupos()
        {
            InitializeComponent();

        }

        private string _Id;
        public string Id
        {
            get { return _Id; }
            set { _Id = value; textBoxIdGrupo.Text = _Id; }
        }

        private string _titulo;
        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; TxtTitTablaGrupo.Text = _titulo; }
        }

        private string _nombreG;
        public string nombreG
        {
            get { return _nombreG; }
            set { _nombreG = value; textBoxNombreGrupo.Text = _nombreG; }
        }
        private void textBoxIdGrupo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombreGrupo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTitTablaGrupo_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TablaGrupos_Load(object sender, EventArgs e)
        {
            if (Titulo == "Editar Grupo")
            {
                textBoxIdGrupo.Visible = false;
                label1.Visible = false;
            }
            else
            {
                textBoxIdGrupo.Visible = true;
            }
        }

        private void buttonGuardarGrupo_Click(object sender, EventArgs e)
        {

            // Validar datos de entrada
            if (!string.IsNullOrEmpty(textBoxIdGrupo.Text) && !string.IsNullOrEmpty(textBoxNombreGrupo.Text))
            {
              
                // Crear objeto padre
                int numeroDocumento;
                if (!int.TryParse(textBoxIdGrupo.Text, out numeroDocumento))
                {
                    MessageBox.Show("El número de documento debe ser un valor numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int Id = numeroDocumento;
                string Nombre = textBoxNombreGrupo.Text;
          
         
            
                if (Titulo == "Editar Grupo")
                {

                    objeto.ActualizarGrupo(Id, Nombre);
                   
                }
                else
                {
                    objeto.InsertarGrupo(Id, Nombre);
                }

                // Mensaje de éxito
                MessageBox.Show("Grupo guardado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cerrar formulario
                this.Close();
            }

            else
            {
                // Mostrar mensaje de error
                MessageBox.Show("Por favor, ingresa todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
