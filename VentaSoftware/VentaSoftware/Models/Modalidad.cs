using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VentaSoftware.Models
{
    [Table("Tb_Modalidad")]
    public class Modalidad
    {
        [Key]
        public int Id_Modalidad { get; set; }        
        public int Id_Producto { get; set; }
        public string TipoModalidad { get; set; }
        public string Detalle { get; set; }
        public string Costo { get; set; }
        public bool Estado { get; set; }
           
        public virtual Producto Producto { get; set; }        
    }
}