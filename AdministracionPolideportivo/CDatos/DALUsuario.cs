using AdministracionPolideportivo.CNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections;

namespace AdministracionPolideportivo.CDatos
{
    internal class DALUsuario
    {

        public static int AgregarCliente(Usuario usuario)
        {

            int resultado = 0;

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String fechaNacimiento = "'" + usuario.fechaNacimiento.Year + "-" + usuario.fechaNacimiento.Month + "-" + usuario.fechaNacimiento.Day + "'";
                String fechaIngreso ="'"+usuario.fechaIngreso.Year+"-"+usuario.fechaIngreso.Month+"-"+usuario.fechaIngreso.Day+"'";
                String query = "insert into Usuario (DNI_Usuario,Nombre_Usuario,Apellido_Usuario,Fecha_Ingreso,Fecha_Nacimiento,pass,telefono,Id_Tipo) values (" + usuario.DniUsuario + ",'" + usuario.nombreUsuario + "','" + usuario.apellidoUsuario +
                    ","+fechaIngreso+","+fechaNacimiento+
                    ",'"+usuario.pass+"','" +usuario.Telefono + "',"+usuario.tipoUsuario.idTipoUsuario + ");";
                SqlCommand comando = new SqlCommand(query, conexion);
                resultado = comando.ExecuteNonQuery();
            }

            return resultado;
        }

        public static Usuario Login(int dni, String contraseña)
        {
            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from Usuario where (DNI_Usuario="+dni+" and pass='"+contraseña+"');";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                lector.Read();
                Usuario usuario = new Usuario();
                usuario.idUsuario = lector.GetInt32(0);
                usuario.DniUsuario = lector.GetInt32(1);
                usuario.nombreUsuario = lector.GetString(2);
                usuario.apellidoUsuario = lector.GetString(3);
                usuario.pass = lector.GetString(6);
                usuario.Telefono = lector.GetString(7);
                TipoUsuario tipo = new TipoUsuario(-1,"error");
                if (lector.GetInt32(8)==1)
                {
                    tipo = new TipoUsuario(1,"Administrador");
                }
                else if (lector.GetInt32(8) == 2)
                {
                    tipo = new TipoUsuario(2, "SuperAdministrador");
                }
                else if (lector.GetInt32(8) == 3)
                {
                    tipo = new TipoUsuario(3, "Recepcionista");
                }
                usuario.tipoUsuario = tipo;
                conexion.Close();
                return usuario;
            }

        }

    }
}
