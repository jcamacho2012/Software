using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VentaSoftware.Models
{
    public class Cliente
    {
        public int Id_cliente { get; set; }
        public int Cod_cliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Empresa { get; set; }
        public DateTime Fecha_nac { get; set; }
        public string Tipo_cliente { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Mail { get; set; }
        public string Cod_Identif { get; set; }
        public string Tip_Identif { get; set; }
        public int UserID { get; set; }
        public bool Estado { get; set; }
                      
        public virtual ICollection<CarritoCompra> CarritoCompras { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
    }
}