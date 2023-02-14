using System;
using SistemaGestionWebApi.Modelos;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionWebApi.Repositorio
{
    internal static class ManejadorProducto
    {
        public static string cadenaConexion = "Data Source=DESKTOP-U9SILR3;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new();
            using (SqlConnection connection = new(cadenaConexion))
            {
                SqlCommand comando = new("SELECT * FROM Producto", connection);
                connection.Open();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Producto productoTemporal = new Producto();
                        productoTemporal.Id = reader.GetInt64(0);
                        productoTemporal.Descripciones = reader.GetString(1);
                        productoTemporal.Costo = reader.GetDecimal(2);
                        productoTemporal.PrecioVenta = reader.GetDecimal(3);
                        productoTemporal.Stock = reader.GetInt32(4);
                        productoTemporal.IdUsuario = reader.GetInt64(5);

                        productos.Add(productoTemporal);
                    }

                }
            }

            return productos;
        }
        public static Producto ObtenerProducto(long id)
        {
            Producto producto = new Producto();
            using (SqlConnection connection = new(cadenaConexion))
            {
                SqlCommand comando = new("SELECT * FROM Producto WHERE Id = @id", connection);
                comando.Parameters.AddWithValue("@id", id);

                connection.Open();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    producto.Id = reader.GetInt64(0);
                    producto.Descripciones = reader.GetString(1);
                    producto.Costo = reader.GetDecimal(2);
                    producto.PrecioVenta = reader.GetDecimal(3);
                    producto.Stock = reader.GetInt32(4);
                    producto.IdUsuario = reader.GetInt64(5);
                }
            }

            return producto;
        }
        public static int InsertarProducto(Producto producto)
        {
            using (SqlConnection connection = new(cadenaConexion))
            {
                SqlCommand comando = new("INSERT INTO Producto(Descripciones, Costo, PrecioVenta, Stock, IdUsuario)" +
                    "VALUES(@descripciones, @costo, @precioVenta, @stock, @idUsuario)", connection);
                comando.Parameters.AddWithValue("@descripciones", producto.Descripciones);
                comando.Parameters.AddWithValue("@costo", producto.Costo);
                comando.Parameters.AddWithValue("@precioVenta", producto.PrecioVenta);
                comando.Parameters.AddWithValue("@stock", producto.Stock);
                comando.Parameters.AddWithValue("@idUsuario", producto.IdUsuario);

                connection.Open();
                return comando.ExecuteNonQuery();
            }
        }
        public static List<Producto> ObtenerProductosUsuario(long id)
        {
            List<Producto> productos = new();
            using (SqlConnection connection = new(cadenaConexion))
            {
                SqlCommand comando = new("SELECT * FROM Producto WHERE IdUsuario = @id", connection);
                comando.Parameters.AddWithValue("@id", id);

                connection.Open();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Producto productoTemporal = new Producto();
                        productoTemporal.Id = reader.GetInt64(0);
                        productoTemporal.Descripciones = reader.GetString(1);
                        productoTemporal.Costo = reader.GetDecimal(2);
                        productoTemporal.PrecioVenta = reader.GetDecimal(3);
                        productoTemporal.Stock = reader.GetInt32(4);
                        productoTemporal.IdUsuario = reader.GetInt64(5);

                        productos.Add(productoTemporal);
                    }

                }
            }

            return productos;
        }
    }    
}

