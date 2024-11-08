using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionPolideportivo.CNegocio;

namespace AdministracionPolideportivo.CDatos
{
    internal class DALRecintoServicio
    {

        public static int AgregarRelacion(Recinto recinto, ServicioAdicional servicio)
        {
            int resultado = 0;

            try
            {
                using (SqlConnection conexion = ConexionDB.GetConexion())
                {
                    String query = "insert into Recinto_Servicio (nro_recinto,id_servicio) values (" +
                        recinto.NroRecinto + "," + servicio.IdServicio + ");";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    resultado = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                // Código de error 2627 o 2601 normalmente indica violación de una restricción de clave única
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    throw new Exception("Ya existe un campo registrado con esta relacion servicio-recinto.");
                }
                else
                {
                    throw new Exception("Error en la base de datos: " + ex.Message);
                }
            }

            return resultado;
        }

    }
}
