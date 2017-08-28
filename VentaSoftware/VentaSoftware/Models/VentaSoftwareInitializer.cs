using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.IO;

namespace VentaSoftware.Models
{
    public class VentaSoftwareInitializer : DropCreateDatabaseIfModelChanges<VentaSoftwareContext>
    {
        protected override void Seed(VentaSoftwareContext context)
        {
            base.Seed(context);
            //Crea registros de productos
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
                    Funcion="Proteccion de equipos informaticos",
                    Detalle="Antivirus 2017",
                    CapMaxConexiones=0,
                    CapMaxBase=0,
                    Estado=true,
                    ImagenLogo = getFileBytes("\\Images\\kaspersky.jpg")
                },
                new Producto
                {
                    Id_producto=2,
                    Nombre="Visual Studio 2017",
                    Creador="Microsoft",
                    Lenguaje="Visual Basic, C#, Asp Net",
                    BaseDatos="NA",
                    Area="Desarrollo",
                    Funcion="Framework de Desarrollo de Software",
                    Detalle="Programa de desarrollo de software",
                    CapMaxConexiones=0,
                    CapMaxBase=0,
                    Estado=true,
                    ImagenLogo = getFileBytes("\\Images\\VisualStudio.jpg")
                },
                new Producto
                {
                    Id_producto=3,
                    Nombre="Teamviewer",
                    Creador="Teamviewer GMBH",
                    Lenguaje="NA",
                    BaseDatos="NA",
                    Area="Control Remoto",
                    Funcion="Acceso remoto y soporte seguro",
                    Detalle="TeamViewer conecta en todo el mundo",
                    CapMaxConexiones=0,
                    CapMaxBase=0,
                    Estado=true,
                    ImagenLogo = getFileBytes("\\Images\\TeamViewer.jpg")
                },
                 new Producto
                {
                    Id_producto=4,
                    Nombre="Office 365",
                    Creador="Microsoft",
                    Lenguaje="NA",
                    BaseDatos="NA",
                    Area="Productividad",
                    Funcion="Productividad, comunicación y colaboración",
                    Detalle="Gracias a la eficacia puede reducir tiempo y costes",
                    CapMaxConexiones=0,
                    CapMaxBase=0,
                    Estado=true,
                    ImagenLogo = getFileBytes("\\Images\\Office365.jpg")
                },
            };
            productos.ForEach(s => context.Productos.Add(s));
            context.SaveChanges();

            //Crea registros de contratos
            var modalidades = new List<Modalidad>
            {
                new Modalidad
                {
                    Id_Producto=1,
                    Detalle="Usuario",
                    TipoModalidad="Compra",
                    Costo="5",
                    Estado=true
                },
                new Modalidad
                {
                    Id_Producto=1,
                    Detalle="Anual",
                    TipoModalidad="Alquiler",
                    Costo="10",
                    Estado=true
                }
            };
            modalidades.ForEach(s => context.Modalidades.Add(s));
            context.SaveChanges();

            //Crea registros de clientes
            var clientes = new List<Cliente>
            {
                new Cliente
                {
                    Cod_cliente=11231,
                    Nombre="Ericka",
                    Apellido="Ramirez",
                    Empresa="NA",
                    Fecha_nac=DateTime.Today,
                    Tipo_cliente="asd",
                    Telefono="042345679",
                    Direccion="Samanes 7",
                    Mail="correo@mail.com",
                    Tip_Identif="Cedula",
                    Cod_Identif="0933245678",
                    UserID=1,
                    Estado=true
                },
                new Cliente
                {
                    Cod_cliente=223123,
                    Nombre="Hector",
                    Apellido="Sanchez",
                    Empresa="NA",
                    Fecha_nac=DateTime.Today,
                    Tipo_cliente="qweq",
                    Telefono="042225679",
                    Direccion="Alborada",
                    Mail="correo@mail.com",
                    Tip_Identif="Cedula",
                    Cod_Identif="0932342478",
                    UserID=2,
                    Estado=true
                }
            };
            clientes.ForEach(s => context.Clientes.Add(s));
            context.SaveChanges();
        }

        private byte[] getFileBytes(string path)
        {
            FileStream fileOnDisk = new FileStream(HttpRuntime.AppDomainAppPath + path, FileMode.Open);
            byte[] fileBytes;
            using (BinaryReader br = new BinaryReader(fileOnDisk))
            {
                fileBytes = br.ReadBytes((int)fileOnDisk.Length);
            }
            return fileBytes;
        }
    }
}