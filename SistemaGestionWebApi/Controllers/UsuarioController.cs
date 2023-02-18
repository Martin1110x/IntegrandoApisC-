using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionWebApi.Modelos;
using SistemaGestionWebApi.Repositorio;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("{usuario}/{contraseña}")]
        public static Usuario Login(string usuario, string contraseña)
        {
            return ManejadorUsuario.Login(usuario, contraseña);
        }

        [HttpGet]
        public static Usuario ObtenerUsuario(long id)
        {
            return ManejadorUsuario.ObtenerUsuario(id);
        }

        [HttpPut("{id}")]
        public static string ActualizarUsuario(Usuario usuario, long id)
        {
            return ManejadorUsuario.ActualizarUsuario(usuario, id) == 1 ? "Actualizado" : "No se pudo actualizar";
        }
    } 
}
