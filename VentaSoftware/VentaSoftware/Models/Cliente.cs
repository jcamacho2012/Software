using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VentaSoftware.Models
{
    [Table("Tb_Cliente")]
    public class Cliente
    {
        [Key]
        public int Id_cliente { get; set; }
        public int Cod_cliente { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Empresa { get; set; }
        [Required, Display(Name ="Fecha de Nacimiento"),DataType(DataType.Date)]
        public DateTime Fecha_nac { get; set; }
        [Required, Display(Name = "Tipo Cliente")]
        public string Tipo_cliente { get; set; }
        [Required]
        public string Telefono { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required, DataType(DataType.EmailAddress), EmailAddress]
        public string Mail { get; set; }
        [Required, Display(Name = "Identificacion")]
        public string Cod_Identif { get; set; }
        [Required, Display(Name = "Tipo de Identificacion")]
        public string Tip_Identif { get; set; }
        public int UserID { get; set; }
        public bool Estado { get; set; }
                      
        public virtual ICollection<CarritoCompra> CarritoCompras { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
    }
}