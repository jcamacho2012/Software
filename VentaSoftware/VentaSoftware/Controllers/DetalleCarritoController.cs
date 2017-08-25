using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VentaSoftware.Models;

namespace VentaSoftware.Controllers
{
    public class DetalleCarritoController : Controller
    {
        private VentaSoftwareContext context = new VentaSoftwareContext();
        // GET: DetalleCarrito
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CrearDetalleCarrito()
        {
            DetalleCarrito detalleCarrito = new DetalleCarrito();
            return View("CrearDetalleCarrito", detalleCarrito);
        }
    }
}