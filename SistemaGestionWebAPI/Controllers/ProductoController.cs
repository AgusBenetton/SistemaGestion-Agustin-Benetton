using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionEntities;
using SistemaGestionBussiness;


namespace SistemaGestionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProductoController : ControllerBase
    {
        [HttpGet(Name = "ObtenerProducto")]
        public IEnumerable<Producto> Get()
        {
            return ProductoBussiness.ObtenerProductos();
        }

        [HttpDelete(Name = "EliminarProducto")]
        public void Delete([FromBody] int Id)
        {
           ProductoBussiness.EliminarProducto(Id);
        }

        [HttpPut(Name = "ModificarProducto")]
        public void Put([FromBody]  Producto Producto)
        {
           ProductoBussiness.ModificarProducto(Producto);
        }
        [HttpPost(Name = "CrearProducto")]
        public void Post([FromBody] Producto Producto)
        {
           ProductoBussiness.CrearProducto(Producto);
        }
    }
}
