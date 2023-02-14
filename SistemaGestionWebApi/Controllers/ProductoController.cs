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
        public Producto InsertarProducto(Producto producto)
        {
            ManejadorProducto.InsertarProducto(producto);
            return producto;
        }

        [HttpDelete("{id}")]
        public string BorrarProducto(long id)
        {
            return ManejadorProducto.BorrarProducto(id) == 1 ? "Eliminado" : "No se pudo eliminar";
        }

        [HttpPut("{id}")]
        public string ActualizarProducto(Producto producto, long id)
        {
            return ManejadorProducto.ActualizarProducto(producto, id) == 1 ? "Actualizado" : "No se pudo actualizar";
        }
    }
}
