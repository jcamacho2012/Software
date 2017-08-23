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
            // Crea tipos de clientes
            var tiposCliente = LlenarTipoCliente();
            tiposCliente.ForEach(s => context.TipoClientes.Add(s));
            context.SaveChanges();

            //Crea tipos de contratos
            var tiposContrato = LlenarTipoContrato();
            tiposContrato.ForEach(s => context.TipoContratos.Add(s));
            context.SaveChanges();

            //Crea tipos de Identificacion
            var tiposIdentificacion = LlenarTipoIdentificacion();
            tiposIdentificacion.ForEach(s => context.TipoIdentificaciones.Add(s));
            context.SaveChanges();

            //Crea registros de productos
            var productos = LlenarProducto();
            productos.ForEach(s=>context.Productos.Add(s));
            context.SaveChanges();

            //Crea registros de contratos
            var contratos = LlenarContratos();
            contratos.ForEach(s=>context.Contratos.Add(s));
            context.SaveChanges();

            //Crea registros de clientes
            var clientes = LlenarClientes();
            clientes.ForEach(s => context.Clientes.Add(s));
            context.SaveChanges();

        }

        public List<TipoCliente> LlenarTipoCliente()
        {
            var tipos = new List<TipoCliente>
            {
                new TipoCliente
                {
                    Id_tipocliente=1,
                    Descripcion="Usuario",
                    Estado=true
                },
                new TipoCliente
                {
                    Id_tipocliente=2,
                    Descripcion="Compañia",
                    Estado=true
                }
            };
            return tipos;
        }

        public List<TipoContrato> LlenarTipoContrato()
        {
            var tipos = new List<TipoContrato>
            {
                new TipoContrato
                {
                    Id_tipocontrato=1,
                    DetalleContrato="Compra",
                    CapUsuarios=3,
                    TiempoContrato=0,
                    Estado=true
                },
                new TipoContrato
                {
                    Id_tipocontrato=2,
                    DetalleContrato="Alquiler",
                    CapUsuarios=3,
                    TiempoContrato=1,
                    Estado=true
                }
            };
            return tipos;
        }

        public List<TipoIdentificacion> LlenarTipoIdentificacion()
        {
            var tipos = new List<TipoIdentificacion>
            {
                new TipoIdentificacion
                {
                    IdTipoIdentificacion=1,
                    Detalle="RUC",
                    Estado=true
                },
                new TipoIdentificacion
                {
                    IdTipoIdentificacion=2,
                    Detalle="CEDULA",
                    Estado=true
                }
            };

            return tipos;
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

        public List<Contrato> LlenarContratos()
        {
            var contratos = new List<Contrato>
            {
                new Contrato
                {
                    Id_contrato=1,
                    Id_cliente=1,
                    Id_producto=1,
                    Id_tipocontrato=1,
                    Detalle="Usuario",
                    Estado=true
                },
                new Contrato
                {
                    Id_contrato=2,
                    Id_cliente=1,
                    Id_producto=2,
                    Id_tipocontrato=2,
                    Detalle="Anual",
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
                    Apellido="Velez",
                    Empresa="NA",
                    Fecha_nac=DateTime.Today,
                    Tipo_cliente=1,
                    Telefono="042345679",
                    Direccion="Samanes 7",
                    Mail="correo@mail.com",
                    Tip_Identif=2,
                    Cod_Identif="0933245678",
                    Usuario="evelez",
                    Contrasena="123456",
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
                    Tipo_cliente=1,
                    Telefono="042225679",
                    Direccion="Alborada",
                    Mail="correo@mail.com",
                    Tip_Identif=2,
                    Cod_Identif="0932342478",
                    Usuario="hsanchez",
                    Contrasena="123456",
                    Estado=true
                }
            };

            return clientes;
        }
    }
}