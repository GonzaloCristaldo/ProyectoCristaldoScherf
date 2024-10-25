﻿using AdministracionPolideportivo.CNegocio;
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
        //FALTA AGREGAR LA IMAGEN A LA BDD Y EN ESTE SCRIPT
        public static int AgregarUsuario(Usuario usuario)
        {
           
            int resultado = 0;

            using (SqlConnection conexion = ConexionDB.GetConexion())
            {
                String fechaNacimiento = "'" + usuario.fechaNacimiento.Year + "-" + usuario.fechaNacimiento.Month + "-" + usuario.fechaNacimiento.Day + "'";
                String fechaIngreso ="'"+usuario.fechaIngreso.Year+"-"+usuario.fechaIngreso.Month+"-"+usuario.fechaIngreso.Day+"'";
                String query = "insert into Usuario (DNI_Usuario,Nombre_Usuario,Apellido_Usuario,Fecha_Ingreso,Fecha_Nacimiento,pass,telefono,Id_Tipo,Sexo_Usuario) values (" + usuario.DniUsuario + ",'" + usuario.nombreUsuario + "','" + usuario.apellidoUsuario +
                    "',"+fechaIngreso+","+fechaNacimiento+
                    ",'"+usuario.pass+"','" +usuario.Telefono + "',"+usuario.tipoUsuario.idTipoUsuario +",'"+usuario.sexo+ "');";

                /*String query = "insert into Cliente (dni_cliente,nombre_cliente,apellido_cliente,telefono_cliente) values (" +
                        cliente.DniCliente + ",'" + cliente.NombreCliente + "','" + cliente.ApellidoCliente + "','" + cliente.Telefono + "');";*/


                SqlCommand comando = new SqlCommand(query, conexion);
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
                        usuario.nombreUsuario = lector.GetString(2);
                        usuario.apellidoUsuario = lector.GetString(3);
                        usuario.pass = lector.GetString(6);
                        usuario.Telefono = lector.GetString(7);
                        //usuario.tipoUsuario = new TipoUsuario(lector.GetString(8));

                        // Asignación del tipo de usuario
                        TipoUsuario tipo = new TipoUsuario(-1, "error");
                        int tipoUsuario = lector.GetInt32(8);
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

                    Usuario usuario = new Usuario(lector.GetInt32(0),lector.GetString(3), lector.GetString(4), DALTipoUsuario.getTipoUsuarioPorId(lector.GetInt32(9)), lector.GetString(7),lector.GetInt32(1),lector.GetDateTime(6), lector.GetDateTime(5),lector.GetString(8), lector.GetString(7), foto,lector.GetString(10));
                    lista.Add(usuario);
                }
                conexion.Close();
            }

            return lista;
        }

    }
}
