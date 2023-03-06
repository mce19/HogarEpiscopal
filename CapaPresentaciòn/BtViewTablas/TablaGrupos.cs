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
    public partial class TablaGrupos : Form
    {
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

        }
    }
}
