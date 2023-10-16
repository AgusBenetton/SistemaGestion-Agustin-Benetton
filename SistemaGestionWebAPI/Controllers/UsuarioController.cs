using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet(Name = "ObtenerUsusario")]
        public IEnumerable<Usuario> Get()
        {
            return UsuarioBussiness.ObtenerUsuarios().ToArray();
        }

        [HttpPut(Name = "ModificarUsuario")]
        public void Put([FromBody] Usuario Usuario)
        {
           UsuarioBussiness.ModificarUsuario(Usuario);
        }
    }
}
