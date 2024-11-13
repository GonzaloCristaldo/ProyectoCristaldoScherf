using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionPolideportivo.CNegocio;

namespace AdministracionPolideportivo.CDatos
{
    internal class DALServicioAdicional
    {
        public static int AgregarServicioAdicional(ServicioAdicional servicioAdicional)
        {
            // Validaciones de los campos
            if (servicioAdicional.Precio < 0)
            {
                throw new ArgumentException("El precio no puede ser vacío o negativo.");
            }

            if (string.IsNullOrEmpty(servicioAdicional.NombreServicio))
            {
                throw new ArgumentException("El nombre no puede estar vacío.");
            }

            if (string.IsNullOrEmpty(servicioAdicional.DescripcionServicio))
            {
                throw new ArgumentException("La descripción no puede estar vacía.");
            }

            int resultado = 0;

            try
            {
                using (SqlConnection conexion = ConexionDB.GetConexion())
                {
                    String query = "insert into servicio_adicional (nombre_servicio,descripcion_servicio,precio) values ('" +
                        servicioAdicional.NombreServicio + "','" + servicioAdicional.DescripcionServicio + "'," + servicioAdicional.Precio+");";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    resultado = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                // Código de error 2627 o 2601 normalmente indica violación de una restricción de clave única
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    throw new Exception("Ya existe un servicio registrado con ese valor.");
                }
                else
                {
                    throw new Exception("Error en la base de datos: " + ex.Message);
                }
            }

            return resultado;
        }

        public static List<ServicioAdicional> ListarServicios()
        {
            List<ServicioAdicional> lista = new List<ServicioAdicional>();
            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from Servicio_Adicional";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    ServicioAdicional servicioAdicional = new ServicioAdicional(lector.GetInt32(0),lector.GetString(1), lector.GetString(2), lector.GetDecimal(3));
                    lista.Add(servicioAdicional);
                }
                conexion.Close();
            }

            return lista;
        }

        public static List<ServicioAdicional> BuscarPorNombre(String input)
        {
            List<ServicioAdicional> lista = new List<ServicioAdicional>();

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from servicio_adicional where nombre_servicio LIKE '%" + input + "%';";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    ServicioAdicional servicio = new ServicioAdicional(lector.GetInt32(0), lector.GetString(1), lector.GetString(2), lector.GetDecimal(3));
                    lista.Add(servicio);
                }
                conexion.Close();
            }

            return lista;
        }

        public static List<ServicioAdicional> FiltrarPorRecinto(Recinto recinto)
        {
            List<ServicioAdicional> lista = new List<ServicioAdicional>();

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from servicio_adicional where id_servicio in (select id_servicio from Recinto_Servicio where nro_recinto="+recinto.NroRecinto+");";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    ServicioAdicional servicio = new ServicioAdicional(lector.GetInt32(0), lector.GetString(1), lector.GetString(2), lector.GetDecimal(3));
                    lista.Add(servicio);
                }
                conexion.Close();
            }

            return lista;
        }

        internal static List<ServicioAdicional> BuscarPorIdReserva(int idReserva)
        {
            List<ServicioAdicional> lista = new List<ServicioAdicional>();

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from servicio_adicional where id_servicio in (select id_servicio from Servicio_reserva where id_reserva=" + idReserva + ");";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    ServicioAdicional servicio = new ServicioAdicional(lector.GetInt32(0), lector.GetString(1), lector.GetString(2), lector.GetDecimal(3));
                    lista.Add(servicio);
                }
                conexion.Close();
            }

            return lista;
        }
    }
}
