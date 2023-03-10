using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNDocente
    {
        private CDDocente objCDDocente;

        public CNDocente()
        {
            objCDDocente = new CDDocente();
        }

        public DataTable ObtenerDocentes()
        {
            return objCDDocente.ObtenerDocentes();
        }

        public string ObtenerNombreGrupoPorIdDocente(int idDocente)
        {
            int idGrupo = objCDDocente.ObtenerIdGrupoPorDocente(idDocente);
            string nombreGrupo = objCDDocente.ObtenerNombreGrupoPorId(idGrupo);
            return nombreGrupo;
        }

        public bool InsertarDocente(int id, string nombre, string direccion, string telefono, int grupo)
        {
            return objCDDocente.InsertarDocente(id, nombre, direccion, telefono, grupo);
        }

        public bool ActualizarDocente(int numeroDocumento, string nombreCompleto, string direccion, string telefono, int grupoId)
        {
            bool resultado = false;
            try
            {
                resultado = objCDDocente.ActualizarDocente(numeroDocumento, nombreCompleto, direccion, telefono, grupoId);
                if (resultado)
                {
                    MessageBox.Show("El docente se actualizó correctamente", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el docente", "Error al actualizar docente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MessageBox.Show("Se produjo un error al actualizar el docente: " + ex.Message, "Error al actualizar docente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;
        }

    }
}
