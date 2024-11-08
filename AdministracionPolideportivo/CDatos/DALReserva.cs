using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionPolideportivo.CNegocio;

namespace AdministracionPolideportivo.CDatos
{
    internal class DALReserva
    {
        public static int AgregarReserva(Reserva reserva)
        {
            int resultado = 0;

            try
            {
                using (SqlConnection conexion = ConexionDB.GetConexion())
                {
                    String query = "insert into Reserva (fecha_reserva,id_cliente,nro_recinto,id_usuario) values ('" +
                        reserva.Fecha.ToShortDateString() + "'," + reserva.cliente.IdCliente + "," + reserva.recinto.NroRecinto + "," + reserva.usuario.idUsuario + ");";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    resultado = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                // Código de error 2627 o 2601 normalmente indica violación de una restricción de clave única
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    throw new Exception("Ya existe una reserva programada con esos datos.");
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
