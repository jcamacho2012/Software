using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VentaSoftware.Models;

namespace VentaSoftware.Controllers
{
    public class ProductoController : Controller
    {
        private VentaSoftwareContext context = new VentaSoftwareContext();
        // GET: Producto
        public ActionResult Index()
        {
            return View(context.Productos.ToList());
        }

        public ActionResult CrearProducto()
        {
            Producto nuevoProducto = new Producto();
            nuevoProducto.Estado = true;
            return View("CrearProducto",nuevoProducto);
        }

        [HttpPost]
        public ActionResult CrearProducto(Producto producto, HttpPostedFileBase image, string usuario, string institucional, string mensual, string anual)
        {
            Modalidad modalidad; 
     
            if (!ModelState.IsValid)
            {
                return View("CrearProducto", producto);
            }
            else
            {
                if (image != null)
                {
                    producto.Estado = true;
                    producto.ImagenLogo = new byte[image.ContentLength];
                    image.InputStream.Read(producto.ImagenLogo, 0, image.ContentLength);
                }
                
                context.Productos.Add(producto);
                context.SaveChanges();
                Console.WriteLine("valores de variables");
                Console.WriteLine(usuario);
                Console.WriteLine(institucional);
                Console.WriteLine(mensual);
                Console.WriteLine(anual);
                int idProducto = producto.Id_producto;
                if (!string.IsNullOrEmpty(usuario))
                {
                    modalidad = new Modalidad();
                    modalidad.Id_Producto = idProducto;
                    modalidad.TipoModalidad = "Compra";
                    modalidad.Detalle = "Usuario";
                    modalidad.Costo = usuario;
                    modalidad.Estado = true;
                    context.Modalidades.Add(modalidad);
                    context.SaveChanges();
                }

                if (!string.IsNullOrEmpty(institucional))
                {
                    modalidad = new Modalidad();
                    modalidad.Id_Producto = idProducto;
                    modalidad.TipoModalidad = "Compra";
                    modalidad.Detalle = "Institucional";
                    modalidad.Costo = institucional;
                    modalidad.Estado = true;
                    context.Modalidades.Add(modalidad);
                    context.SaveChanges();
                }

                if (!string.IsNullOrEmpty(mensual))
                {
                    modalidad = new Modalidad();
                    modalidad.Id_Producto = idProducto;
                    modalidad.TipoModalidad = "Alquiler";
                    modalidad.Detalle = "Mensual";
                    modalidad.Costo = mensual;
                    modalidad.Estado = true;
                    context.Modalidades.Add(modalidad);
                    context.SaveChanges();
                }

                if (!string.IsNullOrEmpty(anual))
                {
                    modalidad = new Modalidad();
                    modalidad.Id_Producto = idProducto;
                    modalidad.TipoModalidad = "Alquiler";
                    modalidad.Detalle = "Anual";
                    modalidad.Costo = anual;
                    modalidad.Estado = true;
                    context.Modalidades.Add(modalidad);
                    context.SaveChanges();
                }
                return RedirectToAction("Index", "Home");
            }            
        }

        public ActionResult MostrarProductoxId(int id)
        {
            Producto producto = context.Productos.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View("Display", producto);
        }

        public FileContentResult GetImage(int id)
        {
            Producto p = context.Productos.Find(id);
            if (p != null)
            {
                return File(p.ImagenLogo, "image/jpeg");
            }
            else
            {
                return null;
            }
        }

        [ChildActionOnly]
        public ActionResult _ProductoGallery(int number = 0)
        {
            List<Producto> lp;
            if (number == 0)
            {
                lp = context.Productos.ToList();
            }
            else
            {
                lp = (from p in context.Productos
                      orderby p.Id_producto ascending
                      select p).Take(number).ToList();
            }
            return PartialView(lp);
        }
    }
}