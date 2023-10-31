using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NombreController : ControllerBase
    {

        [HttpGet(Name = "ObtenerNombre")]
        public IEnumerable<UsuarioName> Get()
        {
            return UsuarioNameBussiness.ObtenerUsuarioNombre().ToArray();
        }
    }
}
