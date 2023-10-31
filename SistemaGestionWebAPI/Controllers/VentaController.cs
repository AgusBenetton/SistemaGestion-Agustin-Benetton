using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionEntities;
using SistemaGestionBussiness;

namespace SistemaGestionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpGet(Name = "ObtenerVenta")]
        public IEnumerable<Venta> get()
        {
            return VentaBussiness.ObtenerVenta();
        }

        [HttpPost(Name = "CargarVenta")]
        public void Post([FromBody] Venta Venta )
        {
            VentaBussiness.CrearVenta(Venta);
        }

        [HttpDelete(Name = "EliminarVenta")]
        public void Delete([FromBody] int Id)
        {
            VentaBussiness.EliminarVenta(Id);
        }
    }
}
