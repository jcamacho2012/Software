using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VentaSoftware.Models;

namespace VentaSoftware.Controllers
{
    public class DetalleFacturaController : Controller
    {
        private VentaSoftwareContext context = new VentaSoftwareContext();
        // GET: DetalleFactura
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CrearDetalleFactura()
        {
            DetalleFactura detalleFactura = new DetalleFactura();
            return View("CrearDetalleFactura",detalleFactura);
        }
    }
}