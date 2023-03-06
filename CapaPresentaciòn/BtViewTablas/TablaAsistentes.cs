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


        private string _Id;
        public string Id
        {
            get { return _Id; }
            set { _Id = value; textBoxNumAsistente.Text = _Id; }
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
    }
}
