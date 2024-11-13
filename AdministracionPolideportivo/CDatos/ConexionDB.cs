using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CDatos
{
    internal class ConexionDB
    {

        SqlConnection conexionDB;

        public static SqlConnection GetConexion()
        {
            // Cambiar el nombre de la base de datos y el servidor: se hace cambiando el String query, y ademas cambiando por el nombre de la base de datos y el servidor que se esté utilizando.
            String pcLucas = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=complejoPolideportivo;Data Source=DESKTOP-250LNCS\\SQLEXPRESS";
            String pcGonzalo = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=complejoPolideportivo;Data Source=Gnzl\\SQLEXPRESS";
            String query = pcLucas;
            SqlConnection conexion = new SqlConnection(query);
            conexion.Open();
            return conexion;
        }

    }
}
