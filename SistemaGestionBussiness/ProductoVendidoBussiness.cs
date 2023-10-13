using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
  
    
        public static class ProductoVendidoBussiness
        {
            public static List<ProductoVendido> ObtenerProductoVendido()
            {
                return ProductoVendidoData.ObtenerProductoVendido(1);
            }

            public static List<ProductoVendido> ListarProductoVendido()
            {
            return ProductoVendidoData.ListarProductoVendido();
            }
            public static List<ProductoVendido> CrearProductoVendido()
            {
                return ProductoVendidoData.CrearProductoVendido();
            }
            public static List<ProductoVendido> ModificarProductoVendido()
            {
                return ProductoVendidoData.ModificarProductoVendido();
            }
            public static List<ProductoVendido> EliminarProductoVendido()
            {
                return ProductoVendidoData.EliminarProductoVendido();
            }
        }
    
}
