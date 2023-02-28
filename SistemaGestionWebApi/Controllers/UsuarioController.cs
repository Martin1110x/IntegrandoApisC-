using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionWebApi.Modelos;
using SistemaGestionWebApi.Repositorio;

namespace SistemaGestionWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("{usuario}/{contraseña}")]
        public Usuario Login(string usuario, string contraseña)
        {
            return ManejadorUsuario.Login(usuario, contraseña);
        }

        [HttpGet]
        public Usuario ObtenerUsuario(long id)
        {
            return ManejadorUsuario.ObtenerUsuario(id);
        }

        [HttpPut("{id}")]
        public string ActualizarUsuario(Usuario usuario, long id)
        {
            return ManejadorUsuario.ActualizarUsuario(usuario, id) == 1 ? "Actualizado" : "No se pudo actualizar";
        }
    } 
}
