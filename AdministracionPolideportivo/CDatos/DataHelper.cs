using System;
using System.Data;
using System.Data.SqlClient;

namespace AdministracionPolideportivo.CDatos
{
    public class DataHelper
    {
        private readonly string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=complejoPolideportivo;Data Source=Gonzalo";


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