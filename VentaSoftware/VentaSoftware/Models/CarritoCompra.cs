using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VentaSoftware.Models
{
    [Table("Tb_CarritoCompra")]
    public class CarritoCompra
    {
        [Key]
        public int IdCarritoCompra { get; set; }
        public int IdCliente { get; set; }        
        public bool Estado { get; set; }

        public virtual Cliente Cliente { get; set; }
        public ICollection<DetalleCarrito> DetalleCarritos { get; set; }        
    }
}