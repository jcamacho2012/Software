using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VentaSoftware.Models
{
    public class CarritoCompra
    {
        public int IdCarritoCompra { get; set; }
        public int IdCliente { get; set; }        
        public bool Estado { get; set; }

        public virtual Cliente Cliente { get; set; }
        public ICollection<DetalleCarrito> DetalleCarritos { get; set; }        
    }
}