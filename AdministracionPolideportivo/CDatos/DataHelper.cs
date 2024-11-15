using System;
using System.Data;
using System.Data.SqlClient;

namespace AdministracionPolideportivo.CDatos
{
    public class DataHelper
    {
        //Al igual que en ConexionDB, se debe cambiar el nombre de la base de datos y el servidor.
        

        String pcLucas = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=complejoPolideportivoProd;Data Source=DESKTOP-250LNCS\\SQLEXPRESS";
        String pcGonzalo = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=complejoPolideportivoProd;Data Source=Gnzl\\SQLEXPRESS";
        private string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=complejoPolideportivoProd;Data Source=DESKTOP-250LNCS\\SQLEXPRESS";

        public DataTable ExecuteQueryConParametros(string query, DateTime? fechaInicio, DateTime? fechaFin)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Agregar los parámetros de fecha si están presentes
                if (fechaInicio.HasValue)
                {
                    command.Parameters.AddWithValue("@fechaInicio", fechaInicio.Value);
                }
                if (fechaFin.HasValue)
                {
                    command.Parameters.AddWithValue("@fechaFin", fechaFin.Value);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable result = new DataTable();
                adapter.Fill(result);
                return result;
            }
        }
    }
}