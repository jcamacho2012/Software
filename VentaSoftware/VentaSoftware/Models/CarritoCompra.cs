using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VentaSoftware.Models
{
    public class CarritoCompra
    {
        public int IdCarrito { get; set; }
        public int IdCliente { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public float PrecioUnitario { get; set; }
        public int PorcDescuento { get; set; }
        public float ValorTotal { get; set; }
        public int IdContrato { get; set; }
        public bool Estado { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Producto Producto { get; set; }
        public virtual Contrato Contrato { get; set; }
    }
}