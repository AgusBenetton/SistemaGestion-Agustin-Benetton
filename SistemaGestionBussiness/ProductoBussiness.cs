using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public static class ProductoBussiness
    {
        public static List<Producto> ObtenerProductos()
        {
            return ProductoData.ObtenerProducto(1);
        }

        public static List<Producto> ListarProducto()
        {
            return ProductoData.ListarProducto();
        }
        public static List<Producto> CrearProducto(Producto producto)
        {
            return ProductoData.CrearProducto();
        }
        public static List<Producto> ModificarProducto(Producto producto)
        {
            return ProductoData.ModificarProducto();
        }
        public static List<Producto> EliminarProducto(int id)
        {
            return ProductoData.EliminarProducto();
        }
    }

}
