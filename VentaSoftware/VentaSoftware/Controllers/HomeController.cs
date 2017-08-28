using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VentaSoftware.Models;

namespace VentaSoftware.Controllers
{
    public class HomeController : Controller
    {
        private VentaSoftwareContext context = new VentaSoftwareContext();
        // GET: Home
        public ActionResult Index()
        {
            List<Producto> lista = (from p in context.Productos
                                    where p.Estado == true
                                    select p).ToList();
            return View(lista);
        }
    }
}