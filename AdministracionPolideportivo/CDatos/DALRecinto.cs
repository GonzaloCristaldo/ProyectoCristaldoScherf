using AdministracionPolideportivo.CNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Net;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Windows.Forms;

namespace AdministracionPolideportivo.CDatos
{
    internal class DALRecinto
    {
        public static List<Recinto> BuscarPorID(String input)
        {
            List<Recinto> lista = new List<Recinto>();

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from Recinto where nro_recinto = " + input + ";";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Recinto recinto = new Recinto(lector.GetInt32(0), lector.GetDouble(1), DALEstado.BuscarEstadoID(lector.GetInt32(4).ToString()), DALTipoRecinto.BuscarTipoRecintoID(lector.GetInt32(3).ToString()), lector.GetString(2));
                    lista.Add(recinto);
                }
                conexion.Close();
            }

            return lista;
        }


        public static int AgregarRecinto(Recinto recinto)
        {
            // Validaciones de los campos
            if (recinto.tipoRecinto==null)
            {
                throw new ArgumentException("El tipo de recinto no puede estar vacio.");
            }

            if (string.IsNullOrEmpty(recinto.Ubicacion))
            {
                throw new ArgumentException("La ubicacion del recinto no puede estar vacía.");
            }

            if (recinto.estado == null)
            {
                throw new ArgumentException("El estado del recinto no puede estar vacio");
            }

            if (recinto.NroRecinto<0)
            {
                throw new ArgumentException("El numero de recinto no puede ser negativo");
            }

            int resultado = 0;

            try
            {
                using (SqlConnection conexion = ConexionDB.GetConexion())
                {
                    String query = "insert into recinto(nro_recinto,tarifa_hora,ubicacion_recinto,id_tipo_recinto,id_estado) \r\nvalues\r\n(" +
                        recinto.NroRecinto + "," + recinto.TarifaHora + ",'" + recinto.Ubicacion + "'," + recinto.tipoRecinto.id + ","+recinto.estado.id+");";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    resultado = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                // Código de error 2627 o 2601 normalmente indica violación de una restricción de clave única
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    throw new Exception("Ya existe un recinto registrado con ese numero registrado.");
                }
                else
                {
                    throw new Exception("Error en la base de datos: " + ex.Message);
                }
            }

            return resultado;
        }


        public static List<Recinto> ListarRecintos()
        {
            List<Recinto> lista = new List<Recinto>();

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from Recinto";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Recinto recinto = new Recinto(lector.GetInt32(0),lector.GetDouble(1), DALEstado.BuscarEstadoID(lector.GetInt32(4).ToString()), DALTipoRecinto.BuscarTipoRecintoID(lector.GetInt32(3).ToString()), lector.GetString(2));
                    lista.Add(recinto);
                }
                conexion.Close();
            }

            return lista;
        }

        internal static List<Recinto> BuscarPorTipo(String input)
        {
            List<Recinto> lista = new List<Recinto>();

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from Recinto where id_tipo_recinto = " + input + ";";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Recinto recinto = new Recinto(lector.GetInt32(0), lector.GetDouble(1), DALEstado.BuscarEstadoID(lector.GetInt32(4).ToString()), DALTipoRecinto.BuscarTipoRecintoID(lector.GetInt32(3).ToString()), lector.GetString(2));
                    lista.Add(recinto);
                }
                conexion.Close();
            }

            return lista;
        }
    }
}
