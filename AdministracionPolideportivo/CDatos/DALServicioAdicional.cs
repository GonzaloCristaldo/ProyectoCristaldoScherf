﻿using System;
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

    }
}
