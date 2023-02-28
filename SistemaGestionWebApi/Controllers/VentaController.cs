using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionWebApi.Modelos;
using SistemaGestionWebApi.Repositorio;

namespace SistemaGestionWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VentaController : ControllerBase
    {
        [HttpPost("{idUsuario}")] //checkear
        public Venta InsertarVenta(Venta venta)
        {
            ManejadorVenta.InsertarVenta(venta);
            return venta;
        }

        [HttpGet("{idUsuario}")]
        public List<Venta> ObtenerVentasUsuario(long idUsuario)
        {
            return ManejadorVenta.ObtenerVentasUsuario(idUsuario);
        }
    }
}
