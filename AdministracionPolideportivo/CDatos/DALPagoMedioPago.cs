using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using AdministracionPolideportivo.CNegocio;

namespace AdministracionPolideportivo.CDatos
{
    internal class DALPagoMedioPago
    {
        public static int AgregarPagoMedioPago(PagoMedioPago pagoMedioPago)
        {
            int resultado = 0;

            try
            {
                using (SqlConnection conexion = ConexionDB.GetConexion())
                {
                    string query = "INSERT INTO Pago_Medio_Pago (id_usuario, monto, id_pago, id_medio) VALUES (@idUsuario, @monto, @idPago, @idMedio);";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@idUsuario", pagoMedioPago.usuario.idUsuario); // Assuming Usuario has an idUsuario property
                    comando.Parameters.AddWithValue("@monto", pagoMedioPago.monto);
                    comando.Parameters.AddWithValue("@idPago", pagoMedioPago.pago.idPago);
                    comando.Parameters.AddWithValue("@idMedio", pagoMedioPago.medioPago.idMedioPago);

                    resultado = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en la base de datos: " + ex.Message);
            }

            return resultado;
        }

        public static List<PagoMedioPago> ListarPagoMedioPago()
        {
            List<PagoMedioPago> lista = new List<PagoMedioPago>();

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                string query = "SELECT id_pago, id_medio, monto, id_usuario FROM Pago_Medio_Pago";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pago pago = new Pago(lector.GetInt32(0), DALReserva.BuscarPorID(lector.GetInt32(1).ToString()).First());
                    MedioPago medioPago = DALMedioPago.BuscarPorId(lector.GetInt32(1));
                    Usuario usuario = DALUsuario.BuscarPorID(lector.GetInt32(3).ToString()).First();

                    PagoMedioPago pagoMedioPago = new PagoMedioPago(pago, medioPago, lector.GetDouble(2))
                    {
                        usuario = usuario
                    };

                    lista.Add(pagoMedioPago);
                }
            }

            return lista;
        }
    }
}
