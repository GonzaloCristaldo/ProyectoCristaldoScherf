using System;
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

            int resultado = 0;

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "insert into Cliente (dni_cliente,nombre_cliente,apellido_cliente,telefono_cliente) values ("+cliente.DniCliente+",'"+cliente.NombreCliente+"','"+cliente.ApellidoCliente+"','"+
                    cliente.Telefono+"');";
                SqlCommand comando = new SqlCommand(query,conexion);
                resultado = comando.ExecuteNonQuery();
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
                    Cliente cliente = new Cliente(lector.GetInt32(0),lector.GetInt32(1),lector.GetString(2),lector.GetString(3),lector.GetString(4));
                    lista.Add(cliente);
                }
                conexion.Close();
            }

                
                return lista;
        }
    }
}
