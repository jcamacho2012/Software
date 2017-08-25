using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VentaSoftware.Models;

namespace VentaSoftware.Controllers
{
    public class CarritoCompraController : Controller
    {
        private VentaSoftwareContext context = new VentaSoftwareContext();
        // GET: CarritoCompra
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CrearCarritoCompra()
        {
            CarritoCompra carritoCompra = new CarritoCompra();
            return View("CrearCarritoCompra", carritoCompra);
        }
    }
}