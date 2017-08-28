using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VentaSoftware.Models
{
    [Table("Tb_Factura")]
    public class Factura
    {
        [Key]
        public int Id_factura { get; set; }
        public string NumFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        public int Idcliente { get; set; }
        public int SubTotalPorc { get; set; }
        public float SubTotalNeto { get; set; }
        public int Descuento { get; set; }
        public float Iva { get; set; }
        public float Ice { get; set; }
        public float TotalPagar { get; set; }
        public string FormaPago { get; set; }
        public string NombreCC { get; set; }
        public string NumeroCC { get; set; }
        public string CCV { get; set; }
        public DateTime FechaExpira { get; set; }
        public bool Estado { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }
    }
}