﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public float Costo { get; set; }
        public float PrecioVenta { get; set; }
        public int Stock { get; set; }
        public long IdUsuario { get; set; }


       




    }
}
