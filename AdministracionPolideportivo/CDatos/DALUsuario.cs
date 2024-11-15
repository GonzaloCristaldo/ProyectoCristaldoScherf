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
    internal class DALUsuario
    {
       

        public static byte[] pruebaFoto()
        {
            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                const string statement = "SELECT [foto_usuario] FROM usuario  WHERE id_Usuario = 8;";

                using (var cmd = new SqlCommand() { Connection = conexion, CommandText = statement })
                {

                    try
                    {
                        conexion.Open();

                        var reader = cmd.ExecuteReader();
                        conexion.Close();

                        if (reader.HasRows)
                        {
                            reader.Read();

                            // the blob column
                            var fieldOrdinal = reader.GetOrdinal("foto_usuario");

                            var blob = new byte[(reader.GetBytes(
                                fieldOrdinal, 0,
                                null, 0,
                                int.MaxValue))];

                            reader.GetBytes(fieldOrdinal, 0, blob, 0, blob.Length);

                            
                            return blob;

                        }


                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return new byte[0];

                    }
                }
            }
            return new byte[0];
        }

        public static int AgregarUsuario(Usuario usuario)
        {
           
            int resultado = 0;

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {

               /**/


                String fechaNacimiento = "'" + usuario.fechaNacimiento.Year + "-" + usuario.fechaNacimiento.Month + "-" + usuario.fechaNacimiento.Day + "'";
                String fechaIngreso ="'"+usuario.fechaIngreso.Year+"-"+usuario.fechaIngreso.Month+"-"+usuario.fechaIngreso.Day+"'";
                String query = "insert into Usuario (DNI_Usuario,Nombre_Usuario,foto_usuario,Apellido_Usuario,Fecha_Ingreso,Fecha_Nacimiento,pass,telefono,Id_Tipo,Sexo_Usuario) values (" + 
                    usuario.DniUsuario + ",'" + usuario.nombreUsuario + "',@foto,'"//AQUI HAY QUE CONVERTIR LA FOTO QUE ESTA EN BYTE[] A VARBINARY PARA LA INSERCION EN LA DB
                    + usuario.apellidoUsuario + "',"+fechaIngreso+","+fechaNacimiento+
                    ",'"+usuario.pass+"','" +usuario.Telefono + "',"+usuario.tipoUsuario.idTipoUsuario +",'"+usuario.sexo+ "');";


                

                /*String query = "insert into Cliente (dni_cliente,nombre_cliente,apellido_cliente,telefono_cliente) values (" +
                        cliente.DniCliente + ",'" + cliente.NombreCliente + "','" + cliente.ApellidoCliente + "','" + cliente.Telefono + "');";*/


                SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.Add("@foto",
                        SqlDbType.VarBinary, usuario.foto.Length).Value = usuario.foto;
                resultado = comando.ExecuteNonQuery();
            }

            return resultado;
        }

        public static Usuario Login(int dni, string contraseña)
        {
            // Validación: DNI y contraseña no deben estar vacíos
            if (dni == 0)
            {
                MessageBox.Show("Por favor, ingrese su DNI.");
                return null;
            }

            if (string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, ingrese su contraseña.");
                return null;
            }

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                // Consulta utilizando parámetros para evitar inyección de SQL
                string query = "SELECT * FROM Usuario WHERE DNI_Usuario = @dni AND pass = @contraseña";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@dni", dni);
                comando.Parameters.AddWithValue("@contraseña", contraseña);
                try
                {
                    SqlDataReader lector = comando.ExecuteReader();
                    // Verificar si hay datos
                    if (lector.Read())
                    {
                        Usuario usuario = new Usuario();
                        usuario.idUsuario = lector.GetInt32(0);
                        usuario.DniUsuario = lector.GetInt32(1);
                        usuario.nombreUsuario = lector.GetString(3);
                        usuario.apellidoUsuario = lector.GetString(4);
                        usuario.pass = lector.GetString(7);
                        usuario.Telefono = lector.GetString(8);
                        //usuario.tipoUsuario = new TipoUsuario(lector.GetString(8));

                        // Asignación del tipo de usuario
                        TipoUsuario tipo = new TipoUsuario(-1, "error");
                        int tipoUsuario = lector.GetInt32(9);
                        switch (tipoUsuario)
                        {
                            case 1:
                                tipo = new TipoUsuario(1, "Administrador");
                                break;
                            case 2:
                                tipo = new TipoUsuario(2, "SuperAdministrador");
                                break;
                            case 3:
                                tipo = new TipoUsuario(3, "Recepcionista");
                                break;
                        }
                        usuario.tipoUsuario = tipo;

                        return usuario; // Retorna el usuario si es válido
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar iniciar sesión: " + ex.Message);
                    return null;
                }
            }
        }

        internal static int EditarCliente(Cliente cliente)
        {
            int resultado = 0;//mayo a 0 representa exitoso, ya que se altero una cantidad de columnas mayor a 0, es decir, efectivamente se altero el cliente
            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "UPDATE Cliente SET dni_cliente = @dni, nombre_cliente = @nombre, apellido_cliente = @apellido, telefono_cliente = @telefono WHERE id_cliente = @id;";

                SqlCommand comando = new SqlCommand(query, conexion);

                // Add parameters
                comando.Parameters.AddWithValue("@dni", cliente.DniCliente);
                comando.Parameters.AddWithValue("@nombre", cliente.NombreCliente);
                comando.Parameters.AddWithValue("@apellido", cliente.ApellidoCliente);
                comando.Parameters.AddWithValue("@telefono", cliente.Telefono);
                comando.Parameters.AddWithValue("@id", cliente.IdCliente);

                resultado = comando.ExecuteNonQuery();
                conexion.Close();
            }

            return resultado;
        }

        public static int ModificarUsuario(Usuario usuario)
        {
            int resultado = 0;

            try
            {
                using (SqlConnection conexion = ConexionDB.GetConexion())
                {
                    // Asegúrate de que la conexión esté cerrada antes de abrirla
                    if (conexion.State == System.Data.ConnectionState.Open)
                    {
                        conexion.Close();
                    }

                    conexion.Open();

                    String query = @"
                UPDATE Usuario 
                SET 
                    DNI_Usuario = @DNI_Usuario, 
                    Nombre_Usuario = @Nombre_Usuario, 
                    foto_usuario = @foto_usuario, 
                    Apellido_Usuario = @Apellido_Usuario, 
                    Fecha_Ingreso = @Fecha_Ingreso, 
                    Fecha_Nacimiento = @Fecha_Nacimiento, 
                    pass = @pass, 
                    telefono = @telefono, 
                    Id_Tipo = @Id_Tipo, 
                    Sexo_Usuario = @Sexo_Usuario 
                WHERE id_Usuario = @id_Usuario";

                    SqlCommand comando = new SqlCommand(query, conexion);

                    // Añadir parámetros
                    comando.Parameters.AddWithValue("@DNI_Usuario", usuario.DniUsuario);
                    comando.Parameters.AddWithValue("@Nombre_Usuario", usuario.nombreUsuario);
                    comando.Parameters.AddWithValue("@foto_usuario", usuario.foto);
                    comando.Parameters.AddWithValue("@Apellido_Usuario", usuario.apellidoUsuario);
                    comando.Parameters.AddWithValue("@Fecha_Ingreso", usuario.fechaIngreso.ToString("yyyy-MM-dd"));
                    comando.Parameters.AddWithValue("@Fecha_Nacimiento", usuario.fechaNacimiento.ToString("yyyy-MM-dd"));
                    comando.Parameters.AddWithValue("@pass", usuario.pass);
                    comando.Parameters.AddWithValue("@telefono", usuario.Telefono);
                    comando.Parameters.AddWithValue("@Id_Tipo", usuario.tipoUsuario.idTipoUsuario);
                    comando.Parameters.AddWithValue("@Sexo_Usuario", usuario.sexo);
                    comando.Parameters.AddWithValue("@id_Usuario", usuario.idUsuario);

                    // Ejecutar comando
                    resultado = comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al modificar el usuario: " + ex.Message);
            }

            return resultado;
        }




        public static List<Usuario> ListarUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from Usuario";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Stream stream=lector.GetStream(2); 

                    byte[] foto = new byte[stream.Length];

                    for(int i = 0; i < foto.Length;i++)
                    {   
                        int byteLeido = stream.ReadByte();
                        if (byteLeido != -1)
                        {
                            foto[i]= (byte)byteLeido;
                        }
                        
                    }

                    Usuario usuario = new Usuario(lector.GetInt32(0),lector.GetString(3), lector.GetString(4), DALTipoUsuario.getTipoUsuarioPorId(lector.GetInt32(9)), lector.GetString(7),lector.GetInt32(1),lector.GetDateTime(6), lector.GetDateTime(5),lector.GetString(8), foto,lector.GetString(10));
                    lista.Add(usuario);
                }
                conexion.Close();
            }

            return lista;
        }

        public static Image TraerFotoUsuario(int idUsuario)
        {
            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                // Consulta utilizando parámetros para evitar inyección de SQL
                string query = "SELECT foto_usuario FROM Usuario WHERE id_usuario = @id_usuario_p";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@id_usuario_p", idUsuario);
                try
                {
                    byte[] imageData = (byte[])comando.ExecuteScalar();
                    // Verificar si hay datos
                    if (imageData.Length>0)
                    {
                        // Si hay una imagen, conviértela y muéstrala en el PictureBox
                        if (imageData != null)
                        {
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                return Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            // Si no hay imagen, limpia el PictureBox
                            return null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("id de usuario o imagen invalida.");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }


        public static List<Usuario> BuscarPorID(String input)
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from Usuario where id_usuario = " + input + ";";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    /*byte[] fotoBytes = new byte[Int32.MaxValue];
                    lector.GetBytes(2, 0, fotoBytes, 0, Int32.MaxValue);*/
                    Usuario usuario = new Usuario(lector.GetInt32(0),lector.GetString(3),lector.GetString(4),
                        DALTipoUsuario.getTipoUsuarioPorId(lector.GetInt32(9)),lector.GetString(7),
                        lector.GetInt32(1),lector.GetDateTime(6), lector.GetDateTime(5),lector.GetString(8),
                        new byte[0],lector.GetString(10));
                    lista.Add(usuario);
                }
                conexion.Close();
            }

            return lista;
        }


        public static List<Usuario> BuscarPorDNI(String input)
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from Usuario where dni_usuario = " + input + ";";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Usuario usuario = new Usuario(lector.GetInt32(0), lector.GetString(3), lector.GetString(4),
                        DALTipoUsuario.getTipoUsuarioPorId(lector.GetInt32(9)), lector.GetString(7),
                        lector.GetInt32(1), lector.GetDateTime(6), lector.GetDateTime(5), lector.GetString(8),
                        new byte[0], lector.GetString(10));
                    lista.Add(usuario);
                }
                conexion.Close();
            }

            return lista;
        }

        public static List<Usuario> BuscarPorNombre(String input)
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from Usuario where nombre_usuario LIKE '%" + input + "%';";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Usuario usuario = new Usuario(lector.GetInt32(0), lector.GetString(3), lector.GetString(4),
                        DALTipoUsuario.getTipoUsuarioPorId(lector.GetInt32(9)), lector.GetString(7),
                        lector.GetInt32(1), lector.GetDateTime(6), lector.GetDateTime(5), lector.GetString(8),
                        new byte[0], lector.GetString(10));
                    lista.Add(usuario);
                }
                conexion.Close();
            }

            return lista;
        }

        public static List<Usuario> BuscarPorApellido(String input)
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from Usuario where apellido_usuario LIKE '%" + input + "%';";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Usuario usuario = new Usuario(lector.GetInt32(0), lector.GetString(3), lector.GetString(4),
                        DALTipoUsuario.getTipoUsuarioPorId(lector.GetInt32(9)), lector.GetString(7),
                        lector.GetInt32(1), lector.GetDateTime(6), lector.GetDateTime(5), lector.GetString(8),
                        new byte[0], lector.GetString(10));
                    lista.Add(usuario);
                }
                conexion.Close();
            }

            return lista;
        }

        public static List<Usuario> BuscarPorTelefono(String input)
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String query = "select * from Usuario where telefono LIKE '%" + input + "%';";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Usuario usuario = new Usuario(lector.GetInt32(0), lector.GetString(3), lector.GetString(4),
                        DALTipoUsuario.getTipoUsuarioPorId(lector.GetInt32(9)), lector.GetString(7),
                        lector.GetInt32(1), lector.GetDateTime(6), lector.GetDateTime(5), lector.GetString(8),
                        new byte[0], lector.GetString(10));
                    lista.Add(usuario);
                }
                conexion.Close();
            }

            return lista;
        }


    }
}
