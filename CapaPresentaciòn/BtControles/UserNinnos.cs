﻿using CapaDatos;
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

        }

        private void buttonCargarDatos_Click(object sender, EventArgs e)
        {

            try
            {
                CapaDatos.CDMatricula objCDMatricula = new CapaDatos.CDMatricula();
                DataTable dtMatriculados = objCDMatricula.ListarMatriculados();
                DataTable dtDocentesGrupos = objCDMatricula.ListarDocenteGrupos();
                dataGridViewPadresMatricula.DataSource = dtMatriculados;
                dataGridViewGrupos.DataSource = dtDocentesGrupos;
                buttonCargarDatos.BackColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonCargarDatos.BackColor = Color.Red;
            }

            /*try
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
            */

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxNombDocente_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMatricular_Click(object sender, EventArgs e)
        {
            // Verificar que se haya seleccionado una fila en el dataGridView
            if (dataGridViewPadresMatricula.SelectedRows.Count == 1)
            {
                DataGridViewRow filaSeleccionada = dataGridViewPadresMatricula.SelectedRows[0];

                // Asignar los valores de la fila seleccionada a los textBox correspondientes
                textBoxNumPadre.Text = filaSeleccionada.Cells["Ced. Padre"].Value.ToString();
                textBoxNombPadre.Text = filaSeleccionada.Cells["Nombre Padre"].Value.ToString();
                textBoxNombHijo.Text = filaSeleccionada.Cells["Nombre Hijo"].Value.ToString();
                textBoxNumHijo.Text = filaSeleccionada.Cells["Ced. Hijo"].Value.ToString();


                if (dataGridViewGrupos.SelectedRows.Count == 1)
                {
                    DataGridViewRow filaSeleccionad = dataGridViewGrupos.SelectedRows[0];

                    // Asignar los valores de la fila seleccionada a los textBox correspondientes
                    textBoxNumDocente.Text = filaSeleccionad.Cells["Numero de Documento"].Value.ToString();
                    textBoxNombDocente.Text = filaSeleccionad.Cells["Nombre Completo"].Value.ToString();
                    textBoxIdGrupo.Text = filaSeleccionad.Cells["ID del Grupo"].Value.ToString();
                    textBoxGrupos.Text = filaSeleccionad.Cells["Nombre del Grupo"].Value.ToString();

                }
                else

                {
                    // Mostrar un mensaje de error si no se seleccionó ninguna fila
                    MessageBox.Show("Por favor seleccione una fila.");
                }
            }
            
            else
            {
                // Mostrar un mensaje de error si no se seleccionó ninguna fila
                MessageBox.Show("Por favor seleccione una fila.");
            }
        }

        private void comboBoxDocentes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardarMatricula_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewGrupos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxIdGrupo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGrupos_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGrupo_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIdMatricula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
