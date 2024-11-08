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
            String pcLucas= "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=complejoPolideportivo;Data Source=DESKTOP-250LNCS\\SQLEXPRESS";
            String pcGonzalo = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=complejoPolideportivo;Data Source=Gnzl\\SQLEXPRESS";
            String query = pcLucas;
            SqlConnection conexion = new SqlConnection(query);
            conexion.Open();
            return conexion;
        }

    }
}
