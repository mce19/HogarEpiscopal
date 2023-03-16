using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNAsistente
    {
        private CDAsistente Asistente;
          public CNAsistente() { 
        
            Asistente = new CDAsistente();

        }
        public void AgregarAsistente(int numero_documento, string nombre_completo, int docente_id)
        {


            // Llamar al método correspondiente de la capa de datos para agregar el asistente a la base de datos
            Asistente.AgregarAsistente(numero_documento, nombre_completo, docente_id);


        }


        public void ActualizarAsistente(int id ,int numero_documento, string nombre_completo, int docente_id)
        {
            try
            {
            

                // Llamar al método correspondiente de la capa de datos para actualizar el asistente en la base de datos
                Asistente.ActualizarAsistente(id, numero_documento, nombre_completo, docente_id);
            }
            catch (Exception ex)
            {
                // Manejar la excepción mostrando un mensaje de error
                throw new Exception("Error al actualizar asistente: " + ex.Message);
            }
        }

    }
}
