using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VentaSoftware.Models
{
    public class TipoIdentificacion
    {
        public int IdTipoIdentificacion { get; set; }
        public string Detalle { get; set; }
        public bool Estado { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}