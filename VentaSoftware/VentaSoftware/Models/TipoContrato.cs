using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VentaSoftware.Models
{
    public class TipoContrato
    {
        public int Id_tipocontrato { get; set; }
        public string DetalleContrato { get; set; }
        public int CapUsuarios { get; set; }
        public int TiempoContrato { get; set; }
        public bool Estado { get; set; }

        public virtual ICollection<Contrato> Contratos { get; set; }
    }
}