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
            return View("CrearProducto",nuevoProducto);
        }

        [HttpPost]
        public ActionResult CrearProducto(Producto producto)
        {
            if (!ModelState.IsValid)
            {
                return View("CrearProducto",producto);
            }
            context.Productos.Add(producto);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult MostrarProductoxId(int id)
        {
            Producto producto = context.Productos.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View("MostrarProducto",producto);
        }
    }
}