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
                    String query = "insert into Reserva (fecha_reserva,id_cliente,nro_recinto,id_usuario,hora_reserva) values ('" +
                        reserva.Fecha.Year+"-"+reserva.Fecha.Month+"-"+reserva.Fecha.Day + "'," + reserva.cliente.IdCliente + "," + reserva.recinto.NroRecinto + "," + reserva.usuario.idUsuario + ","+reserva.Hora.Hour+");";
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

        public static List<Reserva> ListarReservas()
        {
            List<Reserva> lista = new List<Reserva>();

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from Reserva";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Reserva reserva = new Reserva(lector.GetInt32(0), DALRecinto.BuscarPorID(lector.GetInt32(3).ToString()).First(),
                    DALCliente.BuscarPorID(lector.GetInt32(2).ToString()).First(),
                    DateOnly.FromDateTime(lector.GetDateTime(1)),new TimeOnly(lector.GetInt32(4),0),DALUsuario.BuscarPorID(lector.GetInt32(5).ToString()).First());
                    lista.Add(reserva);
                }
                conexion.Close();
            }

            return lista;
        }
        public static List<Reserva> ListarReservasPorFechaYRecinto(DateOnly fecha,Recinto recinto)
        {
            List<Reserva> lista = new List<Reserva>();

            
                using (SqlConnection conexion = ConexionDB.GetConexion())
                {
                    String query = "select * from Reserva where fecha_reserva = '"+fecha.Year+"-"+fecha.Month + "-" + fecha.Day+"' and nro_recinto="+recinto.NroRecinto+";";
                    Console.WriteLine(query);
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataReader lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        Reserva reserva = new Reserva(lector.GetInt32(0), DALRecinto.BuscarPorID(lector.GetInt32(3).ToString()).First(),
                        DALCliente.BuscarPorID(lector.GetInt32(2).ToString()).First(),
                        DateOnly.FromDateTime(lector.GetDateTime(1)), new TimeOnly(lector.GetInt32(5), 0), DALUsuario.BuscarPorID(lector.GetInt32(4).ToString()).First());
                        lista.Add(reserva);
                    }
                    conexion.Close();
                }
            
           

            return lista;
        }
        

    }
}
