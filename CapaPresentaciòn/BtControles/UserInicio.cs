using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaDatos;
using CapaPresentaciòn.BtViewTablas;

namespace CapaPresentaciòn.BtControles
{
    public partial class UserInicio : UserControl
    {
        private CapaNegocio.CNTablasDatos tablasNegocio = new CapaNegocio.CNTablasDatos();

        // CNPadres objeto = new CNPadres();
        public UserInicio()
        {
            InitializeComponent();
            tablasNegocio.CargarTablasPermitidas(cmbTablas);
            cmbTablas.SelectedIndex = 0;//iniciamo el datagridview con el valor cero de la lista de tablas la cual en la posicion cera esta la tabla padres

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserInicio_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cambie esta funcion por el de buscador necesito arrelarlo ya que funciona pero cuando seleciono otra tabla y busco se cae 
            busquedaEnCurso = false;
            lblTablaSeleccionada.Text = cmbTablas.SelectedItem.ToString().ToUpper();
            tablasNegocio.CargarDatosTabla(cmbTablas.SelectedItem.ToString(), dataGridView1);
            string[] titulos = tablasNegocio.ObtenerDiccionario(cmbTablas.SelectedItem.ToString());
            for (int i = 0; i < titulos.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = titulos[i];
            }
            /*
            lblTablaSeleccionada.Text = cmbTablas.SelectedItem.ToString().ToUpper();
                tablasNegocio.CargarDatosTabla(cmbTablas.SelectedItem.ToString(), dataGridView1);
            string[] titulos = tablasNegocio.ObtenerDiccionario(cmbTablas.SelectedItem.ToString());
            for (int i = 0; i < titulos.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = titulos[i];
            } */
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            /* TablaPadre formPadre = new TablaPadre();
             formPadre.Show();*/

            switch (cmbTablas.SelectedItem.ToString())
            {
                case "padres":
                    TablaPadre formPadre = new TablaPadre();
                    formPadre.Show();
                    formPadre.TituloTabla = "Agregar un nuevo padre";
                    break;
                case "hijos":
                    TablaHijocs formHijos = new TablaHijocs();
                    formHijos.Show();
                    formHijos.TituloTabla = "Agregar un nuevo hijo";
                    break;
              /*  case "doncentes":
                    TablaMatriculas formMatriculas = new TablaMatriculas();
                    formMatriculas.Show();
                    break;
                case "asistentes":
                    TablaDocentes formDocentes = new TablaDocentes();
                    formDocentes.Show();
                    break;
                case "tabPageGrupos":
                    TablaGrupos formGrupos = new TablaGrupos();
                    formGrupos.Show();
                    break;
                default:
                    break;*/
            }

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
        
            if (dataGridView1.SelectedRows.Count > 0)
            {
                TablaPadre formPadre = new TablaPadre();
                formPadre.Show();
                formPadre.TituloTabla = "Editar Padre";
                formPadre.NumeroDocumento = dataGridView1.SelectedRows[0].Cells["numero_documento"].Value.ToString();
                formPadre.TipoDocumento = dataGridView1.SelectedRows[0].Cells["tipo_documento"].Value.ToString();
                formPadre.Nombre = dataGridView1.SelectedRows[0].Cells["nombre_completo"].Value.ToString();
                formPadre.Direccion = dataGridView1.SelectedRows[0].Cells["direccion"].Value.ToString();
                formPadre.Telefono = dataGridView1.SelectedRows[0].Cells["telefono"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila antes de continuar con el proceso de edición");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            TablasDatos tablasDatos = new TablasDatos();

            //ya este boton esta completo y el codigo de abajo lo comente ya si me falla fue por eso

            //string numeroDocumento = dataGridView1.SelectedRows[0].Cells["numero_documento"].Value.ToString();

            // Verificar si hay alguna fila seleccionada
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor seleccione una fila antes de eliminar.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(tablasDatos.connectionString))
            {
                connection.Open();

                switch (cmbTablas.SelectedItem.ToString())
                {
                    case "padres":
                        // Código para eliminar en la tabla padres
                        // Eliminar los registros de las tablas relacionadas (hijos, pagos, historial_pagos) antes de eliminar el padre
                        using (SqlCommand command = new SqlCommand("BEGIN TRANSACTION; DELETE FROM matricula WHERE hijo_id IN (SELECT numero_documento FROM hijos WHERE padre_id = @padreId); DELETE FROM historial_pagos WHERE padre_id = @padreId; DELETE FROM pagos WHERE padre_id = @padreId; DELETE FROM hijos WHERE padre_id = @padreId; DELETE FROM padres WHERE numero_documento = @padreId; COMMIT;", connection))
                        {
                            command.Parameters.AddWithValue("@padreId", dataGridView1.SelectedRows[0].Cells[1].Value);
                            command.ExecuteNonQuery();
                            connection.Close();
                            tablasNegocio.CargarDatosTabla(cmbTablas.SelectedItem.ToString(), dataGridView1);
                            MessageBox.Show("Padre eliminado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                        break;
                    case "hijos":
                        // Código para eliminar en la tabla hijos
                        using (SqlConnection connections = new SqlConnection(tablasDatos.connectionString))
                        {
                            connections.Open();
                            using (SqlCommand command = new SqlCommand("DELETE FROM hijos WHERE padre_id = @padreId; DELETE FROM pagos WHERE padre_id = @padreId; DELETE FROM historial_pagos WHERE padre_id = @padreId; DELETE FROM padres WHERE numero_documento = @padreId", connection))
                            {
                                command.Parameters.AddWithValue("@padreId", dataGridView1.SelectedRows[0].Cells["numero_documento"].Value);
                                command.ExecuteNonQuery();
                            }
                            connections.Close();
                            tablasNegocio.CargarDatosTabla(cmbTablas.SelectedItem.ToString(), dataGridView1);

                        }
                        break;
                    case "docentes":
                        // Código para eliminar en la tabla docentes
                        // Código para eliminar en la tabla docentes
                        // Eliminar los registros de las tablas relacionadas (grupos, matriculas, asistentes) antes de eliminar el docente
                        using (SqlCommand command = new SqlCommand("DELETE FROM matricula WHERE docente_id = @docenteId; DELETE FROM matricula WHERE docente_id = @docenteId; DELETE FROM asistentes WHERE docente_id = @docenteId; DELETE FROM docentes WHERE id = @docenteId", connection))
                        {
                            command.Parameters.AddWithValue("@docenteId", dataGridView1.SelectedRows[0].Cells["id"].Value);
                            command.ExecuteNonQuery();
                            connection.Close();
                            tablasNegocio.CargarDatosTabla(cmbTablas.SelectedItem.ToString(), dataGridView1);
                            MessageBox.Show("Docente eliminado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
         
                    case "asistentes":
                        // Código para eliminar en la tabla asistentes
                        using (SqlCommand command = new SqlCommand("DELETE FROM asistentes WHERE id = @idAsistente", connection))
                        {
                            command.Parameters.AddWithValue("@idAsistente", dataGridView1.SelectedRows[0].Cells["id"].Value);
                            command.ExecuteNonQuery();
                            connection.Close();
                            tablasNegocio.CargarDatosTabla(cmbTablas.SelectedItem.ToString(), dataGridView1);
                            MessageBox.Show("Asistente eliminado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;

                }

            }

        }
        private bool busquedaEnCurso = false;
        private void textBoxBuscador_TextChanged(object sender, EventArgs e)
        {
            busquedaEnCurso = true;
            CNTablasDatos tablasNegocio = new CNTablasDatos();
            tablasNegocio.BuscarPorNombre(cmbTablas.SelectedItem.ToString(), textBoxBuscador.Text, dataGridView1);
        }

    }
}
