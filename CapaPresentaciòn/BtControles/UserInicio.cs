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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using CapaEntidad;
using iTextSharp.tool.xml.html.head;

namespace CapaPresentaciòn.BtControles
{
    public partial class UserInicio : UserControl
    {
        private bool busquedaEnCurso = false;
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

            if (cmbTablas.SelectedItem.ToString() == "pagos")
            {
                buttonPagar.Visible = true;
            }
            else
            {
                buttonPagar.Visible = false;
            }

            if (cmbTablas.SelectedItem.ToString() == "matricula")
            {
                buttonNuevo.Visible = false;
            }
            else
            {
                buttonNuevo.Visible = true;
            }

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
                case "matricula":
                    TablaMatriculas formMatriculas = new TablaMatriculas();
                    formMatriculas.Show();
                    break;
                case "docentes":
                    TablaDocentes formDocentes = new TablaDocentes();
                    formDocentes.Show();
                    formDocentes.Titulo = "Nuevo docente";
                    break;
                case "asistentes":
                    TablaAsistentes formAsistente = new TablaAsistentes();
                    formAsistente.Show();
                    formAsistente.Titulo = "Nuevo asistente";
                    break;
                case "grupos":
                    TablaGrupos formGrupos = new TablaGrupos();
                    formGrupos.Show();
                    formGrupos.Titulo = "Nuevo grupo";
                    break;
                case "pagos":
                    TablaPagos formPagos = new TablaPagos();
                    formPagos.Show();
                    break;
                default:
                    break;
            }

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                switch (cmbTablas.SelectedItem.ToString())
                {
                    case "padres":
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
                        break;

                    case "hijos":
                       
                            TablaHijocs formHijo = new TablaHijocs();
                            formHijo.Show();
                            formHijo.TituloTabla = "Editar Hijo";
                            formHijo.NumeroDocumento = dataGridView1.SelectedRows[0].Cells["numero_documento"].Value.ToString();
                            formHijo.NombreCompleto = dataGridView1.SelectedRows[0].Cells["nombre_completo"].Value.ToString();
                            formHijo.FechaNacimiento = (DateTime)dataGridView1.SelectedRows[0].Cells["fecha_nacimiento"].Value;
                            formHijo.Edad = dataGridView1.SelectedRows[0].Cells["edad"].Value.ToString();
                            formHijo.Genero = dataGridView1.SelectedRows[0].Cells["genero"].Value.ToString();
                            formHijo.SegúnInec = dataGridView1.SelectedRows[0].Cells["segun_inec"].Value.ToString();
                            formHijo.Subsidio = dataGridView1.SelectedRows[0].Cells["subsidio"].Value.ToString();
                            formHijo.PadreId = (int)dataGridView1.SelectedRows[0].Cells["padre_id"].Value;
                       
                   
                        break;

                    case "grupos":

                        TablaGrupos formGrupo = new TablaGrupos();
                        formGrupo.Titulo = "Editar Grupo";
                        formGrupo.Id = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
                        formGrupo.nombreG = dataGridView1.SelectedRows[0].Cells["nombre"].Value.ToString();
                        formGrupo.Show();
                        break;

                    case "docentes":

                        TablaDocentes formDocent = new TablaDocentes();
                        formDocent.Titulo = "Editar docente";
                        formDocent.Id = dataGridView1.SelectedRows[0].Cells["numero_documento"].Value.ToString();
                        formDocent.Nombre = dataGridView1.SelectedRows[0].Cells["nombre_completo"].Value.ToString();
                        formDocent.Direccion = dataGridView1.SelectedRows[0].Cells["direccion"].Value.ToString();
                        formDocent.Telefono = dataGridView1.SelectedRows[0].Cells["telefono"].Value.ToString();
                        formDocent.IdGrupo = dataGridView1.SelectedRows[0].Cells["grupo_id"].Value.ToString();
                        formDocent.Show();
                        break;


                    case "matricula":

                        TablaMatriculas formMatricula = new TablaMatriculas();
                        formMatricula.Show();
                        formMatricula.Titulo = "Editar matricula";
                        formMatricula.Id = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
                        formMatricula.IdHijo = dataGridView1.SelectedRows[0].Cells["hijo_id"].Value.ToString();
                        formMatricula.IdPadre = dataGridView1.SelectedRows[0].Cells["padre_id"].Value.ToString();
                        formMatricula.IdDocente = dataGridView1.SelectedRows[0].Cells["docente_id"].Value.ToString();
                        formMatricula.IdGrupo = dataGridView1.SelectedRows[0].Cells["grupo_id"].Value.ToString();

                        break;


                    case "asistentes":

                        TablaAsistentes formAsistente = new TablaAsistentes();
                        formAsistente.Show();
                        formAsistente.Titulo = "Editar asistente";
                        formAsistente.Id = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
                        formAsistente.NumDocumento = dataGridView1.SelectedRows[0].Cells["numero_documento"].Value.ToString();
                        formAsistente.Nombre = dataGridView1.SelectedRows[0].Cells["nombre_completo"].Value.ToString();
                        formAsistente.IdDocente = dataGridView1.SelectedRows[0].Cells["docente_id"].Value.ToString();
                     

                        break;



                }
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

                        string nombrePadre = dataGridView1.SelectedRows[0].Cells["nombre_completo"].Value.ToString();
                        if (MessageBox.Show("¿Está seguro que desea eliminar a" + nombrePadre + "?" + "si lo elimina se eliminar el registro de su hijo tambien.", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            using (SqlCommand command = new SqlCommand("BEGIN TRANSACTION; DELETE FROM matricula WHERE hijo_id IN (SELECT numero_documento FROM hijos WHERE padre_id = @padreId); DELETE FROM historial_pagos WHERE padre_id = @padreId; DELETE FROM pagos WHERE padre_id = @padreId; DELETE FROM hijos WHERE padre_id = @padreId; DELETE FROM padres WHERE numero_documento = @padreId; COMMIT;", connection))
                            {
                                command.Parameters.AddWithValue("@padreId", dataGridView1.SelectedRows[0].Cells[1].Value);
                                command.ExecuteNonQuery();
                                connection.Close();
                                tablasNegocio.CargarDatosTabla(cmbTablas.SelectedItem.ToString(), dataGridView1);
                                MessageBox.Show("Padre eliminado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }


                        break;
                    case "hijos":
                        // Código para eliminar en la tabla hijos
                        using (SqlConnection connections = new SqlConnection(tablasDatos.connectionString))
                        {
                            string nombreHijo = dataGridView1.SelectedRows[0].Cells["nombre_completo"].Value.ToString();
                            if (MessageBox.Show("No se puede eliminar a " + nombreHijo + ", debe eliminar a su padre o persona acargo de su matricula para que se elimine del registro.", "Confirmar eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
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

                           

                        }
                        break;
                    case "docentes":


                        string nombreDocente = dataGridView1.SelectedRows[0].Cells["nombre_completo"].Value.ToString();
                        if (MessageBox.Show("¿Está seguro que desea eliminar al docente " + nombreDocente + "?" + "Si lo decea eliminar asegurece que no este asignado a ningun grupo, asistente o matricula ya que si esta asignado dicho docente, tambien se eliminarán esos registros, lo adecuado seria que les asigne otro docente", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            using (SqlCommand command = new SqlCommand("DELETE FROM matricula WHERE docente_id = @docenteId; DELETE FROM matricula WHERE docente_id = @docenteId; DELETE FROM asistentes WHERE docente_id = @docenteId; DELETE FROM docentes WHERE numero_documento = @docenteId", connection))
                            {
                                command.Parameters.AddWithValue("@docenteId", dataGridView1.SelectedRows[0].Cells["numero_documento"].Value);
                                command.ExecuteNonQuery();
                                connection.Close();
                                tablasNegocio.CargarDatosTabla(cmbTablas.SelectedItem.ToString(), dataGridView1);
                                MessageBox.Show("Si desea elimiar este docente primero asegurese que no este asignado a ninguna matricula o grupo", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        break;
         
                    case "asistentes":
                        // Código para eliminar en la tabla asistentes

                        string nombreAsistente = dataGridView1.SelectedRows[0].Cells["nombre"].Value.ToString();
                        if (MessageBox.Show("¿Está seguro que desea eliminar a" + nombreAsistente + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            using (SqlCommand command = new SqlCommand("DELETE FROM asistentes WHERE id = @idAsistente", connection))
                            {
                                command.Parameters.AddWithValue("@idAsistente", dataGridView1.SelectedRows[0].Cells["id"].Value);
                                command.ExecuteNonQuery();
                                connection.Close();
                                tablasNegocio.CargarDatosTabla(cmbTablas.SelectedItem.ToString(), dataGridView1);
                                MessageBox.Show("Asistente eliminado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        break;

                    case "grupos":
                        // Código para eliminar en la tabla asistentes
                        using (SqlCommand command = new SqlCommand("DELETE FROM grupos WHERE id = @idGrupos", connection))
                        {
                            command.Parameters.AddWithValue("@idGrupos", dataGridView1.SelectedRows[0].Cells["id"].Value);
                            command.ExecuteNonQuery();
                            connection.Close();
                            tablasNegocio.CargarDatosTabla(cmbTablas.SelectedItem.ToString(), dataGridView1);
                            MessageBox.Show("Grupo eliminado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;

                    case "matricula":
                        // Código para eliminar en la tabla asistentes
                        using (SqlCommand command = new SqlCommand("DELETE FROM matricula WHERE id = @idMatricula", connection))
                        {
                            command.Parameters.AddWithValue("@idMatricula", dataGridView1.SelectedRows[0].Cells["id"].Value);
                            command.ExecuteNonQuery();
                            connection.Close();
                            tablasNegocio.CargarDatosTabla(cmbTablas.SelectedItem.ToString(), dataGridView1);
                            MessageBox.Show("Se elimino la matricula con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;


                    case "pagos":
                        // Código para eliminar en la tabla asistentes
                        using (SqlCommand command = new SqlCommand("DELETE FROM pagos WHERE id = @idPagos", connection))
                        {
                            command.Parameters.AddWithValue("@idPagos", dataGridView1.SelectedRows[0].Cells["id"].Value);
                            command.ExecuteNonQuery();
                            connection.Close();
                            tablasNegocio.CargarDatosTabla(cmbTablas.SelectedItem.ToString(), dataGridView1);
                            MessageBox.Show("Se elimino el pago con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;


                    case "historial_pagos":
                        // Código para eliminar en la tabla asistentes
                        using (SqlCommand command = new SqlCommand("DELETE FROM historial_pagos WHERE id = @idHistorial", connection))
                        {
                            command.Parameters.AddWithValue("@idHistorial", dataGridView1.SelectedRows[0].Cells["id"].Value);
                            command.ExecuteNonQuery();
                            connection.Close();
                            tablasNegocio.CargarDatosTabla(cmbTablas.SelectedItem.ToString(), dataGridView1);
                            MessageBox.Show("Se elimino el historial con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;

                }

            }

        }
        private void textBoxBuscador_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxBuscador.Text))
            {
                return;
            }

            if (!int.TryParse(textBoxBuscador.Text, out int _))
            {
                busquedaEnCurso = true;
                CNTablasDatos tablasNegocio = new CNTablasDatos();
                tablasNegocio.BuscarPorNombre(cmbTablas.SelectedItem.ToString(), textBoxBuscador.Text, dataGridView1);
            }
            else
            {
                MessageBox.Show("Solo puede buscar por Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBuscador.Text = "";
            }
        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            
        }

        private void NumNacional_Click(object sender, EventArgs e)
        {

        }

        private void NumExtranjero_Click(object sender, EventArgs e)
        {

        }
    }
}
