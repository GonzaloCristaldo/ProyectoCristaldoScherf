using AdministracionPolideportivo.CNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace AdministracionPolideportivo.CDatos
{
    internal class DALTipoUsuario
    {

       

        public static List<TipoUsuario> ListarTiposDeUsuario()
        {
            List<TipoUsuario> lista = new List<TipoUsuario>();

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from Tipo_Usuario";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    TipoUsuario tipoUsuario = new TipoUsuario(lector.GetInt32(0), lector.GetString(1));
                    lista.Add(tipoUsuario);
                }
                conexion.Close();
            }

            return lista;
        }
    }


}

