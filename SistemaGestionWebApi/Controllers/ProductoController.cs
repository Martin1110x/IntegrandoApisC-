using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionWebApi.Modelos;
using SistemaGestionWebApi.Repositorio;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpPost]
        public static Producto InsertarProducto(Producto producto)
        {
            ManejadorProducto.InsertarProducto(producto);
            return producto;
        }

        [HttpDelete("{id}")]
        public static string BorrarProducto(long id)
        {
            return ManejadorProducto.BorrarProducto(id) == 1 ? "Eliminado" : "No se pudo eliminar";
        }

        [HttpPut("{id}")]
        public static string ActualizarProducto(Producto producto)
        {
            return ManejadorProducto.ActualizarProducto(producto) == 1 ? "Actualizado" : "No se pudo actualizar";
        }
    }
}
