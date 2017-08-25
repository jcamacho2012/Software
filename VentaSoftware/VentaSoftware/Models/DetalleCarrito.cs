using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VentaSoftware.Models
{
    public class DetalleCarrito
    {
        public int IdDetalleCarrito { get; set; }
        public int IdCarritoCompra { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public float PrecioUnitario { get; set; }
        public int PorcentajeDescuento { get; set; }
        public float ValorTotal { get; set; }
        public bool Estado { get; set; }

        public virtual Producto Producto { get; set; }
    }
}