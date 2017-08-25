using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VentaSoftware.Models;

namespace VentaSoftware.Controllers
{
    public class FacturaController : Controller
    {
        private VentaSoftwareContext context = new VentaSoftwareContext();
        // GET: Factura
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CrearFactura()
        {
            Factura factura = new Factura();
            return View("CrearFactura",factura);
        }
    }
}