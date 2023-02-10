using CapaDatos;
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

namespace CapaPresentaciòn.BtControles
{
    public partial class UserPadres : UserControl
    {
        public UserPadres()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void NumMujeres_Click(object sender, EventArgs e)
        {

        }

        private void NumHombres_Click(object sender, EventArgs e)
        {

        }

        private void NumPani_Click(object sender, EventArgs e)
        {

        }

        private void UserPadres_Load(object sender, EventArgs e)
        {
            CDGrupos cdGrupos = new CDGrupos();
            DataTable dt = cdGrupos.ListarNombresGrupos();

            comboBoxGrupos.DataSource = dt;
            comboBoxGrupos.DisplayMember = "nombre";

            // Set the column names for the data grid view
            dataGridViewGrupos.Columns[0].HeaderText = "Cédula";
            dataGridViewGrupos.Columns[1].HeaderText = "Nombre Completo";
            dataGridViewGrupos.Columns[2].HeaderText = "Fecha nacimiento";
            dataGridViewGrupos.Columns[3].HeaderText = "Edad";
            dataGridViewGrupos.Columns[4].HeaderText = "Género";
            dataGridViewGrupos.Columns[5].HeaderText = "Subsidio";
        }

        private void dataGridViewGrupos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CNGrupos cDGrupos = new CNGrupos();
            DataTable dtNombresGrupos = cDGrupos.ListarNombresGrupos();
           

            comboBoxGrupos.DataSource = dtNombresGrupos;
            comboBoxGrupos.DisplayMember = "nombre";
        }

        private void comboBoxGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CDGrupos cdGrupos = new CDGrupos();
            DataRowView drv = comboBoxGrupos.SelectedItem as DataRowView;
            string groupName = drv["nombre"].ToString();
            DataTable dataTable = cdGrupos.ListarInformacionPorGrupo(groupName);

            dataGridViewGrupos.DataSource = dataTable;
            int numHombres = 0;
            int numMujeres = 0;
            int numPani = 0;
            int numImas = 0;
            int numPrivados = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                if (row["genero"].ToString().ToUpper() == "M")
                {
                    numHombres++;
                }
                else if (row["genero"].ToString().ToUpper() == "F")
                {
                    numMujeres++;
                }

                if (row["Subsidio"].ToString().ToUpper() == "IMAS")
                {
                    numImas++;
                }
                else if (row["Subsidio"].ToString().ToUpper() == "PANI")
                {
                    numPani++;
                }
                else if (row["Subsidio"].ToString().ToUpper() == "PRIVADO")
                {
                    numPrivados++;
                }

            }

            NumHombres.Text = numHombres.ToString();
            NumMujeres.Text = numMujeres.ToString();
            NumImas.Text = numImas.ToString();
            NumPani.Text = numPani.ToString();
            NumPrivados.Text = numPrivados.ToString();

        }
    }
}
