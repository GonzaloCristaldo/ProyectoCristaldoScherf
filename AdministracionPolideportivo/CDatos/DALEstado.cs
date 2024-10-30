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
    internal class DALEstado
    {

        public static Estado BuscarEstado(String input)
        {
            Estado estado= new Estado();

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from Estado where nombre_estado = '" + input + "';";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    estado.nombre= lector.GetString(1);
                    estado.id = lector.GetInt32(0);
                }
                conexion.Close();
            }

            return estado;
        }

    }
}
