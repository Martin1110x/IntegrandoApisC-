using Microsoft.AspNetCore.Mvc;
using SistemaGestionWebApi.Modelos;
using SistemaGestionWebApi.Repositorio;

namespace SistemaGestionWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : ControllerBase
    {
        [HttpGet("{idUsuario}")]
        public List<Producto> ObtenerProductosUsuario(long idUsuario)
        {
            return ManejadorProducto.ObtenerProductosUsuario(idUsuario);
        }

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

        [HttpPut]
        public string ActualizarProducto(Producto producto)
        {
            return ManejadorProducto.ActualizarProducto(producto) == 1 ? "Actualizado" : "No se pudo actualizar";
        }
    }
}
