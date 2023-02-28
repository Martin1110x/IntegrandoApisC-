using SistemaGestionWebApi.Modelos;
using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionWebApi.Repositorio
{
    internal static class ManejadorUsuario
    {
        public static string cadenaConexion = "Data Source=DESKTOP-U9SILR3;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static Usuario ObtenerUsuario(long id)
        {
            Usuario usuario = new Usuario();
            using (SqlConnection connection = new(cadenaConexion))
            {
                SqlCommand comando = new("SELECT * FROM Usuario WHERE id = @id", connection);
                comando.Parameters.AddWithValue("@id", id);

                connection.Open();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    usuario.Id = reader.GetInt64(0);
                    usuario.Nombre = reader.GetString(1);
                    usuario.Apellido = reader.GetString(2);
                    usuario.NombreUsuario = reader.GetString(3);
                    usuario.Contraseña = reader.GetString(4);
                    usuario.Mail = reader.GetString(5);
                }
            }
            return usuario;
        }

        public static Usuario Login(string nombreUsuario, string contraseña)
        {
            Usuario usuario = new Usuario();
            using (SqlConnection connection = new(cadenaConexion))
            {
                SqlCommand comando = new("SELECT * FROM Usuario WHERE nombreUsuario = @nombreUsuario AND contraseña = @contraseña", connection);
                comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                comando.Parameters.AddWithValue("@contraseña", contraseña);

                connection.Open();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    usuario.Id = reader.GetInt64(0);
                    usuario.Nombre = reader.GetString(1);
                    usuario.Apellido = reader.GetString(2);
                    usuario.NombreUsuario = reader.GetString(3);
                    usuario.Contraseña = reader.GetString(4);
                    usuario.Mail = reader.GetString(5);

                    Console.WriteLine("Se introdujeron correctamente el nombre de usuario y contraseña");

                    return usuario;
                }
                else
                {
                    Console.WriteLine("El usuario y la contraseña introducidas no son correctas.");
                    return null;
                }
            }
        }
        public static int ActualizarUsuario(Usuario usuario, long id)
        {
            using (SqlConnection connection = new(cadenaConexion))
            {
                    SqlCommand comando = new("UPDATE Usuario SET nombre = @nombre, apellido = @apellido, nombreUsuario = @nombreUsuario, contraseña = @contraseña, mail = @mail WHERE id = @id", connection);
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    comando.Parameters.AddWithValue("@apellido", usuario.Apellido);
                    comando.Parameters.AddWithValue("@nombreUsuario", usuario.NombreUsuario);
                    comando.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
                    comando.Parameters.AddWithValue("@mail", usuario.Mail);

                    connection.Open();
                    return comando.ExecuteNonQuery();
            }
        }

        public static int InsertarUsuario(Usuario usuario)
        {
            using (SqlConnection connection = new(cadenaConexion))
            {
                SqlCommand comando = new("INSERT INTO Usuario(Nombre, Apellido, NombreUsuario, Contraseña, Mail)" +
                    "VALUES(@nombre, @apellido, @nombreUsuario, @contraseña, @mail)", connection);
                comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
                comando.Parameters.AddWithValue("@apellido", usuario.Apellido);
                comando.Parameters.AddWithValue("@nombreUsuario", usuario.NombreUsuario);
                comando.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
                comando.Parameters.AddWithValue("@mail", usuario.Mail);

                connection.Open();
                return comando.ExecuteNonQuery();
            }
        }
        public static int BorrarUsuario(long id)
        {
            using (SqlConnection connection = new(cadenaConexion))
            {
                SqlCommand comando = new("DELETE FROM Usuario WHERE id = @id", connection);
                comando.Parameters.AddWithValue("@id", id);
                connection.Open();
                return comando.ExecuteNonQuery();
            }
        }
    }

    
}
