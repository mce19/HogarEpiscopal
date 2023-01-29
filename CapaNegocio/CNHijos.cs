using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNHijos
    {

        /*
                private string connectionString;

                public CNHijos()
                {
                    conexiònBD conexionBD = new conexiònBD();
                    connectionString = conexionBD.connectionString;
                }
        */
        private CDHijos cdHijos;

        public CNHijos()
        {
            cdHijos = new CDHijos();
        }


        public void AgregarHijos(Hijos hijo)
        {

            try
            {
                if (string.IsNullOrEmpty(hijo.NumeroDocumento.ToString()))
                    throw new Exception("El numero de documento es requerido");

                if (string.IsNullOrEmpty(hijo.NombreCompleto))
                    throw new Exception("El número de documento es requerido");

                if (string.IsNullOrEmpty(hijo.FechaNacimiento.ToString()))
                    throw new Exception("El nombre es requerido");

                if (string.IsNullOrEmpty(hijo.Edad))
                    throw new Exception("La dirección es requerida");

                if (string.IsNullOrEmpty(hijo.Genero))
                    throw new Exception("El teléfono es requerido");

                if (string.IsNullOrEmpty(hijo.SegunInec))
                    throw new Exception("El teléfono es requerido");

                if (string.IsNullOrEmpty(hijo.Subsidio))
                    throw new Exception("El subsidio es requerido");

                if (string.IsNullOrEmpty(hijo.PadreId.ToString()))
                    throw new Exception("El numero del documento del padre es requerido");

                /* using (SqlConnection connection = new SqlConnection(connectionString))
                  {
                      connection.Open();

                      SqlCommand command = new SqlCommand("INSERT INTO hijos (numero_documento, nombre_completo, fecha_nacimiento, edad, genero, segun_inec, subsidio, padre_id) VALUES (@numero_documento, @nombre_completo, @fecha_nacimiento, @edad, @genero, @segun_inec, @subsidio, @padre_id)", connection);

                      command.Parameters.AddWithValue("@numero_documento", hijo.NumeroDocumento);
                      command.Parameters.AddWithValue("@nombre_completo", hijo.NombreCompleto);
                      command.Parameters.AddWithValue("@fecha_nacimiento", hijo.FechaNacimiento);
                      command.Parameters.AddWithValue("@edad", hijo.Edad);
                      command.Parameters.AddWithValue("@genero", hijo.Genero);
                      command.Parameters.AddWithValue("@segun_inec", hijo.SegunInec);
                      command.Parameters.AddWithValue("@subsidio", hijo.Subsidio);
                      command.Parameters.AddWithValue("@padre_id", hijo.PadreId);
                      command.ExecuteNonQuery();
                  }*/
              }
              catch (Exception ex)
              {
                  throw new Exception(ex.Message);
              }

                // Si todos los datos del hijo son válidos, agregarlo a la base de datos
                cdHijos.AgregarHijo(hijo);
            }

        public void EditarHijo(Hijos hijo)
        {
            try
            {
                // Validar los datos del hijo antes de editarlo
                if (string.IsNullOrEmpty(hijo.NumeroDocumento.ToString()))
                    throw new Exception("El número de documento es requerido");

                if (string.IsNullOrEmpty(hijo.NombreCompleto))
                    throw new Exception("El nombre es requerido");

                if (string.IsNullOrEmpty(hijo.FechaNacimiento.ToString()))
                    throw new Exception("La fecha de nacimiento es requerida");

                if (string.IsNullOrEmpty(hijo.Edad))
                    throw new Exception("La edad es requerida");

                if (string.IsNullOrEmpty(hijo.Genero))
                    throw new Exception("El género es requerido");

                if (string.IsNullOrEmpty(hijo.SegunInec))
                    throw new Exception("La clasificación según INEC es requerida");

                if (string.IsNullOrEmpty(hijo.Subsidio))
                    throw new Exception("El subsidio es requerido");

                if (string.IsNullOrEmpty(hijo.PadreId.ToString()))
                    throw new Exception("El ID del padre es requerido");

                // Si todos los datos del hijo son válidos, editarlo en la base de datos
                cdHijos.EditarHijo(hijo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }

}

