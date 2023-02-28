using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionWebApi.Modelos;
using SistemaGestionWebApi.Repositorio;

namespace SistemaGestionWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet("{idUsuario}")] 
        public List<ProductoVendido> ObtenerProductoVendido(long idUsuario)
        {
            return ManejadorProductoVendido.ObtenerProductoVendidoUsuario(idUsuario);
        }
    }
}
