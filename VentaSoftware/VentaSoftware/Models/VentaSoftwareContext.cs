using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace VentaSoftware.Models
{
    public class VentaSoftwareContext: DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CarritoCompra> CarritoCompras { get; set; }
        public DbSet<Modalidad> Modalidades { get; set; }
        public DbSet<DetalleFactura> DetalleFacturas { get; set; }
        public DbSet<DetalleCarrito> DetalleCarritos { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Producto> Productos { get; set; }        
    }
}