using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentaciòn.BtControles
{
    public partial class UserNinnos : UserControl
    {
        public UserNinnos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewPadresMatricula_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBoxNumPadre.Text = dataGridViewPadresMatricula.Rows[e.RowIndex].Cells["numero_documento"].Value.ToString();
                textBoxNumHijo.Text = dataGridViewPadresMatricula.Rows[e.RowIndex].Cells["nombre_completo"].Value.ToString();
                textBoxNombPadre.Text = dataGridViewPadresMatricula.Rows[e.RowIndex].Cells["nombre_completo"].Value.ToString();
                textBoxNombHijo.Text = dataGridViewPadresMatricula.Rows[e.RowIndex].Cells["nombre_completo"].Value.ToString();
            }
        }

        private void buttonCargarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                CapaDatos.CDMatricula objCDMatricula = new CapaDatos.CDMatricula();
                DataTable dt = objCDMatricula.ListarMatriculados();
                dataGridViewPadresMatricula.DataSource = dt;
                buttonCargarDatos.BackColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonCargarDatos.BackColor = Color.Red;
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
