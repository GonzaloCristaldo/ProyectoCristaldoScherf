using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using AdministracionPolideportivo.CNegocio;

namespace AdministracionPolideportivo.CDatos
{
    internal class DALPago
    {
        public static int AgregarPago(Pago pago)
        {
            int resultado = 0;

            try
            {
                using (SqlConnection conexion = ConexionDB.GetConexion())
                {
                    string query = "INSERT INTO Pago (id_reserva) VALUES (@idReserva);";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@idReserva", pago.reserva.idReserva);

                    resultado = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en la base de datos: " + ex.Message);
            }

            return resultado;
        }

        public static List<Pago> ListarPagos()
        {
            List<Pago> lista = new List<Pago>();

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                string query = "SELECT id_pago, id_reserva FROM Pago";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pago pago = new Pago(lector.GetInt32(0), (DALReserva.BuscarPorID(lector.GetInt32(1).ToString()).First()));
                    lista.Add(pago);
                }
            }

            return lista;
        }

        public static int EliminarPago(int idPago)
        {
            int resultado = 0;

            try
            {
                using (SqlConnection conexion = ConexionDB.GetConexion())
                {
                    string query = "DELETE FROM Pago WHERE id_pago = @idPago;";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@idPago", idPago);

                    resultado = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en la base de datos: " + ex.Message);
            }

            return resultado;
        }
    }
}
