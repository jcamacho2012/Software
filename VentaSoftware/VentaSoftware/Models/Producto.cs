using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VentaSoftware.Models
{
    public class Producto
    {
        public int Id_producto { get; set; }
        public string Nombre { get; set; }
        public string Creador { get; set; }
        public string Lenguaje { get; set; }
        public string BaseDatos { get; set; }
        public string Area { get; set; }
        public float Costo { get; set; }
        public string Funcion { get; set; }

        [DataType(DataType.MultilineText)]
        public string Detalle { get; set; }
        public int CapMaxConexiones { get; set; }
        public int CapMaxBase { get; set; }
        public bool Estado { get; set; }

        public virtual ICollection<Modalidad> Modalidades { get; set; }
        public virtual ICollection<DetalleCarrito> DetalleCarritos { get; set; }
        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }
    }
}