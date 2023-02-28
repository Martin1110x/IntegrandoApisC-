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

        
        [HttpPost]
        public Usuario InsertarUsuario(Usuario usuario)
        {
            ManejadorUsuario.InsertarUsuario(usuario);
            return usuario;

        }

        [HttpGet("{usuario}")]
        public Usuario ObtenerUsuario(long id)
        {
            return ManejadorUsuario.ObtenerUsuario(id);
        }

        [HttpPut]
        public string ActualizarUsuario(Usuario usuario, long id)
        {
            return ManejadorUsuario.ActualizarUsuario(usuario, id) == 1 ? "Actualizado" : "No se pudo actualizar";
        }

        [HttpDelete("{id}")]
        public string BorrarUsuario(long id)
        {
            return ManejadorUsuario.BorrarUsuario(id) == 1 ? "Eliminado" : "No se pudo eliminar";
        }
    } 
}
