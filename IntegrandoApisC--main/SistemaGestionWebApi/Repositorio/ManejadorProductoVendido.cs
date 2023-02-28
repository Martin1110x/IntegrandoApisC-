using SistemaGestionWebApi.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionWebApi.Repositorio
{
    internal static class ManejadorProductoVendido
    {
        public static string cadenaConexion = "Data Source=DESKTOP-U9SILR3;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static List<ProductoVendido> ObtenerProductoVendido(long id)
        {
            List<ProductoVendido> productosVendidos = new();
            using (SqlConnection connection = new(cadenaConexion))
            {
                SqlCommand comando = new("SELECT * FROM ProductoVendido WHERE IdVenta = @id", connection);
                comando.Parameters.AddWithValue("@id", id);

                connection.Open();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ProductoVendido ProductoVendidoTemporal = new ProductoVendido();
                        ProductoVendidoTemporal.Id = reader.GetInt64(0);
                        ProductoVendidoTemporal.Stock = reader.GetInt32(1);
                        ProductoVendidoTemporal.IdProducto = reader.GetInt64(2);
                        ProductoVendidoTemporal.IdVenta= reader.GetInt64(3);
                        productosVendidos.Add(ProductoVendidoTemporal);
                    }

                }
            }

            return productosVendidos;
        }
        public static List<ProductoVendido> ObtenerProductoVendidoUsuario(long idUsuario)
        {
            List<ProductoVendido> productosVendidos = new();
            using (SqlConnection connection = new(cadenaConexion))
            {
                SqlCommand comando = new("SELECT * FROM ProductoVendido INNER JOIN Venta ON ProductoVendido.IdVenta = @idUsuario", connection);
                comando.Parameters.AddWithValue("@idUsuario", idUsuario);

                connection.Open();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ProductoVendido ProductoVendidoTemporal = new ProductoVendido();
                        ProductoVendidoTemporal.Id = reader.GetInt64(0);
                        ProductoVendidoTemporal.Stock = reader.GetInt32(1);
                        ProductoVendidoTemporal.IdProducto = reader.GetInt64(2);
                        ProductoVendidoTemporal.IdVenta= reader.GetInt64(3);
                        productosVendidos.Add(ProductoVendidoTemporal);
                    }

                }
            }

            return productosVendidos;
        }
    }
}

