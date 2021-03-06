﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace VentaSoftware.Models
{
    [Table("Tb_Producto")]
    public class Producto
    {
        [Key]
        public int Id_producto { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Creador { get; set; }
        [Required]
        public string Lenguaje { get; set; }
        [Required, Display(Name = "Base de Datos")]
        public string BaseDatos { get; set; }
        [Required]
        public string Area { get; set; }
        [Required]
        public string Funcion { get; set; }
        [Required, DataType(DataType.MultilineText)]
        public string Detalle { get; set; }
        [Display(Name = "Conexiones Maximas")]
        public int CapMaxConexiones { get; set; }
        public int CapMaxBase { get; set; }
        public bool Estado { get; set; }

        [DisplayName("Imagen")]
        [MaxLength]
        public byte[] ImagenLogo { get; set; }

        public virtual ICollection<Modalidad> Modalidades { get; set; }
        public virtual ICollection<DetalleCarrito> DetalleCarritos { get; set; }
        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }
    }
}