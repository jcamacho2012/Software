using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VentaSoftware.Models
{
    public class Modalidad
    {
        public int Id_Modalidad { get; set; }        
        public int Id_Producto { get; set; }
        public string TipoModalidad { get; set; }
        public string Detalle { get; set; }
        public string Costo { get; set; }
        public bool Estado { get; set; }
           
        public virtual Producto Producto { get; set; }        
    }
}