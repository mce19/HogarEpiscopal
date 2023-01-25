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
    }
}
