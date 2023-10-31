using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionEntities;

namespace SistemaGestionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpGet(Name = "Login")]
        public IEnumerable<Usuario> Getlogin(string NombreUsuario, string Contrasena)
        {
            return SistemaGestionBussiness.UsuarioBussiness.Login(NombreUsuario, Contrasena).ToArray();
        }
    }
}
