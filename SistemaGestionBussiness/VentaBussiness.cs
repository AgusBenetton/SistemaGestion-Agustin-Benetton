using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public static class VentaBussiness
    {
        public static List<Venta> ObtenerVenta()
        {
            return VentaData.ObtenerVenta(1);
        }

        public static List<Venta> ListarVenta()
        {
            return VentaData.ListarVenta();
        }
        public static List<Venta> CrearVenta()
        {
            return VentaData.CrearVenta();
        }
        public static List<Venta> ModificarVenta()
        {
            return VentaData.ModificarVenta();
        }
        public static List<Venta> EliminarVenta()
        {
            return VentaData.EliminarVenta();
        }
    }
}
