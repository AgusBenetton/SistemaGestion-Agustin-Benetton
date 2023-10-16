using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet(Name = "ObtenerProductoVendido")]
        public IEnumerable<ProductoVendido> Get()
        {
            return ProductoVendidoBussiness.ObtenerProductoVendido();
        }
    }
}
