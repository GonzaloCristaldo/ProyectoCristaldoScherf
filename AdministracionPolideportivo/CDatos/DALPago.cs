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
                    // Comando SQL para insertar un pago con todos los campos
                    string query = @"
                INSERT INTO Pago (id_reserva, id_usuario, id_medio, monto)
                VALUES (@idReserva, @idUsuario, @idMedio, @monto);";

                    SqlCommand comando = new SqlCommand(query, conexion);

                    // Asignación de parámetros
                    comando.Parameters.AddWithValue("@idReserva", pago.reserva.idReserva);
                    comando.Parameters.AddWithValue("@idUsuario", pago.usuario.idUsuario);
                    comando.Parameters.AddWithValue("@idMedio", pago.medio.idMedioPago);
                    comando.Parameters.AddWithValue("@monto", pago.monto);

                    // Ejecutar el comando
                    resultado = comando.ExecuteNonQuery();

                    DALReserva.Pagar(pago.reserva.idReserva);
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
                string query = "SELECT * FROM Pago";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pago pago = new Pago(lector.GetInt32(0), (DALReserva.BuscarPorID(lector.GetInt32(1).ToString()).First()),
                        DALUsuario.BuscarPorID(lector.GetInt32(2).ToString()).First(),DALMedioPago.BuscarPorId(lector.GetInt32(4)),lector.GetInt32(3));
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
