using System;
using SistemaGestionWebApi.Modelos;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionWebApi.Repositorio
{
    internal static class ManejadorVenta
    {
        public static string cadenaConexion = "Data Source=DESKTOP-U9SILR3;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static List<Venta> ObtenerVentasUsuario(long id)
        {
            List<Venta> ventas = new();
            using (SqlConnection connection = new(cadenaConexion))
            {
                SqlCommand comando = new("SELECT * FROM Venta WHERE IdUsuario = @id", connection);
                comando.Parameters.AddWithValue("@id", id);

                connection.Open();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Venta VentaTemporal = new Venta();
                        VentaTemporal.Id = reader.GetInt64(0);
                        VentaTemporal.Comentarios = reader.GetString(1);
                        VentaTemporal.IdUsuario = reader.GetInt64(2);
                        ventas.Add(VentaTemporal);
                    }

                }
            }

            return ventas;
        }
    }
}
