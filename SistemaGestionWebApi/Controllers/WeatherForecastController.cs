using Microsoft.AspNetCore.Mvc;
using SistemaGestionWebApi.Modelos;

namespace SistemaGestionWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet("rutaNueva")]
        public string Saludar()
        {
            return "Hola mundo desde API";
        }


        [HttpGet("{parametro}")]
        public string Funcion(string parametro)
        { 
            return "Parámetro:" + parametro;
        }
    }
}


