using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VentaSoftware.Models
{
    public class Contrato
    {
        public int Id_contrato { get; set; }
        public int Id_cliente { get; set; }
        public int Id_producto { get; set; }
        public int Id_tipocontrato { get; set; }
        public string Detalle { get; set; }
        public bool Estado { get; set; }

        public virtual TipoContrato TipoContrato { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Producto Producto { get; set; }
        public virtual ICollection<CarritoCompra> CarritoCompras { get; set; }
        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }
    }
}