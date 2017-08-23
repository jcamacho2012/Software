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
        public int Tipo_cliente { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Mail { get; set; }
        public string Cod_Identif { get; set; }
        public int Tip_Identif { get; set; }
        public bool Estado { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }


        public virtual TipoCliente TipoCliente { get; set; }
        public virtual TipoIdentificacion TipoIdentificacion { get; set; }
        public virtual ICollection<Contrato> Contratos { get; set; }
        public virtual ICollection<CarritoCompra> CarritoCompras { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
    }
}