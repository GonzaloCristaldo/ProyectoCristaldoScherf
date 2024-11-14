using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionPolideportivo.CNegocio;

namespace AdministracionPolideportivo.CDatos
{
    internal class DALMedioPago
    {

        public static List<MedioPago> ListarMedios()
        {
            List<MedioPago> lista = new List<MedioPago>();

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from Medio_Pago";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    MedioPago medioPago = new MedioPago(lector.GetInt32(0),lector.GetString(1));
                    lista.Add(medioPago);
                }
                conexion.Close();
            }

            return lista;
        }

        internal static MedioPago BuscarPorId(int input)
        {
            List<MedioPago> lista = new List<MedioPago>();

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from Medio_Pago where id_medio="+input+";";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    MedioPago medioPago = new MedioPago(lector.GetInt32(0), lector.GetString(1));
                    lista.Add(medioPago);
                }
                conexion.Close();
            }

            return lista.First();
        }
    }
}
