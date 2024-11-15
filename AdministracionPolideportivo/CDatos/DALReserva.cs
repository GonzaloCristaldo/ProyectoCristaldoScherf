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
                String query = "select * from Reserva;";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Reserva reserva = new Reserva(lector.GetInt32(0), DALRecinto.BuscarPorID(lector.GetInt32(3).ToString()).First(),
                    DALCliente.BuscarPorID(lector.GetInt32(2).ToString()).First(),
                    DateOnly.FromDateTime(lector.GetDateTime(1)),new TimeOnly(lector.GetInt32(4),0),DALUsuario.BuscarPorID(lector.GetInt32(4).ToString()).First());
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

        internal static List<Reserva> BuscarPorFecha(DateOnly fecha)
        {
            List<Reserva> lista = new List<Reserva>();


            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from Reserva where fecha_reserva = '" + fecha.Year + "-" + fecha.Month + "-" + fecha.Day + "';";
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

        internal static Reserva BuscarPorFechaRecintoHoraCliente(DateOnly fecha, Recinto recinto, TimeOnly hora, Cliente cliente)
        {
            List<Reserva> lista = new List<Reserva>();


            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from Reserva where fecha_reserva = '" + fecha.Year + "-" + fecha.Month + "-" + fecha.Day + "' and id_cliente=" + cliente.IdCliente+ " and nro_recinto=" + recinto.NroRecinto + " and hora_reserva="+hora.Hour+";";
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



            return lista.First();
        }

        internal static List<Reserva> BuscarPorHora(string text)
        {
            List<Reserva> lista = new List<Reserva>();


            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from Reserva where hora_reserva = " + text + ";";
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

        internal static List<Reserva> BuscarPorID(string text)
        {
            List<Reserva> lista = new List<Reserva>();


            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from Reserva where id_reserva = " + text+";";
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

        internal static List<Reserva> BuscarPorIDCliente(string text)
        {
            List<Reserva> lista = new List<Reserva>();


            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from Reserva where id_cliente = " + text + ";";
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

        internal static List<Reserva> BuscarPorIDUsuario(string text)
        {
            List<Reserva> lista = new List<Reserva>();


            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from Reserva where id_usuario = " + text + ";";
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

        internal static List<Reserva> BuscarPorNroRecinto(string text)
        {
            List<Reserva> lista = new List<Reserva>();


            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from Reserva where nro_recinto = " + text + ";";
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

        public static List<Reserva> ListarReservasSinPagar()
        {
            List<Reserva> lista = new List<Reserva>();

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from Reserva where pagado=0;";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Reserva reserva = new Reserva(lector.GetInt32(0), DALRecinto.BuscarPorID(lector.GetInt32(3).ToString()).First(),
                    DALCliente.BuscarPorID(lector.GetInt32(2).ToString()).First(),
                    DateOnly.FromDateTime(lector.GetDateTime(1)), new TimeOnly(lector.GetInt32(4), 0), DALUsuario.BuscarPorID(lector.GetInt32(4).ToString()).First());
                    lista.Add(reserva);
                }
                conexion.Close();
            }

            return lista;
        }

        public static void Pagar(int idReserva)
        {
            try
            {
                using (SqlConnection conexion = ConexionDB.GetConexion())
                {
                    string query = "UPDATE Reserva SET pagado = 1 WHERE id_reserva = @idReserva;";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@idReserva", idReserva);

                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        Console.WriteLine("Reserva pagada exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("No se encontró la reserva con el ID especificado.");
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al actualizar la reserva: " + ex.Message);
                throw;
            }
        }

    }
}
