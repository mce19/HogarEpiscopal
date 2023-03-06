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
