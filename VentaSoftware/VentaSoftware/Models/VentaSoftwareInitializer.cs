using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace VentaSoftware.Models
{
    public class VentaSoftwareInitializer:DropCreateDatabaseAlways<VentaSoftwareContext>
    {
        protected override void Seed(VentaSoftwareContext context)
        {
            base.Seed(context);          
            //Crea registros de productos
            var productos = LlenarProducto();
            productos.ForEach(s=>context.Productos.Add(s));
            context.SaveChanges();

            //Crea registros de contratos
            var modalidades = LlenarModalidades();
            modalidades.ForEach(s => context.Modalidades.Add(s));
            context.SaveChanges();

            //Crea registros de clientes
            var clientes = LlenarClientes();
            clientes.ForEach(s => context.Clientes.Add(s));
            context.SaveChanges();

        }

        public List<Producto> LlenarProducto()
        {
            var productos = new List<Producto>
            {
                new Producto
                {
                    Id_producto=1,
                    Nombre="Kasperky",
                    Creador="Lab Kasperky",
                    Lenguaje="NA",
                    BaseDatos="NA",
                    Area="Antivirus",
                    Costo=15,
                    Funcion="Proteccion de equipos informaticos",
                    Detalle="Antivirus 2017",
                    CapMaxConexiones=0,
                    CapMaxBase=0,
                    Estado=true
                },
                new Producto
                {
                    Id_producto=2,
                    Nombre="Visual Studio 2017",
                    Creador="Microsoft",
                    Lenguaje="Visual Basic, C#, Asp Net",
                    BaseDatos="NA",
                    Area="Desarrollo",
                    Costo=10,
                    Funcion="Framework de Desarrollo de Software",
                    Detalle="Programa de desarrollo de software",
                    CapMaxConexiones=0,
                    CapMaxBase=0,
                    Estado=true
                }
            };

            return productos;
        }

        public List<Modalidad> LlenarModalidades()
        {
            var contratos = new List<Modalidad>
            {
                new Modalidad
                {
                    Id_Modalidad=1,
                    Id_Producto=1,
                    Detalle="Usuario",
                    TipoModalidad="Compra",
                    Estado=true
                },
                new Modalidad
                {
                    Id_Modalidad=2,
                    Id_Producto=1,
                    Detalle="Anual",
                    TipoModalidad="Alquiler",
                    Estado=true
                }
            };

            return contratos;
        }

        public List<Cliente> LlenarClientes()
        {
            var clientes = new List<Cliente>
            {
                new Cliente
                {
                    Id_cliente=1,
                    Cod_cliente=1,
                    Nombre="Ericka",
                    Apellido="Ramirez",
                    Empresa="NA",
                    Fecha_nac=DateTime.Today,                
                    Telefono="042345679",
                    Direccion="Samanes 7",
                    Mail="correo@mail.com",                   
                    Cod_Identif="0933245678",                    
                    Estado=true
                },
                new Cliente
                {
                    Id_cliente=2,
                    Cod_cliente=2,
                    Nombre="Hector",
                    Apellido="Sanchez",
                    Empresa="NA",
                    Fecha_nac=DateTime.Today,               
                    Telefono="042225679",
                    Direccion="Alborada",
                    Mail="correo@mail.com",                  
                    Cod_Identif="0932342478",                   
                    Estado=true
                }
            };

            return clientes;
        }
    }
}