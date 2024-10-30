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
    internal class DALTipoRecinto
    {

        public static List<TipoRecinto> ListarTiposRecinto()
        {
            List<TipoRecinto> lista = new List<TipoRecinto>();

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from tipo_recinto";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    TipoRecinto recinto = new TipoRecinto();
                    recinto.nombre = lector.GetString(1);
                    recinto.id = lector.GetInt32(0);
                    lista.Add(recinto);
                }
                conexion.Close();
            }

            return lista;
        }

    }
}
