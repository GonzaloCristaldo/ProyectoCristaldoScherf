﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionPolideportivo.CNegocio;
namespace AdministracionPolideportivo.CDatos
{
    internal class DALServicioReserva
    {

        public static int AgregarRelacion(ServicioAdicional servicio,Reserva reserva)
        {
            int resultado = 0;

            try
            {
                using (SqlConnection conexion = ConexionDB.GetConexion())
                {
                    String query = "insert into Servicio_Reserva (id_servicio,id_reserva) values (" +
                        servicio.IdServicio + "," + reserva.idReserva + ");";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    resultado = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                // Código de error 2627 o 2601 normalmente indica violación de una restricción de clave única
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    throw new Exception("Ya existe un campo registrado con esta relacion reserva-servicio.");
                }
                else
                {
                    throw new Exception("Error en la base de datos: " + ex.Message);
                }
            }

            return resultado;
        }

        public static List<ServicioReserva> BuscarPorIdReserva(String input)
        {
            List<ServicioReserva> lista = new List<ServicioReserva>();

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from servicio_reserva where id_reserva = " + input + ";";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    ServicioReserva servicioReserva = new ServicioReserva(DALReserva.BuscarPorID(lector.GetInt32(1).ToString()).First(), DALServicioAdicional.BuscarPorId(lector.GetInt32(0).ToString()).First());
                    lista.Add(servicioReserva);
                }
                conexion.Close();
            }

            return lista;
        }
    }
}
