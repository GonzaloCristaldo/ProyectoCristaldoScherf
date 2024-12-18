﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionPolideportivo.CNegocio;

namespace AdministracionPolideportivo.CDatos
{
    internal class DALCliente
    {
        public static int AgregarCliente(Cliente cliente)
        {
            // Validaciones de los campos
            if (cliente.DniCliente <= 0)
            {
                throw new ArgumentException("El DNI no puede ser vacío o negativo.");
            }

            if (string.IsNullOrEmpty(cliente.NombreCliente))
            {
                throw new ArgumentException("El nombre no puede estar vacío.");
            }

            if (string.IsNullOrEmpty(cliente.ApellidoCliente))
            {
                throw new ArgumentException("El apellido no puede estar vacío.");
            }

            if (string.IsNullOrEmpty(cliente.Telefono) || cliente.Telefono.Length < 7)
            {
                throw new ArgumentException("El teléfono es inválido.");
            }

            int resultado = 0;

            try
            {
                using (SqlConnection conexion = ConexionDB.GetConexion())
                {
                    String query = "insert into Cliente (dni_cliente,nombre_cliente,apellido_cliente,telefono_cliente) values (" +
                        cliente.DniCliente + ",'" + cliente.NombreCliente + "','" + cliente.ApellidoCliente + "','" + cliente.Telefono + "');";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    resultado = comando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                // Código de error 2627 o 2601 normalmente indica violación de una restricción de clave única
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    throw new Exception("Ya existe un cliente registrado con ese DNI.");
                }
                else
                {
                    throw new Exception("Error en la base de datos: " + ex.Message);
                }
            }

            return resultado;
        }

        public static List<Cliente> ListarClientes()
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from Cliente";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Cliente cliente = new Cliente(lector.GetInt32(0), lector.GetInt32(1), lector.GetString(2), lector.GetString(3), lector.GetString(4));
                    lista.Add(cliente);
                }
                conexion.Close();
            }

            return lista;
        }

        //consultas por campo
        public static List<Cliente> BuscarPorID(String input)
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from Cliente where id_cliente = "+input+";";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Cliente cliente = new Cliente(lector.GetInt32(0), lector.GetInt32(1), lector.GetString(2), lector.GetString(3), lector.GetString(4));
                    lista.Add(cliente);
                }
                conexion.Close();
            }

            return lista;
        }


        public static List<Cliente> BuscarPorDNI(String input)
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from Cliente where dni_cliente = " + input + ";";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Cliente cliente = new Cliente(lector.GetInt32(0), lector.GetInt32(1), lector.GetString(2), lector.GetString(3), lector.GetString(4));
                    lista.Add(cliente);
                }
                conexion.Close();
            }

            return lista;
        }

        public static List<Cliente> BuscarPorNombre(String input)
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from Cliente where nombre_cliente LIKE '%" + input + "%';";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Cliente cliente = new Cliente(lector.GetInt32(0), lector.GetInt32(1), lector.GetString(2), lector.GetString(3), lector.GetString(4));
                    lista.Add(cliente);
                }
                conexion.Close();
            }

            return lista;
        }

        public static List<Cliente> BuscarPorApellido(String input)
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from Cliente where apellido_cliente LIKE '%" + input + "%';";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Cliente cliente = new Cliente(lector.GetInt32(0), lector.GetInt32(1), lector.GetString(2), lector.GetString(3), lector.GetString(4));
                    lista.Add(cliente);
                }
                conexion.Close();
            }

            return lista;
        }

        public static List<Cliente> BuscarPorTelefono(String input)
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from Cliente where telefono_cliente LIKE '%" + input + "%';";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Cliente cliente = new Cliente(lector.GetInt32(0), lector.GetInt32(1), lector.GetString(2), lector.GetString(3), lector.GetString(4));
                    lista.Add(cliente);
                }
                conexion.Close();
            }

            return lista;
        }

        internal static int EditarCliente(Cliente cliente)
        {
            int resultado = 0;//mayo a 0 representa exitoso, ya que se altero una cantidad de columnas mayor a 0, es decir, efectivamente se altero el cliente
            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "UPDATE Cliente SET dni_cliente = @dni, nombre_cliente = @nombre, apellido_cliente = @apellido, telefono_cliente = @telefono WHERE id_cliente = @id;";

                SqlCommand comando = new SqlCommand(query, conexion);

                // Add parameters
                comando.Parameters.AddWithValue("@dni", cliente.DniCliente);
                comando.Parameters.AddWithValue("@nombre", cliente.NombreCliente);
                comando.Parameters.AddWithValue("@apellido", cliente.ApellidoCliente);
                comando.Parameters.AddWithValue("@telefono", cliente.Telefono);
                comando.Parameters.AddWithValue("@id", cliente.IdCliente);

                resultado = comando.ExecuteNonQuery();
                conexion.Close();
            }

            return resultado;
        }
    }

}
